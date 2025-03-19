
namespace FrmTrangChu.cs
{
    partial class FrmChiTietHoaDonBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChiTietHoaDonBan));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnLamMoi = new DevExpress.XtraEditors.SimpleButton();
            this.IDMatHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDChitietBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvChiTietBan = new Guna.UI2.WinForms.Guna2DataGridView();
            this.DonGiaXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSoLuong = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.txtIDBan1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnTim = new DevExpress.XtraEditors.SimpleButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtThanhTien = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDonGiaXuat = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtIDChitietBan = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtIDMatHang = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtTenMatHang = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtIDBan = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTietBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.DividerWidth = 1;
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.MinimumWidth = 8;
            this.ThanhTien.Name = "ThanhTien";
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.DividerWidth = 1;
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.MinimumWidth = 8;
            this.SoLuong.Name = "SoLuong";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnLuu);
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.btnLamMoi);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(3, 193);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(942, 66);
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
            // IDMatHang
            // 
            this.IDMatHang.DataPropertyName = "IDMatHang";
            this.IDMatHang.DividerWidth = 1;
            this.IDMatHang.HeaderText = "Mã mặt hàng";
            this.IDMatHang.MinimumWidth = 8;
            this.IDMatHang.Name = "IDMatHang";
            // 
            // IDBan
            // 
            this.IDBan.DataPropertyName = "IDBan";
            this.IDBan.DividerWidth = 1;
            this.IDBan.HeaderText = "Mã hoá đơn bán";
            this.IDBan.MinimumWidth = 8;
            this.IDBan.Name = "IDBan";
            // 
            // IDChitietBan
            // 
            this.IDChitietBan.DataPropertyName = "IDChitietBan";
            this.IDChitietBan.DividerWidth = 1;
            this.IDChitietBan.HeaderText = "Mã chi tiết bán";
            this.IDChitietBan.MinimumWidth = 8;
            this.IDChitietBan.Name = "IDChitietBan";
            // 
            // dtgvChiTietBan
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtgvChiTietBan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvChiTietBan.BackgroundColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvChiTietBan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvChiTietBan.ColumnHeadersHeight = 40;
            this.dtgvChiTietBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDChitietBan,
            this.IDBan,
            this.IDMatHang,
            this.SoLuong,
            this.DonGiaXuat,
            this.ThanhTien});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvChiTietBan.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvChiTietBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvChiTietBan.GridColor = System.Drawing.Color.Black;
            this.dtgvChiTietBan.Location = new System.Drawing.Point(0, 0);
            this.dtgvChiTietBan.Name = "dtgvChiTietBan";
            this.dtgvChiTietBan.RowHeadersVisible = false;
            this.dtgvChiTietBan.RowHeadersWidth = 62;
            this.dtgvChiTietBan.RowTemplate.Height = 28;
            this.dtgvChiTietBan.Size = new System.Drawing.Size(948, 302);
            this.dtgvChiTietBan.TabIndex = 0;
            this.dtgvChiTietBan.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvChiTietBan.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgvChiTietBan.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgvChiTietBan.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgvChiTietBan.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgvChiTietBan.ThemeStyle.BackColor = System.Drawing.Color.DimGray;
            this.dtgvChiTietBan.ThemeStyle.GridColor = System.Drawing.Color.Black;
            this.dtgvChiTietBan.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtgvChiTietBan.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvChiTietBan.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dtgvChiTietBan.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgvChiTietBan.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvChiTietBan.ThemeStyle.HeaderStyle.Height = 40;
            this.dtgvChiTietBan.ThemeStyle.ReadOnly = false;
            this.dtgvChiTietBan.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvChiTietBan.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvChiTietBan.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dtgvChiTietBan.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dtgvChiTietBan.ThemeStyle.RowsStyle.Height = 28;
            this.dtgvChiTietBan.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvChiTietBan.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgvChiTietBan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvChiTietBan_CellClick);
            // 
            // DonGiaXuat
            // 
            this.DonGiaXuat.DataPropertyName = "DonGiaXuat";
            this.DonGiaXuat.DividerWidth = 1;
            this.DonGiaXuat.HeaderText = "Đơn giá xuất";
            this.DonGiaXuat.MinimumWidth = 8;
            this.DonGiaXuat.Name = "DonGiaXuat";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.BackColor = System.Drawing.Color.Transparent;
            this.txtSoLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoLuong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSoLuong.Location = new System.Drawing.Point(652, 107);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(283, 34);
            this.txtSoLuong.TabIndex = 7;
            this.txtSoLuong.ValueChanged += new System.EventHandler(this.txtSoLuong_ValueChanged);
            // 
            // txtIDBan1
            // 
            this.txtIDBan1.BackColor = System.Drawing.Color.Transparent;
            this.txtIDBan1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtIDBan1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtIDBan1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDBan1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDBan1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtIDBan1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtIDBan1.ItemHeight = 30;
            this.txtIDBan1.Location = new System.Drawing.Point(13, 17);
            this.txtIDBan1.Name = "txtIDBan1";
            this.txtIDBan1.Size = new System.Drawing.Size(339, 36);
            this.txtIDBan1.TabIndex = 0;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label4.Location = new System.Drawing.Point(8, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 30);
            this.label4.TabIndex = 10;
            this.label4.Text = "Mã hoá đơn bán";
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
            this.label2.Size = new System.Drawing.Size(134, 30);
            this.label2.TabIndex = 12;
            this.label2.Text = "Đơn giá xuất";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label1.Location = new System.Drawing.Point(8, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 30);
            this.label1.TabIndex = 13;
            this.label1.Text = "Mã chi tiết bán";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtThanhTien);
            this.groupBox1.Controls.Add(this.txtDonGiaXuat);
            this.groupBox1.Controls.Add(this.txtIDChitietBan);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.txtIDMatHang);
            this.groupBox1.Controls.Add(this.txtTenMatHang);
            this.groupBox1.Controls.Add(this.txtIDBan);
            this.groupBox1.Controls.Add(this.txtIDBan1);
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
            this.groupBox1.Size = new System.Drawing.Size(948, 262);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
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
            this.txtThanhTien.Font = new System.Drawing.Font("Segoe UI", 9F);
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
            // txtDonGiaXuat
            // 
            this.txtDonGiaXuat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDonGiaXuat.DefaultText = "";
            this.txtDonGiaXuat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDonGiaXuat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDonGiaXuat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDonGiaXuat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDonGiaXuat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDonGiaXuat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDonGiaXuat.ForeColor = System.Drawing.Color.Black;
            this.txtDonGiaXuat.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDonGiaXuat.Location = new System.Drawing.Point(652, 62);
            this.txtDonGiaXuat.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtDonGiaXuat.Name = "txtDonGiaXuat";
            this.txtDonGiaXuat.PasswordChar = '\0';
            this.txtDonGiaXuat.PlaceholderText = "";
            this.txtDonGiaXuat.SelectedText = "";
            this.txtDonGiaXuat.Size = new System.Drawing.Size(284, 34);
            this.txtDonGiaXuat.TabIndex = 6;
            this.txtDonGiaXuat.TextChanged += new System.EventHandler(this.txtDonGiaXuat_TextChanged);
            // 
            // txtIDChitietBan
            // 
            this.txtIDChitietBan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIDChitietBan.DefaultText = "CTB01";
            this.txtIDChitietBan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIDChitietBan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIDChitietBan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDChitietBan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDChitietBan.Enabled = false;
            this.txtIDChitietBan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDChitietBan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIDChitietBan.ForeColor = System.Drawing.Color.Black;
            this.txtIDChitietBan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDChitietBan.Location = new System.Drawing.Point(203, 62);
            this.txtIDChitietBan.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtIDChitietBan.Name = "txtIDChitietBan";
            this.txtIDChitietBan.PasswordChar = '\0';
            this.txtIDChitietBan.PlaceholderText = "";
            this.txtIDChitietBan.SelectedText = "";
            this.txtIDChitietBan.Size = new System.Drawing.Size(268, 34);
            this.txtIDChitietBan.TabIndex = 2;
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
            this.txtIDMatHang.Location = new System.Drawing.Point(652, 15);
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
            // txtIDBan
            // 
            this.txtIDBan.BackColor = System.Drawing.Color.Transparent;
            this.txtIDBan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtIDBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtIDBan.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDBan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDBan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtIDBan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtIDBan.ItemHeight = 30;
            this.txtIDBan.Location = new System.Drawing.Point(203, 109);
            this.txtIDBan.Name = "txtIDBan";
            this.txtIDBan.Size = new System.Drawing.Size(268, 36);
            this.txtIDBan.TabIndex = 3;
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
            this.splitContainer1.Panel2.Controls.Add(this.dtgvChiTietBan);
            this.splitContainer1.Size = new System.Drawing.Size(948, 568);
            this.splitContainer1.SplitterDistance = 262;
            this.splitContainer1.TabIndex = 1;
            // 
            // FrmChiTietHoaDonBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 568);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmChiTietHoaDonBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "950, 615";
            this.Load += new System.EventHandler(this.FrmChiTietHoaDonBan_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTietBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnLamMoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDMatHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDChitietBan;
        private Guna.UI2.WinForms.Guna2DataGridView dtgvChiTietBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGiaXuat;
        private Guna.UI2.WinForms.Guna2NumericUpDown txtSoLuong;
        private Guna.UI2.WinForms.Guna2ComboBox txtIDBan1;
        private DevExpress.XtraEditors.SimpleButton btnTim;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Guna.UI2.WinForms.Guna2ComboBox txtIDBan;
        private Guna.UI2.WinForms.Guna2ComboBox txtTenMatHang;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2ComboBox txtIDMatHang;
        private Guna.UI2.WinForms.Guna2TextBox txtIDChitietBan;
        private Guna.UI2.WinForms.Guna2TextBox txtThanhTien;
        private Guna.UI2.WinForms.Guna2TextBox txtDonGiaXuat;
    }
}