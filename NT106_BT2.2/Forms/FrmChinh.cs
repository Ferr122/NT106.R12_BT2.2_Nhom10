using System;
using System.Windows.Forms;

namespace NT106_BT2._2.Forms
{
    public partial class FrmChinh : Form
    {
        public FrmChinh(string hoTen, string tenDangNhap, string email, DateTime lanDangNhap)
        {
            InitializeComponent();
            txtLoiChao.Text = "Xin chào " + hoTen + "!";
            txtUserName.Text = "Tên đăng nhập: " + tenDangNhap;
            txtEmail.Text = "Email: " + (string.IsNullOrWhiteSpace(email) ? "Chưa cung cấp" : email);
            txtLastLogin.Text = "Đăng nhập lần cuối: " + lanDangNhap.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
