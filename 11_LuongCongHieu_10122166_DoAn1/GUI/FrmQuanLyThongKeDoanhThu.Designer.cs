
namespace FrmTrangChu.cs
{
    partial class FrmQuanLyThongKeDoanhThu
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
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuanLyThongKeDoanhThu));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            DevExpress.XtraCharts.XYDiagram xyDiagram2 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.StackedSplineAreaSeriesView stackedSplineAreaSeriesView1 = new DevExpress.XtraCharts.StackedSplineAreaSeriesView();
            this.ChartDoanhThu = new DevExpress.XtraCharts.ChartControl();
            this.FromDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.ToDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dtgvDoanhThu = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnThongKe = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.txtSoLuongBan = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureEdit4 = new DevExpress.XtraEditors.PictureEdit();
            this.txtSoLuongNhap = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureEdit3 = new DevExpress.XtraEditors.PictureEdit();
            this.txtTongNhap = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.txtTongBan = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pictureEdit5 = new DevExpress.XtraEditors.PictureEdit();
            this.txtTongLai = new System.Windows.Forms.Label();
            this.ChartDoanhThu2 = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.ChartDoanhThu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDoanhThu)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit4.Properties)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartDoanhThu2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stackedSplineAreaSeriesView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ChartDoanhThu
            // 
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.ChartDoanhThu.Diagram = xyDiagram1;
            this.ChartDoanhThu.Legend.Name = "Default Legend";
            this.ChartDoanhThu.Location = new System.Drawing.Point(2, 188);
            this.ChartDoanhThu.Name = "ChartDoanhThu";
            series1.Name = "Series 1";
            this.ChartDoanhThu.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.ChartDoanhThu.Size = new System.Drawing.Size(724, 807);
            this.ChartDoanhThu.TabIndex = 1;
            // 
            // FromDate
            // 
            this.FromDate.Checked = true;
            this.FromDate.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.FromDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FromDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.FromDate.Location = new System.Drawing.Point(8, 44);
            this.FromDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.FromDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.FromDate.Name = "FromDate";
            this.FromDate.Size = new System.Drawing.Size(284, 46);
            this.FromDate.TabIndex = 0;
            this.FromDate.Value = new System.DateTime(2024, 5, 29, 11, 18, 9, 123);
            // 
            // ToDate
            // 
            this.ToDate.Checked = true;
            this.ToDate.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.ToDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ToDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.ToDate.Location = new System.Drawing.Point(8, 135);
            this.ToDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.ToDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.ToDate.Name = "ToDate";
            this.ToDate.Size = new System.Drawing.Size(284, 46);
            this.ToDate.TabIndex = 1;
            this.ToDate.Value = new System.DateTime(2024, 5, 29, 11, 18, 10, 924);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "Từ ngày";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 27);
            this.label4.TabIndex = 5;
            this.label4.Text = "Đến ngày";
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImageOptions.Image")));
            this.groupControl1.Controls.Add(this.dtgvDoanhThu);
            this.groupControl1.Location = new System.Drawing.Point(735, 511);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(862, 486);
            this.groupControl1.TabIndex = 7;
            this.groupControl1.Text = "Danh sách thống kê";
            // 
            // dtgvDoanhThu
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtgvDoanhThu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvDoanhThu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvDoanhThu.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvDoanhThu.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvDoanhThu.GridColor = System.Drawing.Color.DimGray;
            this.dtgvDoanhThu.Location = new System.Drawing.Point(2, 34);
            this.dtgvDoanhThu.Name = "dtgvDoanhThu";
            this.dtgvDoanhThu.RowHeadersVisible = false;
            this.dtgvDoanhThu.RowHeadersWidth = 62;
            this.dtgvDoanhThu.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgvDoanhThu.RowTemplate.Height = 28;
            this.dtgvDoanhThu.Size = new System.Drawing.Size(858, 450);
            this.dtgvDoanhThu.TabIndex = 3;
            this.dtgvDoanhThu.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvDoanhThu.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgvDoanhThu.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgvDoanhThu.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgvDoanhThu.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgvDoanhThu.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgvDoanhThu.ThemeStyle.GridColor = System.Drawing.Color.DimGray;
            this.dtgvDoanhThu.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtgvDoanhThu.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvDoanhThu.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dtgvDoanhThu.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgvDoanhThu.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvDoanhThu.ThemeStyle.HeaderStyle.Height = 40;
            this.dtgvDoanhThu.ThemeStyle.ReadOnly = false;
            this.dtgvDoanhThu.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvDoanhThu.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvDoanhThu.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dtgvDoanhThu.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dtgvDoanhThu.ThemeStyle.RowsStyle.Height = 28;
            this.dtgvDoanhThu.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvDoanhThu.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgvDoanhThu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDoanhThu_CellClick);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnThongKe.Appearance.Options.UseFont = true;
            this.btnThongKe.Appearance.Options.UseForeColor = true;
            this.btnThongKe.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThongKe.ImageOptions.Image")));
            this.btnThongKe.Location = new System.Drawing.Point(308, 123);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(243, 58);
            this.btnThongKe.TabIndex = 2;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.pictureEdit1);
            this.groupBox1.Controls.Add(this.txtSoLuongBan);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(308, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 103);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Số lượng đơn bán";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(6, 41);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(57, 56);
            this.pictureEdit1.TabIndex = 11;
            // 
            // txtSoLuongBan
            // 
            this.txtSoLuongBan.AutoSize = true;
            this.txtSoLuongBan.Location = new System.Drawing.Point(79, 57);
            this.txtSoLuongBan.Name = "txtSoLuongBan";
            this.txtSoLuongBan.Size = new System.Drawing.Size(70, 27);
            this.txtSoLuongBan.TabIndex = 0;
            this.txtSoLuongBan.Text = "label8";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.groupBox2.Controls.Add(this.pictureEdit4);
            this.groupBox2.Controls.Add(this.txtSoLuongNhap);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(557, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(243, 103);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Số lượng đơn nhập";
            // 
            // pictureEdit4
            // 
            this.pictureEdit4.EditValue = ((object)(resources.GetObject("pictureEdit4.EditValue")));
            this.pictureEdit4.Location = new System.Drawing.Point(6, 41);
            this.pictureEdit4.Name = "pictureEdit4";
            this.pictureEdit4.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit4.Size = new System.Drawing.Size(55, 56);
            this.pictureEdit4.TabIndex = 11;
            // 
            // txtSoLuongNhap
            // 
            this.txtSoLuongNhap.AutoSize = true;
            this.txtSoLuongNhap.Location = new System.Drawing.Point(79, 57);
            this.txtSoLuongNhap.Name = "txtSoLuongNhap";
            this.txtSoLuongNhap.Size = new System.Drawing.Size(70, 27);
            this.txtSoLuongNhap.TabIndex = 0;
            this.txtSoLuongNhap.Text = "label8";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.groupBox3.Controls.Add(this.pictureEdit3);
            this.groupBox3.Controls.Add(this.txtTongNhap);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(1075, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(250, 103);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tổng tiền đơn nhập";
            // 
            // pictureEdit3
            // 
            this.pictureEdit3.EditValue = ((object)(resources.GetObject("pictureEdit3.EditValue")));
            this.pictureEdit3.Location = new System.Drawing.Point(6, 41);
            this.pictureEdit3.Name = "pictureEdit3";
            this.pictureEdit3.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit3.Size = new System.Drawing.Size(58, 56);
            this.pictureEdit3.TabIndex = 1;
            // 
            // txtTongNhap
            // 
            this.txtTongNhap.AutoSize = true;
            this.txtTongNhap.Location = new System.Drawing.Point(70, 57);
            this.txtTongNhap.Name = "txtTongNhap";
            this.txtTongNhap.Size = new System.Drawing.Size(70, 27);
            this.txtTongNhap.TabIndex = 0;
            this.txtTongNhap.Text = "label8";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBox4.Controls.Add(this.pictureEdit2);
            this.groupBox4.Controls.Add(this.txtTongBan);
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(806, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(263, 103);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tổng tiền đơn bán";
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.EditValue = ((object)(resources.GetObject("pictureEdit2.EditValue")));
            this.pictureEdit2.Location = new System.Drawing.Point(6, 41);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Size = new System.Drawing.Size(57, 56);
            this.pictureEdit2.TabIndex = 1;
            // 
            // txtTongBan
            // 
            this.txtTongBan.AutoSize = true;
            this.txtTongBan.Location = new System.Drawing.Point(69, 57);
            this.txtTongBan.Name = "txtTongBan";
            this.txtTongBan.Size = new System.Drawing.Size(70, 27);
            this.txtTongBan.TabIndex = 0;
            this.txtTongBan.Text = "label8";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.groupBox5.Controls.Add(this.pictureEdit5);
            this.groupBox5.Controls.Add(this.txtTongLai);
            this.groupBox5.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(1331, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(266, 103);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Tổng tiền lãi";
            // 
            // pictureEdit5
            // 
            this.pictureEdit5.EditValue = ((object)(resources.GetObject("pictureEdit5.EditValue")));
            this.pictureEdit5.Location = new System.Drawing.Point(6, 41);
            this.pictureEdit5.Name = "pictureEdit5";
            this.pictureEdit5.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit5.Size = new System.Drawing.Size(55, 56);
            this.pictureEdit5.TabIndex = 1;
            // 
            // txtTongLai
            // 
            this.txtTongLai.AutoSize = true;
            this.txtTongLai.Location = new System.Drawing.Point(67, 57);
            this.txtTongLai.Name = "txtTongLai";
            this.txtTongLai.Size = new System.Drawing.Size(70, 27);
            this.txtTongLai.TabIndex = 0;
            this.txtTongLai.Text = "label8";
            // 
            // ChartDoanhThu2
            // 
            xyDiagram2.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram2.AxisX.WholeRange.SideMarginsValue = 0D;
            xyDiagram2.AxisY.VisibleInPanesSerializable = "-1";
            this.ChartDoanhThu2.Diagram = xyDiagram2;
            this.ChartDoanhThu2.Legend.Name = "Default Legend";
            this.ChartDoanhThu2.Location = new System.Drawing.Point(733, 188);
            this.ChartDoanhThu2.Name = "ChartDoanhThu2";
            series2.Name = "Series 1";
            series2.View = stackedSplineAreaSeriesView1;
            this.ChartDoanhThu2.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series2};
            this.ChartDoanhThu2.Size = new System.Drawing.Size(862, 316);
            this.ChartDoanhThu2.TabIndex = 10;
            // 
            // FrmQuanLyThongKeDoanhThu
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ChartDoanhThu2);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ToDate);
            this.Controls.Add(this.FromDate);
            this.Controls.Add(this.ChartDoanhThu);
            this.Name = "FrmQuanLyThongKeDoanhThu";
            this.Size = new System.Drawing.Size(1600, 1000);
            this.Load += new System.EventHandler(this.FrmQuanLyThongKeDoanhThu_Load);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartDoanhThu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDoanhThu)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit4.Properties)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stackedSplineAreaSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartDoanhThu2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl ChartDoanhThu;
        private Guna.UI2.WinForms.Guna2DateTimePicker FromDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker ToDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private Guna.UI2.WinForms.Guna2DataGridView dtgvDoanhThu;
        private DevExpress.XtraEditors.SimpleButton btnThongKe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label txtSoLuongBan;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label txtSoLuongNhap;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label txtTongNhap;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label txtTongBan;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label txtTongLai;
        private DevExpress.XtraCharts.ChartControl ChartDoanhThu2;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit4;
        private DevExpress.XtraEditors.PictureEdit pictureEdit3;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private DevExpress.XtraEditors.PictureEdit pictureEdit5;
    }
}
