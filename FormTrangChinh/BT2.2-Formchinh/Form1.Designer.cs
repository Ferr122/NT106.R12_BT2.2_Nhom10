namespace BT2._2
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtLoiChao = new Label();
            txtUserName = new Label();
            txtLastLogin = new Label();
            btnDangXuat = new Button();
            txtEmail = new Label();
            SuspendLayout();
            // 
            // txtLoiChao
            // 
            txtLoiChao.AutoSize = true;
            txtLoiChao.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            txtLoiChao.ForeColor = SystemColors.Highlight;
            txtLoiChao.Location = new Point(12, 25);
            txtLoiChao.Name = "txtLoiChao";
            txtLoiChao.Size = new Size(104, 41);
            txtLoiChao.TabIndex = 0;
            txtLoiChao.Text = "label1";
            // 
            // txtUserName
            // 
            txtUserName.AutoSize = true;
            txtUserName.Font = new Font("Segoe UI", 13F);
            txtUserName.Location = new Point(33, 107);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(83, 36);
            txtUserName.TabIndex = 1;
            txtUserName.Text = "label1";
            // 
            // txtLastLogin
            // 
            txtLastLogin.AutoSize = true;
            txtLastLogin.Font = new Font("Segoe UI", 13F);
            txtLastLogin.Location = new Point(33, 280);
            txtLastLogin.Name = "txtLastLogin";
            txtLastLogin.Size = new Size(83, 36);
            txtLastLogin.TabIndex = 3;
            txtLastLogin.Text = "label1";
            // 
            // btnDangXuat
            // 
            btnDangXuat.BackColor = Color.MediumSpringGreen;
            btnDangXuat.Font = new Font("Segoe UI", 13F);
            btnDangXuat.ForeColor = SystemColors.Desktop;
            btnDangXuat.Location = new Point(557, 362);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(231, 76);
            btnDangXuat.TabIndex = 5;
            btnDangXuat.Text = "Đăng Xuất";
            btnDangXuat.UseVisualStyleBackColor = false;
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // txtEmail
            // 
            txtEmail.AutoSize = true;
            txtEmail.Font = new Font("Segoe UI", 13F);
            txtEmail.Location = new Point(33, 189);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(83, 36);
            txtEmail.TabIndex = 6;
            txtEmail.Text = "label1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtEmail);
            Controls.Add(btnDangXuat);
            Controls.Add(txtLastLogin);
            Controls.Add(txtUserName);
            Controls.Add(txtLoiChao);
            Name = "FormMain";
            Text = "Trang chính";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtLoiChao;
        private Label txtUserName;
        private Label label1;
        private Label txtLastLogin;
        private Button btnDangXuat;
        private Label label3;
        private Label txtEmail;
    }
}
