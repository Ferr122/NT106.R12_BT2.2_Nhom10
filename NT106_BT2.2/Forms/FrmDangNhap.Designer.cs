namespace NT106_BT2._2.Forms
{
    partial class FrmDangNhap
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
            lblTieuDe = new Label();
            lblTenDangNhap = new Label();
            lblMatKhau = new Label();
            lblThongBaoLoi = new Label();
            txtTenDangNhap = new TextBox();
            txtMatKhau = new TextBox();
            btnAnHienMatKhau = new Button();
            btnDangNhap = new Button();
            btnThoat = new Button();
            lnkDangKy = new LinkLabel();
            SuspendLayout();
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTieuDe.ForeColor = Color.DarkSlateBlue;
            lblTieuDe.Location = new Point(105, 30);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(166, 38);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "ĐĂNG NHẬP";
            // 
            // lblTenDangNhap
            // 
            lblTenDangNhap.AutoSize = true;
            lblTenDangNhap.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTenDangNhap.Location = new Point(35, 85);
            lblTenDangNhap.Name = "lblTenDangNhap";
            lblTenDangNhap.Size = new Size(114, 21);
            lblTenDangNhap.TabIndex = 1;
            lblTenDangNhap.Text = "Tên đăng nhập:";
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Font = new Font("Segoe UI", 10F);
            txtTenDangNhap.Location = new Point(35, 110);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.PlaceholderText = "Nhập tên đăng nhập";
            txtTenDangNhap.Size = new Size(300, 30);
            txtTenDangNhap.TabIndex = 2;
            // 
            // lblMatKhau
            // 
            lblMatKhau.AutoSize = true;
            lblMatKhau.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMatKhau.Location = new Point(35, 155);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(78, 21);
            lblMatKhau.TabIndex = 3;
            lblMatKhau.Text = "Mật khẩu:";
            // 
            // txtMatKhau
            // 
            txtMatKhau.Font = new Font("Segoe UI", 10F);
            txtMatKhau.Location = new Point(35, 180);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '●';
            txtMatKhau.PlaceholderText = "Nhập mật khẩu";
            txtMatKhau.Size = new Size(260, 30);
            txtMatKhau.TabIndex = 4;
            // 
            // btnAnHienMatKhau
            // 
            btnAnHienMatKhau.Cursor = Cursors.Hand;
            btnAnHienMatKhau.Font = new Font("Segoe UI", 9F);
            btnAnHienMatKhau.Location = new Point(299, 179);
            btnAnHienMatKhau.Name = "btnAnHienMatKhau";
            btnAnHienMatKhau.Size = new Size(36, 32);
            btnAnHienMatKhau.TabIndex = 5;
            btnAnHienMatKhau.Text = "👁️";
            btnAnHienMatKhau.UseVisualStyleBackColor = true;
            btnAnHienMatKhau.Click += btnAnHienMatKhau_Click;
            // 
            // lblThongBaoLoi
            // 
            lblThongBaoLoi.ForeColor = Color.Red;
            lblThongBaoLoi.Font = new Font("Segoe UI", 9F);
            lblThongBaoLoi.Location = new Point(35, 222);
            lblThongBaoLoi.Name = "lblThongBaoLoi";
            lblThongBaoLoi.Size = new Size(300, 42);
            lblThongBaoLoi.TabIndex = 6;
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.SlateBlue;
            btnDangNhap.Cursor = Cursors.Hand;
            btnDangNhap.FlatStyle = FlatStyle.Flat;
            btnDangNhap.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnDangNhap.ForeColor = Color.White;
            btnDangNhap.Location = new Point(35, 275);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(160, 42);
            btnDangNhap.TabIndex = 7;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.WhiteSmoke;
            btnThoat.Cursor = Cursors.Hand;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Font = new Font("Segoe UI", 10F);
            btnThoat.ForeColor = Color.DimGray;
            btnThoat.Location = new Point(205, 275);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(130, 42);
            btnThoat.TabIndex = 8;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // lnkDangKy
            // 
            lnkDangKy.AutoSize = true;
            lnkDangKy.Font = new Font("Segoe UI", 9.5F);
            lnkDangKy.Location = new Point(80, 335);
            lnkDangKy.Name = "lnkDangKy";
            lnkDangKy.Size = new Size(207, 21);
            lnkDangKy.TabIndex = 9;
            lnkDangKy.TabStop = true;
            lnkDangKy.Text = "Chưa có tài khoản? Đăng ký";
            lnkDangKy.LinkClicked += lnkDangKy_LinkClicked;
            // 
            // FrmDangNhap
            // 
            AcceptButton = btnDangNhap;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 385);
            Controls.Add(lnkDangKy);
            Controls.Add(btnThoat);
            Controls.Add(btnDangNhap);
            Controls.Add(lblThongBaoLoi);
            Controls.Add(btnAnHienMatKhau);
            Controls.Add(txtMatKhau);
            Controls.Add(lblMatKhau);
            Controls.Add(txtTenDangNhap);
            Controls.Add(lblTenDangNhap);
            Controls.Add(lblTieuDe);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            Load += FrmDangNhap_Load;
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
        private Button btnAnHienMatKhau;
        private Button btnDangNhap;
        private Button btnThoat;
        private LinkLabel lnkDangKy;
    }
}
