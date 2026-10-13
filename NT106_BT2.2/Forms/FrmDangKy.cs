using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using NT106_BT2._2.Database;
using NT106_BT2._2.Helpers;

namespace NT106_BT2._2.Forms
{
    public partial class FrmDangKy : Form
    {
        private readonly UserRepository _userRepository = new UserRepository();

        public FrmDangKy()
        {
            InitializeComponent();
            XoaLoi();
        }

        private void XoaLoi()
        {
            lblLoiHoTen.Text = string.Empty;
            lblLoiTenDangNhap.Text = string.Empty;
            lblLoiSDT.Text = string.Empty;
            lblLoiEmail.Text = string.Empty;
            lblLoiMatKhau.Text = string.Empty;
            lblLoiXacNhanMatKhau.Text = string.Empty;
            lblThongBaoChung.Text = string.Empty;
        }

        private bool KiemTraThongTin()
        {
            XoaLoi();

            string hoTen = txtHoTen.Text.Trim();
            if (string.IsNullOrEmpty(hoTen))
            {
                lblLoiHoTen.Text = "Họ và tên không được để trống!";
                txtHoTen.Focus();
                return false;
            }
            if (!Regex.IsMatch(hoTen, @"^[\p{L} ]{2,50}$"))
            {
                lblLoiHoTen.Text = "Họ và tên từ 2-50 ký tự, chỉ gồm chữ và khoảng trắng!";
                txtHoTen.Focus();
                return false;
            }

            string tenDangNhap = txtTenDangNhap.Text.Trim();
            if (string.IsNullOrEmpty(tenDangNhap))
            {
                lblLoiTenDangNhap.Text = "Tên đăng nhập không được để trống!";
                txtTenDangNhap.Focus();
                return false;
            }
            if (!Regex.IsMatch(tenDangNhap, @"^[a-zA-Z0-9_]{3,20}$"))
            {
                lblLoiTenDangNhap.Text = "Tên đăng nhập phải từ 3-20 ký tự (chữ, số, _)!";
                txtTenDangNhap.Focus();
                return false;
            }

            string soDienThoai = txtSDT.Text.Trim();
            if (!string.IsNullOrEmpty(soDienThoai) && !Regex.IsMatch(soDienThoai, @"^[0-9]{10,11}$"))
            {
                lblLoiSDT.Text = "Số điện thoại phải từ 10-11 chữ số!";
                txtSDT.Focus();
                return false;
            }

            string email = txtEmail.Text.Trim();
            if (!string.IsNullOrEmpty(email) && !Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                lblLoiEmail.Text = "Email không đúng định dạng (Ví dụ: ten@domain.com)!";
                txtEmail.Focus();
                return false;
            }

            string matKhau = txtMatKhau.Text;
            if (string.IsNullOrEmpty(matKhau))
            {
                lblLoiMatKhau.Text = "Mật khẩu không được để trống!";
                txtMatKhau.Focus();
                return false;
            }
            if (!Regex.IsMatch(matKhau, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^a-zA-Z0-9\s])\S{8,}$"))
            {
                lblLoiMatKhau.Text = "Tối thiểu 8 ký tự: hoa, thường, số, ký tự đặc biệt!";
                txtMatKhau.Focus();
                return false;
            }

            if (txtXacNhanMatKhau.Text != matKhau)
            {
                lblLoiXacNhanMatKhau.Text = "Xác nhận mật khẩu không trùng khớp!";
                txtXacNhanMatKhau.Focus();
                return false;
            }

            return true;
        }

        private async void btnDangKy_Click(object sender, EventArgs e)
        {
            // Bước 1: Kiểm tra hợp lệ dữ liệu trên Form trước khi gọi xuống CSDL
            if (!KiemTraThongTin())
            {
                return;
            }

            string tenDangNhap = txtTenDangNhap.Text.Trim();
            string hoTen = txtHoTen.Text.Trim();
            string soDienThoai = txtSDT.Text.Trim();
            string email = txtEmail.Text.Trim();
            string matKhau = txtMatKhau.Text;

            // Khóa nút trong lúc chờ cơ sở dữ liệu phản hồi
            btnDangKy.Enabled = false;
            btnDangKy.Text = "Đang xử lý...";

            try
            {
                // Bước 2: Kiểm tra trùng tên đăng nhập ở mức chương trình
                bool tonTai = await _userRepository.KiemTraTenDangNhapTonTaiAsync(tenDangNhap);
                if (tonTai)
                {
                    lblLoiTenDangNhap.Text = "Tên này đã có người dùng!";
                    txtTenDangNhap.Focus();
                    return;
                }

                // Bước 3: Băm mật khẩu kèm salt bằng PBKDF2 (600,000 vòng)
                var (salt, matKhauBam) = MatKhau.Tao(matKhau);

                // Bước 4: Thêm vào bảng Users
                bool thanhCong = await _userRepository.ThemNguoiDungAsync(
                    tenDangNhap,
                    matKhauBam,
                    salt,
                    hoTen,
                    string.IsNullOrWhiteSpace(soDienThoai) ? null : soDienThoai,
                    string.IsNullOrWhiteSpace(email) ? null : email
                );

                if (thanhCong)
                {
                    MessageBox.Show("Tạo tài khoản mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Quay về Form Đăng nhập
                }
                else
                {
                    lblThongBaoChung.Text = "Đăng ký không thành công. Vui lòng thử lại.";
                }
            }
            catch (Exception)
            {
                // Xử lý khi CSDL ngắt kết nối hoặc lỗi dịch vụ SQL Server
                string thongBaoLoi = "Không thể kết nối đến cơ sở dữ liệu. Vui lòng kiểm tra lại dịch vụ SQL Server.";
                lblThongBaoChung.Text = thongBaoLoi;
                MessageBox.Show(thongBaoLoi, "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnDangKy.Enabled = true;
                btnDangKy.Text = "Đăng ký";
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close(); // Hủy và quay về Form Đăng nhập
        }
    }
}
