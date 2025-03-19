
namespace FrmTrangChu.cs
{
    partial class FrmChiTietHoaDonNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChiTietHoaDonNhap));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtIDChitietNhap = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDonGiaNhap = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtThanhTien = new Guna.UI2.WinForms.Guna2TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnLamMoi = new DevExpress.XtraEditors.SimpleButton();
            this.txtSoLuong = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.txtIDMatHang = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtTenMatHang = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtIDNhap = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtTim = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnTim = new DevExpress.XtraEditors.SimpleButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvChiTietNhap = new Guna.UI2.WinForms.Guna2DataGridView();
            this.IDChitietnhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDMatHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTietNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dtgvChiTietNhap);
            this.splitContainer1.Size = new System.Drawing.Size(950, 615);
            this.splitContainer1.SplitterDistance = 283;
            this.splitContainer1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtIDChitietNhap);
            this.groupBox1.Controls.Add(this.txtDonGiaNhap);
            this.groupBox1.Controls.Add(this.txtThanhTien);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.txtIDMatHang);
            this.groupBox1.Controls.Add(this.txtTenMatHang);
            this.groupBox1.Controls.Add(this.txtIDNhap);
            this.groupBox1.Controls.Add(this.txtTim);
            this.groupBox1.Controls.Add(this.btnTim);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(950, 283);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtIDChitietNhap
            // 
            this.txtIDChitietNhap.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIDChitietNhap.DefaultText = "CTN01";
            this.txtIDChitietNhap.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIDChitietNhap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIDChitietNhap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDChitietNhap.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDChitietNhap.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDChitietNhap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIDChitietNhap.ForeColor = System.Drawing.Color.Black;
            this.txtIDChitietNhap.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDChitietNhap.Location = new System.Drawing.Point(203, 60);
            this.txtIDChitietNhap.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtIDChitietNhap.Name = "txtIDChitietNhap";
            this.txtIDChitietNhap.PasswordChar = '\0';
            this.txtIDChitietNhap.PlaceholderText = "";
            this.txtIDChitietNhap.SelectedText = "";
            this.txtIDChitietNhap.Size = new System.Drawing.Size(268, 36);
            this.txtIDChitietNhap.TabIndex = 2;
            // 
            // txtDonGiaNhap
            // 
            this.txtDonGiaNhap.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDonGiaNhap.DefaultText = "";
            this.txtDonGiaNhap.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDonGiaNhap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDonGiaNhap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDonGiaNhap.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDonGiaNhap.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDonGiaNhap.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDonGiaNhap.ForeColor = System.Drawing.Color.Black;
            this.txtDonGiaNhap.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDonGiaNhap.Location = new System.Drawing.Point(654, 63);
            this.txtDonGiaNhap.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtDonGiaNhap.Name = "txtDonGiaNhap";
            this.txtDonGiaNhap.PasswordChar = '\0';
            this.txtDonGiaNhap.PlaceholderText = "";
            this.txtDonGiaNhap.SelectedText = "";
            this.txtDonGiaNhap.Size = new System.Drawing.Size(282, 33);
            this.txtDonGiaNhap.TabIndex = 6;
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtThanhTien.DefaultText = "";
            this.txtThanhTien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtThanhTien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtThanhTien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtThanhTien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtThanhTien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtThanhTien.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtThanhTien.ForeColor = System.Drawing.Color.Black;
            this.txtThanhTien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtThanhTien.Location = new System.Drawing.Point(652, 155);
            this.txtThanhTien.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.PasswordChar = '\0';
            this.txtThanhTien.PlaceholderText = "";
            this.txtThanhTien.SelectedText = "";
            this.txtThanhTien.Size = new System.Drawing.Size(284, 36);
            this.txtThanhTien.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnLuu);
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.btnLamMoi);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(3, 214);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(944, 66);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            // 
            // btnXoa
            // 
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.Location = new System.Drawing.Point(509, 18);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(112, 42);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.Location = new System.Drawing.Point(356, 18);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(112, 42);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
            this.btnLuu.Location = new System.Drawing.Point(200, 18);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(112, 42);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.Location = new System.Drawing.Point(803, 18);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(112, 42);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.ImageOptions.Image")));
            this.btnLamMoi.Location = new System.Drawing.Point(34, 18);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(112, 42);
            this.btnLamMoi.TabIndex = 0;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.BackColor = System.Drawing.Color.Transparent;
            this.txtSoLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoLuong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSoLuong.Location = new System.Drawing.Point(652, 107);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(284, 34);
            this.txtSoLuong.TabIndex = 7;
            this.txtSoLuong.UseTransparentBackground = true;
            this.txtSoLuong.ValueChanged += new System.EventHandler(this.txtSoLuong_ValueChanged);
            // 
            // txtIDMatHang
            // 
            this.txtIDMatHang.BackColor = System.Drawing.Color.Transparent;
            this.txtIDMatHang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtIDMatHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtIDMatHang.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDMatHang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDMatHang.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtIDMatHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtIDMatHang.ItemHeight = 30;
            this.txtIDMatHang.Location = new System.Drawing.Point(652, 18);
            this.txtIDMatHang.Name = "txtIDMatHang";
            this.txtIDMatHang.Size = new System.Drawing.Size(284, 36);
            this.txtIDMatHang.TabIndex = 5;
            // 
            // txtTenMatHang
            // 
            this.txtTenMatHang.BackColor = System.Drawing.Color.Transparent;
            this.txtTenMatHang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtTenMatHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtTenMatHang.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenMatHang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenMatHang.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTenMatHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtTenMatHang.ItemHeight = 30;
            this.txtTenMatHang.Location = new System.Drawing.Point(203, 155);
            this.txtTenMatHang.Name = "txtTenMatHang";
            this.txtTenMatHang.Size = new System.Drawing.Size(268, 36);
            this.txtTenMatHang.TabIndex = 4;
            // 
            // txtIDNhap
            // 
            this.txtIDNhap.BackColor = System.Drawing.Color.Transparent;
            this.txtIDNhap.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtIDNhap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtIDNhap.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDNhap.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDNhap.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtIDNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtIDNhap.ItemHeight = 30;
            this.txtIDNhap.Location = new System.Drawing.Point(203, 109);
            this.txtIDNhap.Name = "txtIDNhap";
            this.txtIDNhap.Size = new System.Drawing.Size(268, 36);
            this.txtIDNhap.TabIndex = 3;
            // 
            // txtTim
            // 
            this.txtTim.BackColor = System.Drawing.Color.Transparent;
            this.txtTim.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtTim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtTim.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTim.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTim.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtTim.ItemHeight = 30;
            this.txtTim.Location = new System.Drawing.Point(13, 17);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(339, 36);
            this.txtTim.TabIndex = 0;
            // 
            // btnTim
            // 
            this.btnTim.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTim.ImageOptions.Image")));
            this.btnTim.Location = new System.Drawing.Point(359, 17);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(112, 34);
            this.btnTim.TabIndex = 1;
            this.btnTim.Text = "Tìm kiếm";
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label6.Location = new System.Drawing.Point(507, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 30);
            this.label6.TabIndex = 8;
            this.label6.Text = "Số lượng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label5.Location = new System.Drawing.Point(505, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 30);
            this.label5.TabIndex = 9;
            this.label5.Text = "Mã mặt hàng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label7.Location = new System.Drawing.Point(8, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 30);
            this.label7.TabIndex = 10;
            this.label7.Text = "Tên mặt hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label4.Location = new System.Drawing.Point(8, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 30);
            this.label4.TabIndex = 10;
            this.label4.Text = "Mã hoá đơn nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label3.Location = new System.Drawing.Point(507, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 30);
            this.label3.TabIndex = 11;
            this.label3.Text = "Thành tiền";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label2.Location = new System.Drawing.Point(505, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 30);
            this.label2.TabIndex = 12;
            this.label2.Text = "Đơn giá nhập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label1.Location = new System.Drawing.Point(8, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 30);
            this.label1.TabIndex = 13;
            this.label1.Text = "Mã chi tiết nhập";
            // 
            // dtgvChiTietNhap
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtgvChiTietNhap.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvChiTietNhap.BackgroundColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvChiTietNhap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvChiTietNhap.ColumnHeadersHeight = 40;
            this.dtgvChiTietNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDChitietnhap,
            this.IDNhap,
            this.IDMatHang,
            this.SoLuong,
            this.DonGiaNhap,
            this.ThanhTien});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvChiTietNhap.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvChiTietNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvChiTietNhap.GridColor = System.Drawing.Color.Black;
            this.dtgvChiTietNhap.Location = new System.Drawing.Point(0, 0);
            this.dtgvChiTietNhap.Name = "dtgvChiTietNhap";
            this.dtgvChiTietNhap.RowHeadersVisible = false;
            this.dtgvChiTietNhap.RowHeadersWidth = 62;
            this.dtgvChiTietNhap.RowTemplate.Height = 28;
            this.dtgvChiTietNhap.Size = new System.Drawing.Size(950, 328);
            this.dtgvChiTietNhap.TabIndex = 0;
            this.dtgvChiTietNhap.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvChiTietNhap.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgvChiTietNhap.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgvChiTietNhap.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgvChiTietNhap.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgvChiTietNhap.ThemeStyle.BackColor = System.Drawing.Color.DimGray;
            this.dtgvChiTietNhap.ThemeStyle.GridColor = System.Drawing.Color.Black;
            this.dtgvChiTietNhap.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtgvChiTietNhap.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvChiTietNhap.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dtgvChiTietNhap.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgvChiTietNhap.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvChiTietNhap.ThemeStyle.HeaderStyle.Height = 40;
            this.dtgvChiTietNhap.ThemeStyle.ReadOnly = false;
            this.dtgvChiTietNhap.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvChiTietNhap.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvChiTietNhap.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dtgvChiTietNhap.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dtgvChiTietNhap.ThemeStyle.RowsStyle.Height = 28;
            this.dtgvChiTietNhap.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvChiTietNhap.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgvChiTietNhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvChiTietNhap_CellClick);
            // 
            // IDChitietnhap
            // 
            this.IDChitietnhap.DataPropertyName = "IDChitietnhap";
            this.IDChitietnhap.DividerWidth = 1;
            this.IDChitietnhap.HeaderText = "Mã chi tiết nhập";
            this.IDChitietnhap.MinimumWidth = 8;
            this.IDChitietnhap.Name = "IDChitietnhap";
            // 
            // IDNhap
            // 
            this.IDNhap.DataPropertyName = "IDNhap";
            this.IDNhap.DividerWidth = 1;
            this.IDNhap.HeaderText = "Mã hoá đơn nhập";
            this.IDNhap.MinimumWidth = 8;
            this.IDNhap.Name = "IDNhap";
            // 
            // IDMatHang
            // 
            this.IDMatHang.DataPropertyName = "IDMatHang";
            this.IDMatHang.DividerWidth = 1;
            this.IDMatHang.HeaderText = "Mã mặt hàng";
            this.IDMatHang.MinimumWidth = 8;
            this.IDMatHang.Name = "IDMatHang";
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.DividerWidth = 1;
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.MinimumWidth = 8;
            this.SoLuong.Name = "SoLuong";
            // 
            // DonGiaNhap
            // 
            this.DonGiaNhap.DataPropertyName = "DonGiaNhap";
            this.DonGiaNhap.DividerWidth = 1;
            this.DonGiaNhap.HeaderText = "Đơn giá nhập";
            this.DonGiaNhap.MinimumWidth = 8;
            this.DonGiaNhap.Name = "DonGiaNhap";
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.DividerWidth = 1;
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.MinimumWidth = 8;
            this.ThanhTien.Name = "ThanhTien";
            // 
            // FrmChiTietHoaDonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 615);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmChiTietHoaDonNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChiTietHoaDonNhap";
            this.Load += new System.EventHandler(this.FrmChiTietHoaDonNhap_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTietNhap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnLamMoi;
        private Guna.UI2.WinForms.Guna2NumericUpDown txtSoLuong;
        private Guna.UI2.WinForms.Guna2ComboBox txtTenMatHang;
        private Guna.UI2.WinForms.Guna2ComboBox txtIDNhap;
        private Guna.UI2.WinForms.Guna2ComboBox txtTim;
        private DevExpress.XtraEditors.SimpleButton btnTim;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView dtgvChiTietNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDChitietnhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDMatHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGiaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private Guna.UI2.WinForms.Guna2ComboBox txtIDMatHang;
        private Guna.UI2.WinForms.Guna2TextBox txtIDChitietNhap;
        private Guna.UI2.WinForms.Guna2TextBox txtDonGiaNhap;
        private Guna.UI2.WinForms.Guna2TextBox txtThanhTien;
    }
}