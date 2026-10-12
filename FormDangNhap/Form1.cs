using System;
using System.Data;
using System.Data.SqlClient; // Hoặc Microsoft.Data.SqlClient tùy theo project của bạn
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace QuanLyNguoiDung
{
    public partial class FrmDangNhap : Form
    {
        private const string ChuoiKetNoi =
            @"Server=localhost\SQLEXPRESS; Database=QuanLyNguoiDung; Trusted_Connection=True; TrustServerCertificate=True;";

        private bool dangHienMatKhau = false;

        public FrmDangNhap()
        {
            InitializeComponent();

            lblThongBaoLoi.Text = "";
            lblThongBaoLoi.ForeColor = Color.Red;
            txtMatKhau.PasswordChar = '●'; 
        }

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {
            txtTenDangNhap.Focus();
        }

        // 1. Sự kiện nút Đăng nhập
        private async void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtTenDangNhap.Text.Trim();
            string matKhau = txtMatKhau.Text;

            if (string.IsNullOrEmpty(tenDangNhap) || string.IsNullOrEmpty(matKhau))
            {
                lblThongBaoLoi.Text = "Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu.";
                return;
            }

            btnDangNhap.Enabled = false;
            btnDangNhap.Text = "Đang xử lý...";
            lblThongBaoLoi.Text = "";

            try
            {
                bool dangNhapThanhCong = false;
                string hoTenUser = "";
                string saltLuu = "";
                string bamLuu = "";

                const string sql = "SELECT Salt, MatKhauBam, HoTen FROM Users WHERE TenDangNhap = @ten";

                using (var conn = new SqlConnection(ChuoiKetNoi))
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@ten", SqlDbType.NVarChar, 20).Value = tenDangNhap;
                    await conn.OpenAsync();

                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            saltLuu = reader["Salt"].ToString();
                            bamLuu = reader["MatKhauBam"].ToString();
                            hoTenUser = reader["HoTen"].ToString();

                            if (MatKhau.KiemTra(matKhau, saltLuu, bamLuu))
                            {
                                dangNhapThanhCong = true;
                            }
                        }
                    }
                }

                if (dangNhapThanhCong)
                {
                    FrmChinh frmChinh = new FrmChinh(hoTenUser, tenDangNhap);
                    this.Hide();
                    frmChinh.ShowDialog();
                    this.Close();
                }
                else
                {
                    lblThongBaoLoi.Text = "Tên đăng nhập hoặc mật khẩu không đúng";
                    txtMatKhau.Clear();
                    txtMatKhau.Focus();
                }
            }
            catch (Exception)
            {
                lblThongBaoLoi.Text = "Không thể kết nối đến cơ sở dữ liệu. Vui lòng kiểm tra lại.";
            }
            finally
            {
                btnDangNhap.Enabled = true;
                btnDangNhap.Text = "Đăng nhập";
            }
        }

        // 2. Liên kết chuyển sang Form Đăng ký
        private void lnkDangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmDangKy frmDangKy = new FrmDangKy();
            this.Hide();
            frmDangKy.ShowDialog();
            this.Show(); 
        }

        // 3. Liên kết chuyển sang Form Quên mật khẩu
        private void lnkQuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmQuenMatKhau frmQuenMK = new FrmQuenMatKhau();
            this.Hide();
            frmQuenMK.ShowDialog();
            this.Show(); 
        }

        // 4. Xử lý nút ẩn/hiện mật khẩu bằng icon mắt (PictureBox)
        private void picAnHienMatKhau_Click(object sender, EventArgs e)
        {
            if (đangHiệnMậtKhẩu)
            {
                txtMatKhau.PasswordChar = '●';
                đangHiệnMậtKhẩu = false;

                picAnHienMatKhau.Image = Properties.Resources.eye_closed;
            }
            else
            {
                txtMatKhau.PasswordChar = '\0';
                đangHiệnMậtKhẩu = true;

                picAnHienMatKhau.Image = Properties.Resources.eye_open;
            }
        }

        private void btnThoát_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}