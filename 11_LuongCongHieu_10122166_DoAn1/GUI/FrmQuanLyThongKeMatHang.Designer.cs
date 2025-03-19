
namespace FrmTrangChu.cs
{
    partial class FrmQuanLyThongKeMatHang
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuanLyThongKeMatHang));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PieSeriesView pieSeriesView1 = new DevExpress.XtraCharts.PieSeriesView();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cboThongKe = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ToDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.FromDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnThongKe = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dtgvThongKeBanChay = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ChartMatHang = new DevExpress.XtraCharts.ChartControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureEdit4 = new DevExpress.XtraEditors.PictureEdit();
            this.txtIDMatHang = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.txtTenMatHang = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.txtSoLuongBan = new System.Windows.Forms.Label();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.dtgvThongKeTonKho = new Guna.UI2.WinForms.Guna2DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureEdit3 = new DevExpress.XtraEditors.PictureEdit();
            this.txtSoLuongTon = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvThongKeBanChay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartMatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit4.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvThongKeTonKho)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cboThongKe
            // 
            this.cboThongKe.BackColor = System.Drawing.Color.Transparent;
            this.cboThongKe.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboThongKe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboThongKe.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboThongKe.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboThongKe.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboThongKe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboThongKe.ItemHeight = 30;
            this.cboThongKe.Items.AddRange(new object[] {
            "Thống kê mặt hàng bán chạy",
            "Thống kê mặt hàng tồn kho"});
            this.cboThongKe.Location = new System.Drawing.Point(701, 54);
            this.cboThongKe.Name = "cboThongKe";
            this.cboThongKe.Size = new System.Drawing.Size(423, 36);
            this.cboThongKe.TabIndex = 0;
            this.cboThongKe.SelectedIndexChanged += new System.EventHandler(this.cboThongKe_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(361, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 27);
            this.label4.TabIndex = 8;
            this.label4.Text = "Đến ngày";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 27);
            this.label1.TabIndex = 9;
            this.label1.Text = "Từ ngày";
            // 
            // ToDate
            // 
            this.ToDate.Checked = true;
            this.ToDate.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.ToDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ToDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.ToDate.Location = new System.Drawing.Point(366, 44);
            this.ToDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.ToDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.ToDate.Name = "ToDate";
            this.ToDate.Size = new System.Drawing.Size(300, 46);
            this.ToDate.TabIndex = 7;
            this.ToDate.Value = new System.DateTime(2024, 5, 29, 11, 18, 10, 924);
            // 
            // FromDate
            // 
            this.FromDate.Checked = true;
            this.FromDate.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.FromDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FromDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.FromDate.Location = new System.Drawing.Point(24, 44);
            this.FromDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.FromDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.FromDate.Name = "FromDate";
            this.FromDate.Size = new System.Drawing.Size(284, 46);
            this.FromDate.TabIndex = 6;
            this.FromDate.Value = new System.DateTime(2024, 5, 29, 11, 18, 9, 123);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnThongKe.Appearance.Options.UseFont = true;
            this.btnThongKe.Appearance.Options.UseForeColor = true;
            this.btnThongKe.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThongKe.ImageOptions.Image")));
            this.btnThongKe.Location = new System.Drawing.Point(1150, 32);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(180, 58);
            this.btnThongKe.TabIndex = 10;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImageOptions.Image")));
            this.groupControl1.Controls.Add(this.dtgvThongKeBanChay);
            this.groupControl1.Location = new System.Drawing.Point(3, 230);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(904, 256);
            this.groupControl1.TabIndex = 11;
            this.groupControl1.Text = "Danh sách thống kê bán chạy";
            // 
            // dtgvThongKeBanChay
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtgvThongKeBanChay.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvThongKeBanChay.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvThongKeBanChay.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvThongKeBanChay.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvThongKeBanChay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvThongKeBanChay.GridColor = System.Drawing.Color.DimGray;
            this.dtgvThongKeBanChay.Location = new System.Drawing.Point(2, 34);
            this.dtgvThongKeBanChay.Name = "dtgvThongKeBanChay";
            this.dtgvThongKeBanChay.RowHeadersVisible = false;
            this.dtgvThongKeBanChay.RowHeadersWidth = 62;
            this.dtgvThongKeBanChay.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgvThongKeBanChay.RowTemplate.Height = 28;
            this.dtgvThongKeBanChay.Size = new System.Drawing.Size(900, 220);
            this.dtgvThongKeBanChay.TabIndex = 3;
            this.dtgvThongKeBanChay.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvThongKeBanChay.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgvThongKeBanChay.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgvThongKeBanChay.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgvThongKeBanChay.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgvThongKeBanChay.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgvThongKeBanChay.ThemeStyle.GridColor = System.Drawing.Color.DimGray;
            this.dtgvThongKeBanChay.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtgvThongKeBanChay.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvThongKeBanChay.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dtgvThongKeBanChay.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgvThongKeBanChay.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvThongKeBanChay.ThemeStyle.HeaderStyle.Height = 40;
            this.dtgvThongKeBanChay.ThemeStyle.ReadOnly = false;
            this.dtgvThongKeBanChay.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvThongKeBanChay.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvThongKeBanChay.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dtgvThongKeBanChay.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dtgvThongKeBanChay.ThemeStyle.RowsStyle.Height = 28;
            this.dtgvThongKeBanChay.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvThongKeBanChay.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgvThongKeBanChay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvThongKeBanChay_CellClick);
            // 
            // ChartMatHang
            // 
            this.ChartMatHang.Legend.Name = "Default Legend";
            this.ChartMatHang.Location = new System.Drawing.Point(3, 490);
            this.ChartMatHang.Name = "ChartMatHang";
            series1.Name = "Series 1";
            series1.View = pieSeriesView1;
            this.ChartMatHang.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.ChartMatHang.Size = new System.Drawing.Size(903, 507);
            this.ChartMatHang.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.groupBox2.Controls.Add(this.pictureEdit4);
            this.groupBox2.Controls.Add(this.txtIDMatHang);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(3, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(297, 128);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mã mặt hàng";
            // 
            // pictureEdit4
            // 
            this.pictureEdit4.EditValue = ((object)(resources.GetObject("pictureEdit4.EditValue")));
            this.pictureEdit4.Location = new System.Drawing.Point(18, 41);
            this.pictureEdit4.Name = "pictureEdit4";
            this.pictureEdit4.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit4.Size = new System.Drawing.Size(66, 56);
            this.pictureEdit4.TabIndex = 11;
            // 
            // txtIDMatHang
            // 
            this.txtIDMatHang.AutoSize = true;
            this.txtIDMatHang.Location = new System.Drawing.Point(101, 57);
            this.txtIDMatHang.Name = "txtIDMatHang";
            this.txtIDMatHang.Size = new System.Drawing.Size(0, 27);
            this.txtIDMatHang.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.pictureEdit1);
            this.groupBox1.Controls.Add(this.txtTenMatHang);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(306, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(703, 128);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tên mặt hàng";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(38, 41);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(67, 56);
            this.pictureEdit1.TabIndex = 11;
            // 
            // txtTenMatHang
            // 
            this.txtTenMatHang.AutoSize = true;
            this.txtTenMatHang.Location = new System.Drawing.Point(111, 57);
            this.txtTenMatHang.Name = "txtTenMatHang";
            this.txtTenMatHang.Size = new System.Drawing.Size(0, 27);
            this.txtTenMatHang.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.groupBox3.Controls.Add(this.pictureEdit2);
            this.groupBox3.Controls.Add(this.txtSoLuongBan);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(1015, 96);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(289, 128);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Số lượng bán được";
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.EditValue = ((object)(resources.GetObject("pictureEdit2.EditValue")));
            this.pictureEdit2.Location = new System.Drawing.Point(38, 41);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Size = new System.Drawing.Size(67, 56);
            this.pictureEdit2.TabIndex = 11;
            // 
            // txtSoLuongBan
            // 
            this.txtSoLuongBan.AutoSize = true;
            this.txtSoLuongBan.Location = new System.Drawing.Point(111, 57);
            this.txtSoLuongBan.Name = "txtSoLuongBan";
            this.txtSoLuongBan.Size = new System.Drawing.Size(0, 27);
            this.txtSoLuongBan.TabIndex = 0;
            // 
            // groupControl2
            // 
            this.groupControl2.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl2.CaptionImageOptions.Image")));
            this.groupControl2.Controls.Add(this.dtgvThongKeTonKho);
            this.groupControl2.Location = new System.Drawing.Point(913, 230);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(687, 767);
            this.groupControl2.TabIndex = 11;
            this.groupControl2.Text = "Danh sách thống kê tồn kho";
            // 
            // dtgvThongKeTonKho
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dtgvThongKeTonKho.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvThongKeTonKho.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgvThongKeTonKho.ColumnHeadersHeight = 40;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvThongKeTonKho.DefaultCellStyle = dataGridViewCellStyle6;
            this.dtgvThongKeTonKho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvThongKeTonKho.GridColor = System.Drawing.Color.DimGray;
            this.dtgvThongKeTonKho.Location = new System.Drawing.Point(2, 34);
            this.dtgvThongKeTonKho.Name = "dtgvThongKeTonKho";
            this.dtgvThongKeTonKho.RowHeadersVisible = false;
            this.dtgvThongKeTonKho.RowHeadersWidth = 62;
            this.dtgvThongKeTonKho.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgvThongKeTonKho.RowTemplate.Height = 28;
            this.dtgvThongKeTonKho.Size = new System.Drawing.Size(683, 731);
            this.dtgvThongKeTonKho.TabIndex = 3;
            this.dtgvThongKeTonKho.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvThongKeTonKho.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgvThongKeTonKho.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgvThongKeTonKho.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgvThongKeTonKho.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgvThongKeTonKho.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgvThongKeTonKho.ThemeStyle.GridColor = System.Drawing.Color.DimGray;
            this.dtgvThongKeTonKho.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtgvThongKeTonKho.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvThongKeTonKho.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dtgvThongKeTonKho.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgvThongKeTonKho.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvThongKeTonKho.ThemeStyle.HeaderStyle.Height = 40;
            this.dtgvThongKeTonKho.ThemeStyle.ReadOnly = false;
            this.dtgvThongKeTonKho.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvThongKeTonKho.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvThongKeTonKho.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dtgvThongKeTonKho.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dtgvThongKeTonKho.ThemeStyle.RowsStyle.Height = 28;
            this.dtgvThongKeTonKho.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvThongKeTonKho.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgvThongKeTonKho.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvThongKeTonKho_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBox4.Controls.Add(this.pictureEdit3);
            this.groupBox4.Controls.Add(this.txtSoLuongTon);
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(1310, 96);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(287, 128);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Số lượng tồn kho";
            // 
            // pictureEdit3
            // 
            this.pictureEdit3.EditValue = ((object)(resources.GetObject("pictureEdit3.EditValue")));
            this.pictureEdit3.Location = new System.Drawing.Point(23, 41);
            this.pictureEdit3.Name = "pictureEdit3";
            this.pictureEdit3.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit3.Size = new System.Drawing.Size(64, 56);
            this.pictureEdit3.TabIndex = 11;
            // 
            // txtSoLuongTon
            // 
            this.txtSoLuongTon.AutoSize = true;
            this.txtSoLuongTon.Location = new System.Drawing.Point(93, 57);
            this.txtSoLuongTon.Name = "txtSoLuongTon";
            this.txtSoLuongTon.Size = new System.Drawing.Size(0, 27);
            this.txtSoLuongTon.TabIndex = 0;
            // 
            // FrmQuanLyThongKeMatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ChartMatHang);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ToDate);
            this.Controls.Add(this.FromDate);
            this.Controls.Add(this.cboThongKe);
            this.Name = "FrmQuanLyThongKeMatHang";
            this.Size = new System.Drawing.Size(1600, 1000);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvThongKeBanChay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartMatHang)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit4.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvThongKeTonKho)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox cboThongKe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker ToDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker FromDate;
        private DevExpress.XtraEditors.SimpleButton btnThongKe;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private Guna.UI2.WinForms.Guna2DataGridView dtgvThongKeBanChay;
        private DevExpress.XtraCharts.ChartControl ChartMatHang;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.PictureEdit pictureEdit4;
        private System.Windows.Forms.Label txtIDMatHang;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private System.Windows.Forms.Label txtTenMatHang;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private System.Windows.Forms.Label txtSoLuongBan;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private Guna.UI2.WinForms.Guna2DataGridView dtgvThongKeTonKho;
        private System.Windows.Forms.GroupBox groupBox4;
        private DevExpress.XtraEditors.PictureEdit pictureEdit3;
        private System.Windows.Forms.Label txtSoLuongTon;
    }
}
