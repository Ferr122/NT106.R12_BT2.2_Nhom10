using System;
using System.Drawing;
using System.Windows.Forms;
using NT106_BT2._2.Database;
using NT106_BT2._2.Helpers;

namespace NT106_BT2._2.Forms
{
    public partial class FrmDangNhap : Form
    {
        private readonly UserRepository _userRepository = new UserRepository();
        private bool _dangHienMatKhau = false;

        public FrmDangNhap()
        {
            InitializeComponent();
            lblThongBaoLoi.Text = string.Empty;
        }

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {
            txtTenDangNhap.Focus();
        }

        private async void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtTenDangNhap.Text.Trim();
            string matKhau = txtMatKhau.Text;

            // Nhánh kiểm tra ô nhập rỗng (Hình 4)
            if (string.IsNullOrEmpty(tenDangNhap) || string.IsNullOrEmpty(matKhau))
            {
                lblThongBaoLoi.Text = "Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu.";
                if (string.IsNullOrEmpty(tenDangNhap))
                    txtTenDangNhap.Focus();
                else
                    txtMatKhau.Focus();
                return;
            }

            // Khóa nút trong lúc chờ CSDL phản hồi
            btnDangNhap.Enabled = false;
            btnDangNhap.Text = "Đang xử lý...";
            lblThongBaoLoi.Text = string.Empty;

            try
            {
                var user = await _userRepository.LayNguoiDungTheoTenDangNhapAsync(tenDangNhap);

                // Dù sai tên đăng nhập hay sai mật khẩu đều trả về CÙNG MỘT thông báo lỗi duy nhất
                if (user != null && MatKhau.KiemTra(matKhau, user.Salt, user.MatKhauBam))
                {
                    await _userRepository.CapNhatLanDangNhapCuoiAsync(tenDangNhap);

                    DateTime lanDangNhapHienThi = user.LanDangNhapCuoi ?? DateTime.Now;
                    FrmChinh frmChinh = new FrmChinh(user.HoTen, user.TenDangNhap, user.Email ?? "Chưa thiết lập", lanDangNhapHienThi);
                    
                    this.Hide();
                    frmChinh.ShowDialog();

                    txtMatKhau.Clear();
                    this.Show();
                    txtTenDangNhap.Focus();
                }
                else
                {
                    lblThongBaoLoi.Text = "Tên đăng nhập hoặc mật khẩu không đúng.";
                    txtMatKhau.Clear();
                    txtMatKhau.Focus();
                }
            }
            catch (Exception)
            {
                // Thông báo lỗi thân thiện bằng tiếng Việt, không để lộ tên ngoại lệ
                string thongBaoLoi = "Không thể kết nối đến cơ sở dữ liệu. Vui lòng kiểm tra lại dịch vụ SQL Server.";
                lblThongBaoLoi.Text = thongBaoLoi;
                MessageBox.Show(thongBaoLoi, "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnDangNhap.Enabled = true;
                btnDangNhap.Text = "Đăng nhập";
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lnkDangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmDangKy frmDangKy = new FrmDangKy();
            this.Hide();
            frmDangKy.ShowDialog();
            this.Show();
            txtTenDangNhap.Focus();
        }

        private void btnAnHienMatKhau_Click(object sender, EventArgs e)
        {
            if (_dangHienMatKhau)
            {
                txtMatKhau.PasswordChar = '●';
                _dangHienMatKhau = false;
                btnAnHienMatKhau.Text = "👁️";
            }
            else
            {
                txtMatKhau.PasswordChar = '\0';
                _dangHienMatKhau = true;
                btnAnHienMatKhau.Text = "🙈";
            }
        }
    }
}
