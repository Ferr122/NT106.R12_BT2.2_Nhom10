namespace BT2._2
{
    public partial class FormMain : Form
    {
        public FormMain(string FullName, string username, string email, DateTime LastLogin)
        {
            InitializeComponent();
            txtLoiChao.Text = "Xin chào người dùng " + FullName;
            txtUserName.Text = "Ten đăng nhập: " + username;
            txtEmail.Text = "Email: " + email;
            txtLastLogin.Text = "Đăng nhập lần cuối:\n" + LastLogin.ToString();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
