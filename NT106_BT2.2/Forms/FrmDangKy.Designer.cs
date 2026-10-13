namespace NT106_BT2._2.Forms
{
    partial class FrmDangKy
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
            lblHoTen = new Label();
            txtHoTen = new TextBox();
            lblLoiHoTen = new Label();
            lblTenDangNhap = new Label();
            txtTenDangNhap = new TextBox();
            lblLoiTenDangNhap = new Label();
            lblSDT = new Label();
            txtSDT = new TextBox();
            lblLoiSDT = new Label();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblLoiEmail = new Label();
            lblMatKhau = new Label();
            txtMatKhau = new TextBox();
            lblLoiMatKhau = new Label();
            lblXacNhanMatKhau = new Label();
            txtXacNhanMatKhau = new TextBox();
            lblLoiXacNhanMatKhau = new Label();
            lblThongBaoChung = new Label();
            btnDangKy = new Button();
            btnHuy = new Button();
            SuspendLayout();
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.DarkSlateBlue;
            lblTieuDe.Location = new Point(160, 20);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(286, 37);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "ĐĂNG KÝ TÀI KHOẢN";
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Font = new Font("Segoe UI", 9.5F);
            lblHoTen.Location = new Point(45, 75);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(80, 21);
            lblHoTen.TabIndex = 1;
            lblHoTen.Text = "Họ và tên:";
            // 
            // txtHoTen
            // 
            txtHoTen.Font = new Font("Segoe UI", 10F);
            txtHoTen.Location = new Point(190, 71);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.PlaceholderText = "Ví dụ: Nguyễn Văn A";
            txtHoTen.Size = new Size(350, 30);
            txtHoTen.TabIndex = 2;
            // 
            // lblLoiHoTen
            // 
            lblLoiHoTen.AutoSize = true;
            lblLoiHoTen.Font = new Font("Segoe UI", 8.5F);
            lblLoiHoTen.ForeColor = Color.Red;
            lblLoiHoTen.Location = new Point(190, 104);
            lblLoiHoTen.Name = "lblLoiHoTen";
            lblLoiHoTen.Size = new Size(0, 20);
            lblLoiHoTen.TabIndex = 3;
            // 
            // lblTenDangNhap
            // 
            lblTenDangNhap.AutoSize = true;
            lblTenDangNhap.Font = new Font("Segoe UI", 9.5F);
            lblTenDangNhap.Location = new Point(45, 130);
            lblTenDangNhap.Name = "lblTenDangNhap";
            lblTenDangNhap.Size = new Size(114, 21);
            lblTenDangNhap.TabIndex = 4;
            lblTenDangNhap.Text = "Tên đăng nhập:";
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Font = new Font("Segoe UI", 10F);
            txtTenDangNhap.Location = new Point(190, 126);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.PlaceholderText = "3-20 ký tự (chữ, số, _)";
            txtTenDangNhap.Size = new Size(350, 30);
            txtTenDangNhap.TabIndex = 5;
            // 
            // lblLoiTenDangNhap
            // 
            lblLoiTenDangNhap.AutoSize = true;
            lblLoiTenDangNhap.Font = new Font("Segoe UI", 8.5F);
            lblLoiTenDangNhap.ForeColor = Color.Red;
            lblLoiTenDangNhap.Location = new Point(190, 159);
            lblLoiTenDangNhap.Name = "lblLoiTenDangNhap";
            lblLoiTenDangNhap.Size = new Size(0, 20);
            lblLoiTenDangNhap.TabIndex = 6;
            // 
            // lblSDT
            // 
            lblSDT.AutoSize = true;
            lblSDT.Font = new Font("Segoe UI", 9.5F);
            lblSDT.Location = new Point(45, 185);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(104, 21);
            lblSDT.TabIndex = 7;
            lblSDT.Text = "Số điện thoại:";
            // 
            // txtSDT
            // 
            txtSDT.Font = new Font("Segoe UI", 10F);
            txtSDT.Location = new Point(190, 181);
            txtSDT.Name = "txtSDT";
            txtSDT.PlaceholderText = "10-11 chữ số";
            txtSDT.Size = new Size(350, 30);
            txtSDT.TabIndex = 8;
            // 
            // lblLoiSDT
            // 
            lblLoiSDT.AutoSize = true;
            lblLoiSDT.Font = new Font("Segoe UI", 8.5F);
            lblLoiSDT.ForeColor = Color.Red;
            lblLoiSDT.Location = new Point(190, 214);
            lblLoiSDT.Name = "lblLoiSDT";
            lblLoiSDT.Size = new Size(0, 20);
            lblLoiSDT.TabIndex = 9;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9.5F);
            lblEmail.Location = new Point(45, 240);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(51, 21);
            lblEmail.TabIndex = 10;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 10F);
            txtEmail.Location = new Point(190, 236);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "ten@domain.com (không bắt buộc)";
            txtEmail.Size = new Size(350, 30);
            txtEmail.TabIndex = 11;
            // 
            // lblLoiEmail
            // 
            lblLoiEmail.AutoSize = true;
            lblLoiEmail.Font = new Font("Segoe UI", 8.5F);
            lblLoiEmail.ForeColor = Color.Red;
            lblLoiEmail.Location = new Point(190, 269);
            lblLoiEmail.Name = "lblLoiEmail";
            lblLoiEmail.Size = new Size(0, 20);
            lblLoiEmail.TabIndex = 12;
            // 
            // lblMatKhau
            // 
            lblMatKhau.AutoSize = true;
            lblMatKhau.Font = new Font("Segoe UI", 9.5F);
            lblMatKhau.Location = new Point(45, 295);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(78, 21);
            lblMatKhau.TabIndex = 13;
            lblMatKhau.Text = "Mật khẩu:";
            // 
            // txtMatKhau
            // 
            txtMatKhau.Font = new Font("Segoe UI", 10F);
            txtMatKhau.Location = new Point(190, 291);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '●';
            txtMatKhau.PlaceholderText = "Tối thiểu 8 ký tự (hoa, thường, số, ký tự đặc biệt)";
            txtMatKhau.Size = new Size(350, 30);
            txtMatKhau.TabIndex = 14;
            // 
            // lblLoiMatKhau
            // 
            lblLoiMatKhau.AutoSize = true;
            lblLoiMatKhau.Font = new Font("Segoe UI", 8.5F);
            lblLoiMatKhau.ForeColor = Color.Red;
            lblLoiMatKhau.Location = new Point(190, 324);
            lblLoiMatKhau.Name = "lblLoiMatKhau";
            lblLoiMatKhau.Size = new Size(0, 20);
            lblLoiMatKhau.TabIndex = 15;
            // 
            // lblXacNhanMatKhau
            // 
            lblXacNhanMatKhau.AutoSize = true;
            lblXacNhanMatKhau.Font = new Font("Segoe UI", 9.5F);
            lblXacNhanMatKhau.Location = new Point(45, 350);
            lblXacNhanMatKhau.Name = "lblXacNhanMatKhau";
            lblXacNhanMatKhau.Size = new Size(145, 21);
            lblXacNhanMatKhau.TabIndex = 16;
            lblXacNhanMatKhau.Text = "Xác nhận mật khẩu:";
            // 
            // txtXacNhanMatKhau
            // 
            txtXacNhanMatKhau.Font = new Font("Segoe UI", 10F);
            txtXacNhanMatKhau.Location = new Point(190, 346);
            txtXacNhanMatKhau.Name = "txtXacNhanMatKhau";
            txtXacNhanMatKhau.PasswordChar = '●';
            txtXacNhanMatKhau.PlaceholderText = "Nhập lại mật khẩu";
            txtXacNhanMatKhau.Size = new Size(350, 30);
            txtXacNhanMatKhau.TabIndex = 17;
            // 
            // lblLoiXacNhanMatKhau
            // 
            lblLoiXacNhanMatKhau.AutoSize = true;
            lblLoiXacNhanMatKhau.Font = new Font("Segoe UI", 8.5F);
            lblLoiXacNhanMatKhau.ForeColor = Color.Red;
            lblLoiXacNhanMatKhau.Location = new Point(190, 379);
            lblLoiXacNhanMatKhau.Name = "lblLoiXacNhanMatKhau";
            lblLoiXacNhanMatKhau.Size = new Size(0, 20);
            lblLoiXacNhanMatKhau.TabIndex = 18;
            // 
            // lblThongBaoChung
            // 
            lblThongBaoChung.Font = new Font("Segoe UI", 9F);
            lblThongBaoChung.ForeColor = Color.Red;
            lblThongBaoChung.Location = new Point(190, 404);
            lblThongBaoChung.Name = "lblThongBaoChung";
            lblThongBaoChung.Size = new Size(350, 30);
            lblThongBaoChung.TabIndex = 19;
            // 
            // btnDangKy
            // 
            btnDangKy.BackColor = Color.SlateBlue;
            btnDangKy.Cursor = Cursors.Hand;
            btnDangKy.FlatStyle = FlatStyle.Flat;
            btnDangKy.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnDangKy.ForeColor = Color.White;
            btnDangKy.Location = new Point(190, 440);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(160, 42);
            btnDangKy.TabIndex = 20;
            btnDangKy.Text = "Đăng ký";
            btnDangKy.UseVisualStyleBackColor = false;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.WhiteSmoke;
            btnHuy.Cursor = Cursors.Hand;
            btnHuy.FlatStyle = FlatStyle.Flat;
            btnHuy.Font = new Font("Segoe UI", 10F);
            btnHuy.ForeColor = Color.DimGray;
            btnHuy.Location = new Point(380, 440);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(160, 42);
            btnHuy.TabIndex = 21;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // FrmDangKy
            // 
            AcceptButton = btnDangKy;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(590, 505);
            Controls.Add(btnHuy);
            Controls.Add(btnDangKy);
            Controls.Add(lblThongBaoChung);
            Controls.Add(lblLoiXacNhanMatKhau);
            Controls.Add(txtXacNhanMatKhau);
            Controls.Add(lblXacNhanMatKhau);
            Controls.Add(lblLoiMatKhau);
            Controls.Add(txtMatKhau);
            Controls.Add(lblMatKhau);
            Controls.Add(lblLoiEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(lblLoiSDT);
            Controls.Add(txtSDT);
            Controls.Add(lblSDT);
            Controls.Add(lblLoiTenDangNhap);
            Controls.Add(txtTenDangNhap);
            Controls.Add(lblTenDangNhap);
            Controls.Add(lblLoiHoTen);
            Controls.Add(txtHoTen);
            Controls.Add(lblHoTen);
            Controls.Add(lblTieuDe);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmDangKy";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng ký tài khoản";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTieuDe;
        private Label lblHoTen;
        private TextBox txtHoTen;
        private Label lblLoiHoTen;
        private Label lblTenDangNhap;
        private TextBox txtTenDangNhap;
        private Label lblLoiTenDangNhap;
        private Label lblSDT;
        private TextBox txtSDT;
        private Label lblLoiSDT;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblLoiEmail;
        private Label lblMatKhau;
        private TextBox txtMatKhau;
        private Label lblLoiMatKhau;
        private Label lblXacNhanMatKhau;
        private TextBox txtXacNhanMatKhau;
        private Label lblLoiXacNhanMatKhau;
        private Label lblThongBaoChung;
        private Button btnDangKy;
        private Button btnHuy;
    }
}
