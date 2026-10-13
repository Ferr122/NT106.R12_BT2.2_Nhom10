namespace NT106_BT2._2.Forms
{
    partial class FrmChinh
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            txtLoiChao = new Label();
            txtUserName = new Label();
            txtEmail = new Label();
            txtLastLogin = new Label();
            btnDangXuat = new Button();
            panelCard = new Panel();
            panelCard.SuspendLayout();
            SuspendLayout();
            // 
            // panelCard
            // 
            panelCard.BackColor = Color.White;
            panelCard.BorderStyle = BorderStyle.FixedSingle;
            panelCard.Controls.Add(txtLoiChao);
            panelCard.Controls.Add(txtUserName);
            panelCard.Controls.Add(txtEmail);
            panelCard.Controls.Add(txtLastLogin);
            panelCard.Controls.Add(btnDangXuat);
            panelCard.Location = new Point(30, 30);
            panelCard.Name = "panelCard";
            panelCard.Size = new Size(500, 310);
            panelCard.TabIndex = 0;
            // 
            // txtLoiChao
            // 
            txtLoiChao.AutoSize = true;
            txtLoiChao.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            txtLoiChao.ForeColor = Color.SlateBlue;
            txtLoiChao.Location = new Point(25, 20);
            txtLoiChao.Name = "txtLoiChao";
            txtLoiChao.Size = new Size(307, 37);
            txtLoiChao.TabIndex = 0;
            txtLoiChao.Text = "Xin chào người dùng ...";
            // 
            // txtUserName
            // 
            txtUserName.AutoSize = true;
            txtUserName.Font = new Font("Segoe UI", 11F);
            txtUserName.Location = new Point(25, 80);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(141, 25);
            txtUserName.TabIndex = 1;
            txtUserName.Text = "Tên đăng nhập: ";
            // 
            // txtEmail
            // 
            txtEmail.AutoSize = true;
            txtEmail.Font = new Font("Segoe UI", 11F);
            txtEmail.Location = new Point(25, 125);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(67, 25);
            txtEmail.TabIndex = 2;
            txtEmail.Text = "Email: ";
            // 
            // txtLastLogin
            // 
            txtLastLogin.AutoSize = true;
            txtLastLogin.Font = new Font("Segoe UI", 11F);
            txtLastLogin.Location = new Point(25, 170);
            txtLastLogin.Name = "txtLastLogin";
            txtLastLogin.Size = new Size(183, 25);
            txtLastLogin.TabIndex = 3;
            txtLastLogin.Text = "Đăng nhập lần cuối: ";
            // 
            // btnDangXuat
            // 
            btnDangXuat.BackColor = Color.IndianRed;
            btnDangXuat.Cursor = Cursors.Hand;
            btnDangXuat.FlatStyle = FlatStyle.Flat;
            btnDangXuat.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnDangXuat.ForeColor = Color.White;
            btnDangXuat.Location = new Point(25, 230);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(150, 42);
            btnDangXuat.TabIndex = 4;
            btnDangXuat.Text = "Đăng xuất";
            btnDangXuat.UseVisualStyleBackColor = false;
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // FrmChinh
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 375);
            Controls.Add(panelCard);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmChinh";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trang chính";
            panelCard.ResumeLayout(false);
            panelCard.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelCard;
        private Label txtLoiChao;
        private Label txtUserName;
        private Label txtEmail;
        private Label txtLastLogin;
        private Button btnDangXuat;
    }
}
