using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace FormDangKi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool KiemTraThongTin()
        {
            string hoTen = txtHoTen.Text.Trim();

            if (!Regex.IsMatch(hoTen, @"^[\p{L} ]{2,50}$"))
            {
                MessageBox.Show(
                    "Họ và tên phải từ 2-50 ký tự, chỉ gồm chữ và khoảng trắng!");
                txtHoTen.Focus();
                return false;
            }

            string tenDangNhap = txtTenDangNhap.Text.Trim();

            if (!Regex.IsMatch(tenDangNhap, @"^[a-zA-Z0-9_]{3,20}$"))
            {
                MessageBox.Show(
                    "Tên đăng nhập phải từ 3-20 ký tự, chỉ gồm chữ, số và dấu gạch dưới!");
                txtTenDangNhap.Focus();
                return false;
            }

         
            string soDienThoai = txtSDT.Text.Trim();

            if (!Regex.IsMatch(soDienThoai, @"^[0-9]{10,11}$"))
            {
                MessageBox.Show("Số điện thoại phải gồm 10-11 chữ số!");
                txtSDT.Focus();
                return false;
            }

          
            string email = txtEmail.Text.Trim();

            if (email != "" &&
                !Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Email không đúng định dạng! Ví dụ: ten@mien.com");
                txtEmail.Focus();
                return false;
            }

         
      
            string matKhau = txtMatKhau.Text;

            if (!Regex.IsMatch(matKhau,@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^a-zA-Z0-9\s])\S{8,}$"))
            {
                MessageBox.Show(
                    "Mật khẩu phải có ít nhất 8 ký tự, gồm chữ hoa, chữ thường, số và ký tự đặc biệt!");
                txtMatKhau.Focus();
                return false;
            }

            if (txtXacNhanMatKhau.Text != matKhau)
            {
                MessageBox.Show("Xác nhận mật khẩu không khớp!");
                txtXacNhanMatKhau.Focus();
                return false;
            }

            string tenHienThi = txtTenHienThi.Text.Trim();

            if (tenHienThi.Length < 2 || tenHienThi.Length > 30)
            {
                MessageBox.Show("Tên hiển thị phải từ 2-30 ký tự!");
                txtTenHienThi.Focus();
                return false;
            }

     
            if (!chkDongYDieuKhoan.Checked)
            {
                MessageBox.Show("Bạn phải đồng ý với điều khoản để đăng ký!");
                chkDongYDieuKhoan.Focus();
                return false;
            }

           
            return true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bttDangKy_Click(object sender, EventArgs e)
        {
            if (!KiemTraThongTin())
            {
                return;
            }

            MessageBox.Show("Thông tin hợp lệ!");
        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtXacNhanMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTenHienThi_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkDongYDieuKhoan_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bttHuy_Click(object sender, EventArgs e)
        {
            txtHoTen.Clear();
            txtTenDangNhap.Clear();
            txtSDT.Clear();
            txtEmail.Clear();
            txtMatKhau.Clear();
            txtXacNhanMatKhau.Clear();
            txtTenHienThi.Clear();

            chkDongYDieuKhoan.Checked = false;

            txtHoTen.Focus();

    }
}
}
