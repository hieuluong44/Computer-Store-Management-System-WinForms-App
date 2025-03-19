
namespace FrmTrangChu.cs
{
    partial class FrmQuenMatKhau
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuenMatKhau));
            this.txtTenCV = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSDT = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMaCV = new Guna.UI2.WinForms.Guna2TextBox();
            this.drbThongTin = new Guna.UI2.WinForms.Guna2GroupBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnLamMoi = new DevExpress.XtraEditors.SimpleButton();
            this.btnXacThuc = new DevExpress.XtraEditors.SimpleButton();
            this.txtIDNhanvien = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCCCD = new Guna.UI2.WinForms.Guna2TextBox();
            this.grbDoiMK = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnDoiMK = new DevExpress.XtraEditors.SimpleButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTenDangNhap = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtLapLai = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMKmoi = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.drbThongTin.SuspendLayout();
            this.grbDoiMK.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTenCV
            // 
            this.txtTenCV.BackColor = System.Drawing.Color.Transparent;
            this.txtTenCV.BorderColor = System.Drawing.Color.Black;
            this.txtTenCV.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtTenCV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtTenCV.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenCV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenCV.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTenCV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtTenCV.ItemHeight = 30;
            this.txtTenCV.Location = new System.Drawing.Point(152, 64);
            this.txtTenCV.Name = "txtTenCV";
            this.txtTenCV.Size = new System.Drawing.Size(425, 36);
            this.txtTenCV.TabIndex = 0;
            this.txtTenCV.SelectedIndexChanged += new System.EventHandler(this.txtTenCV_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "Tên chức vụ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "Mã chức vụ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 25);
            this.label3.TabIndex = 26;
            this.label3.Text = "Số điện thoại";
            // 
            // txtSDT
            // 
            this.txtSDT.BorderColor = System.Drawing.Color.Black;
            this.txtSDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSDT.DefaultText = "";
            this.txtSDT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSDT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSDT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSDT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSDT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSDT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSDT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSDT.Location = new System.Drawing.Point(152, 265);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.PasswordChar = '\0';
            this.txtSDT.PlaceholderText = "";
            this.txtSDT.SelectedText = "";
            this.txtSDT.Size = new System.Drawing.Size(425, 44);
            this.txtSDT.TabIndex = 3;
            // 
            // txtMaCV
            // 
            this.txtMaCV.BorderColor = System.Drawing.Color.Black;
            this.txtMaCV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaCV.DefaultText = "";
            this.txtMaCV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaCV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaCV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaCV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaCV.Enabled = false;
            this.txtMaCV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaCV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaCV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaCV.Location = new System.Drawing.Point(152, 125);
            this.txtMaCV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaCV.Name = "txtMaCV";
            this.txtMaCV.PasswordChar = '\0';
            this.txtMaCV.PlaceholderText = "";
            this.txtMaCV.SelectedText = "";
            this.txtMaCV.Size = new System.Drawing.Size(172, 44);
            this.txtMaCV.TabIndex = 1;
            // 
            // drbThongTin
            // 
            this.drbThongTin.Controls.Add(this.simpleButton1);
            this.drbThongTin.Controls.Add(this.btnLamMoi);
            this.drbThongTin.Controls.Add(this.btnXacThuc);
            this.drbThongTin.Controls.Add(this.txtTenCV);
            this.drbThongTin.Controls.Add(this.label1);
            this.drbThongTin.Controls.Add(this.txtIDNhanvien);
            this.drbThongTin.Controls.Add(this.txtMaCV);
            this.drbThongTin.Controls.Add(this.label4);
            this.drbThongTin.Controls.Add(this.label2);
            this.drbThongTin.Controls.Add(this.label8);
            this.drbThongTin.Controls.Add(this.label3);
            this.drbThongTin.Controls.Add(this.txtCCCD);
            this.drbThongTin.Controls.Add(this.txtSDT);
            this.drbThongTin.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.drbThongTin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drbThongTin.ForeColor = System.Drawing.Color.Black;
            this.drbThongTin.Location = new System.Drawing.Point(0, 67);
            this.drbThongTin.Name = "drbThongTin";
            this.drbThongTin.Size = new System.Drawing.Size(596, 465);
            this.drbThongTin.TabIndex = 27;
            this.drbThongTin.Text = "Thông tin cá nhân";
            this.drbThongTin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(436, 413);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(157, 44);
            this.simpleButton1.TabIndex = 7;
            this.simpleButton1.Text = "Thoát";
            this.simpleButton1.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Appearance.Options.UseFont = true;
            this.btnLamMoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.ImageOptions.Image")));
            this.btnLamMoi.Location = new System.Drawing.Point(264, 413);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(141, 44);
            this.btnLamMoi.TabIndex = 6;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnXacThuc
            // 
            this.btnXacThuc.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacThuc.Appearance.Options.UseFont = true;
            this.btnXacThuc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXacThuc.ImageOptions.Image")));
            this.btnXacThuc.Location = new System.Drawing.Point(10, 413);
            this.btnXacThuc.Name = "btnXacThuc";
            this.btnXacThuc.Size = new System.Drawing.Size(233, 44);
            this.btnXacThuc.TabIndex = 5;
            this.btnXacThuc.Text = "Xác thực thông tin";
            this.btnXacThuc.Click += new System.EventHandler(this.btnXacThuc_Click);
            // 
            // txtIDNhanvien
            // 
            this.txtIDNhanvien.BorderColor = System.Drawing.Color.Black;
            this.txtIDNhanvien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIDNhanvien.DefaultText = "";
            this.txtIDNhanvien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIDNhanvien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIDNhanvien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDNhanvien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDNhanvien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDNhanvien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIDNhanvien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDNhanvien.Location = new System.Drawing.Point(152, 196);
            this.txtIDNhanvien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIDNhanvien.Name = "txtIDNhanvien";
            this.txtIDNhanvien.PasswordChar = '\0';
            this.txtIDNhanvien.PlaceholderText = "";
            this.txtIDNhanvien.SelectedText = "";
            this.txtIDNhanvien.Size = new System.Drawing.Size(172, 44);
            this.txtIDNhanvien.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 25);
            this.label4.TabIndex = 26;
            this.label4.Text = "Mã nhân viên";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 355);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 25);
            this.label8.TabIndex = 26;
            this.label8.Text = "Căn cước";
            // 
            // txtCCCD
            // 
            this.txtCCCD.BorderColor = System.Drawing.Color.Black;
            this.txtCCCD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCCCD.DefaultText = "";
            this.txtCCCD.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCCCD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCCCD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCCCD.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCCCD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCCCD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCCCD.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCCCD.Location = new System.Drawing.Point(152, 336);
            this.txtCCCD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.PasswordChar = '\0';
            this.txtCCCD.PlaceholderText = "";
            this.txtCCCD.SelectedText = "";
            this.txtCCCD.Size = new System.Drawing.Size(425, 44);
            this.txtCCCD.TabIndex = 4;
            // 
            // grbDoiMK
            // 
            this.grbDoiMK.Controls.Add(this.btnThoat);
            this.grbDoiMK.Controls.Add(this.btnDoiMK);
            this.grbDoiMK.Controls.Add(this.label7);
            this.grbDoiMK.Controls.Add(this.label5);
            this.grbDoiMK.Controls.Add(this.label6);
            this.grbDoiMK.Controls.Add(this.txtTenDangNhap);
            this.grbDoiMK.Controls.Add(this.txtLapLai);
            this.grbDoiMK.Controls.Add(this.txtMKmoi);
            this.grbDoiMK.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.grbDoiMK.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grbDoiMK.ForeColor = System.Drawing.Color.Black;
            this.grbDoiMK.Location = new System.Drawing.Point(602, 67);
            this.grbDoiMK.Name = "grbDoiMK";
            this.grbDoiMK.Size = new System.Drawing.Size(520, 465);
            this.grbDoiMK.TabIndex = 27;
            this.grbDoiMK.Text = "Thông tin tài khoản";
            this.grbDoiMK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.Location = new System.Drawing.Point(348, 309);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(157, 44);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDoiMK
            // 
            this.btnDoiMK.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiMK.Appearance.Options.UseFont = true;
            this.btnDoiMK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDoiMK.ImageOptions.Image")));
            this.btnDoiMK.Location = new System.Drawing.Point(30, 309);
            this.btnDoiMK.Name = "btnDoiMK";
            this.btnDoiMK.Size = new System.Drawing.Size(213, 44);
            this.btnDoiMK.TabIndex = 3;
            this.btnDoiMK.Text = "Đổi mật khẩu";
            this.btnDoiMK.Click += new System.EventHandler(this.btnDoiMK_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(25, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(199, 25);
            this.label7.TabIndex = 30;
            this.label7.Text = "Lặp lại mật khẩu mới";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(25, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 25);
            this.label5.TabIndex = 31;
            this.label5.Text = "Mật khẩu mới";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(25, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 25);
            this.label6.TabIndex = 33;
            this.label6.Text = "Tên đăng nhập";
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.BorderColor = System.Drawing.Color.Black;
            this.txtTenDangNhap.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenDangNhap.DefaultText = "";
            this.txtTenDangNhap.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenDangNhap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenDangNhap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenDangNhap.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenDangNhap.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenDangNhap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenDangNhap.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenDangNhap.Location = new System.Drawing.Point(242, 56);
            this.txtTenDangNhap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.PasswordChar = '\0';
            this.txtTenDangNhap.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtTenDangNhap.PlaceholderText = "Nhập mã nhân viên";
            this.txtTenDangNhap.SelectedText = "";
            this.txtTenDangNhap.Size = new System.Drawing.Size(263, 44);
            this.txtTenDangNhap.TabIndex = 0;
            // 
            // txtLapLai
            // 
            this.txtLapLai.BorderColor = System.Drawing.Color.Black;
            this.txtLapLai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLapLai.DefaultText = "";
            this.txtLapLai.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLapLai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLapLai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLapLai.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLapLai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLapLai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLapLai.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLapLai.Location = new System.Drawing.Point(242, 196);
            this.txtLapLai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLapLai.Name = "txtLapLai";
            this.txtLapLai.PasswordChar = '\0';
            this.txtLapLai.PlaceholderText = "";
            this.txtLapLai.SelectedText = "";
            this.txtLapLai.Size = new System.Drawing.Size(263, 44);
            this.txtLapLai.TabIndex = 2;
            // 
            // txtMKmoi
            // 
            this.txtMKmoi.BorderColor = System.Drawing.Color.Black;
            this.txtMKmoi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMKmoi.DefaultText = "";
            this.txtMKmoi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMKmoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMKmoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMKmoi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMKmoi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMKmoi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMKmoi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMKmoi.Location = new System.Drawing.Point(242, 125);
            this.txtMKmoi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMKmoi.Name = "txtMKmoi";
            this.txtMKmoi.PasswordChar = '\0';
            this.txtMKmoi.PlaceholderText = "";
            this.txtMKmoi.SelectedText = "";
            this.txtMKmoi.Size = new System.Drawing.Size(263, 44);
            this.txtMKmoi.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureEdit1);
            this.panel1.Controls.Add(this.guna2HtmlLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1122, 61);
            this.panel1.TabIndex = 28;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(407, 12);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(48, 36);
            this.pictureEdit1.TabIndex = 25;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(484, 12);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(171, 36);
            this.guna2HtmlLabel1.TabIndex = 24;
            this.guna2HtmlLabel1.Text = "Đổi mật khẩu";
            this.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmQuenMatKhau
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 531);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grbDoiMK);
            this.Controls.Add(this.drbThongTin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmQuenMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmQuenMatKhau";
            this.Load += new System.EventHandler(this.FrmQuenMatKhau_Load);
            this.drbThongTin.ResumeLayout(false);
            this.drbThongTin.PerformLayout();
            this.grbDoiMK.ResumeLayout(false);
            this.grbDoiMK.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox txtTenCV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtSDT;
        private Guna.UI2.WinForms.Guna2TextBox txtMaCV;
        private Guna.UI2.WinForms.Guna2GroupBox drbThongTin;
        private Guna.UI2.WinForms.Guna2GroupBox grbDoiMK;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txtCCCD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtTenDangNhap;
        private Guna.UI2.WinForms.Guna2TextBox txtLapLai;
        private Guna.UI2.WinForms.Guna2TextBox txtMKmoi;
        private DevExpress.XtraEditors.SimpleButton btnLamMoi;
        private DevExpress.XtraEditors.SimpleButton btnXacThuc;
        private DevExpress.XtraEditors.SimpleButton btnDoiMK;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private Guna.UI2.WinForms.Guna2TextBox txtIDNhanvien;
        private System.Windows.Forms.Label label4;
    }
}