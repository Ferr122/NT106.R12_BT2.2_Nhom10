namespace BT2._2
{
    partial class Form1 : Form
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
            lblTieuDe = new Label();
            lblTenDangNhap = new Label();
            lblMatKhau = new Label();
            lblThongBaoLoi = new Label();
            txtTenDangNhap = new TextBox();
            txtMatKhau = new TextBox();
            eyes = new Button();
            btnDangNhap = new Button();
            checkBox1 = new CheckBox();
            lnkQuenMatKhau = new LinkLabel();
            lnkDangKy = new LinkLabel();
            SuspendLayout();
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTieuDe.Location = new Point(98, 35);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(161, 38);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "Đăng nhập";

            // 
            // lblTenDangNhap
            // 
            lblTenDangNhap.AutoSize = true;
            lblTenDangNhap.ImageAlign = ContentAlignment.MiddleLeft;
            lblTenDangNhap.Location = new Point(26, 95);
            lblTenDangNhap.Name = "lblTenDangNhap";
            lblTenDangNhap.Size = new Size(112, 20);
            lblTenDangNhap.TabIndex = 1;
            lblTenDangNhap.Text = "Tên Đăng Nhập";
            lblTenDangNhap.TextAlign = ContentAlignment.MiddleLeft;

            // 
            // lblMatKhau
            // 
            lblMatKhau.AutoSize = true;
            lblMatKhau.ImageAlign = ContentAlignment.BottomCenter;
            lblMatKhau.Location = new Point(26, 165);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(72, 20);
            lblMatKhau.TabIndex = 2;
            lblMatKhau.Text = "Mật Khẩu";
            // 
            // lblThongBaoLoi
            // 
            lblThongBaoLoi.AutoSize = true;
            lblThongBaoLoi.Location = new Point(98, 350);
            lblThongBaoLoi.Name = "lblThongBaoLoi";
            lblThongBaoLoi.Size = new Size(50, 20);
            lblThongBaoLoi.TabIndex = 3;
            lblThongBaoLoi.Text = "";
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.BorderStyle = BorderStyle.FixedSingle;
            txtTenDangNhap.Location = new Point(26, 124);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.PlaceholderText = "Nhập tên đăng nhập";
            txtTenDangNhap.Size = new Size(300, 27);
            txtTenDangNhap.TabIndex = 4;
            // 
            // txtMatKhau
            // 
            txtMatKhau.BorderStyle = BorderStyle.FixedSingle;
            txtMatKhau.Location = new Point(26, 192);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PlaceholderText = "Nhập mật khẩu";
            txtMatKhau.Size = new Size(300, 27);
            txtMatKhau.TabIndex = 5;
            // 
            // eyes
            // 
            eyes.Location = new Point(300, 193);
            eyes.Name = "eyes";
            eyes.Size = new Size(25, 25);
            eyes.TabIndex = 6;
            eyes.Text = "👁️";
            eyes.UseVisualStyleBackColor = true;
            // 
            // btnDangNhap
            // 
            btnDangNhap.Location = new Point(25, 291);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(300, 56);
            btnDangNhap.TabIndex = 8;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(26, 225);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(157, 24);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "Ghi nhớ đăng nhập";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // lnkQuenMatKhau
            // 
            lnkQuenMatKhau.AutoSize = true;
            lnkQuenMatKhau.Location = new Point(26, 259);
            lnkQuenMatKhau.Name = "lnkQuenMatKhau";
            lnkQuenMatKhau.Size = new Size(116, 20);
            lnkQuenMatKhau.TabIndex = 10;
            lnkQuenMatKhau.TabStop = true;
            lnkQuenMatKhau.Text = "Quên mật khẩu?";
            // 
            // lnkDangKy
            // 
            lnkDangKy.AutoSize = true;
            lnkDangKy.Location = new Point(198, 259);
            lnkDangKy.Name = "lnkDangKy";
            lnkDangKy.Size = new Size(128, 20);
            lnkDangKy.TabIndex = 11;
            lnkDangKy.TabStop = true;
            lnkDangKy.Text = "Đăng ký tài khoản";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(352, 579);
            Controls.Add(lnkDangKy);
            Controls.Add(lnkQuenMatKhau);
            Controls.Add(checkBox1);
            Controls.Add(btnDangNhap);
            Controls.Add(eyes);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTenDangNhap);
            Controls.Add(lblThongBaoLoi);
            Controls.Add(lblMatKhau);
            Controls.Add(lblTenDangNhap);
            Controls.Add(lblTieuDe);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTieuDe;
        private Label lblTenDangNhap;
        private Label lblMatKhau;
        private Label lblThongBaoLoi;
        private TextBox txtTenDangNhap;
        private TextBox txtMatKhau;
        private Button eyes;
        private Button btnDangNhap;
        private CheckBox checkBox1;
        private LinkLabel lnkQuenMatKhau;
        private LinkLabel lnkDangKy;
    }
}
