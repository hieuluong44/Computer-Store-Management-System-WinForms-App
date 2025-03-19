
namespace FrmTrangChu.cs
{
    partial class FrmDanhMucMatHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDanhMucMatHang));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTenDanhMuc = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtIDMuc = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTim = new Guna.UI2.WinForms.Guna2TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnLamMoi = new DevExpress.XtraEditors.SimpleButton();
            this.btnTim = new DevExpress.XtraEditors.SimpleButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvDanhMuc = new Guna.UI2.WinForms.Guna2DataGridView();
            this.IDMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDanhMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhMuc)).BeginInit();
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
            this.splitContainer1.Panel2.Controls.Add(this.dtgvDanhMuc);
            this.splitContainer1.Size = new System.Drawing.Size(948, 568);
            this.splitContainer1.SplitterDistance = 169;
            this.splitContainer1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.groupBox1.Controls.Add(this.txtTenDanhMuc);
            this.groupBox1.Controls.Add(this.txtIDMuc);
            this.groupBox1.Controls.Add(this.txtTim);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnTim);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(948, 169);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtTenDanhMuc
            // 
            this.txtTenDanhMuc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenDanhMuc.DefaultText = "";
            this.txtTenDanhMuc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenDanhMuc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenDanhMuc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenDanhMuc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenDanhMuc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenDanhMuc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenDanhMuc.ForeColor = System.Drawing.Color.Black;
            this.txtTenDanhMuc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenDanhMuc.Location = new System.Drawing.Point(617, 55);
            this.txtTenDanhMuc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenDanhMuc.Name = "txtTenDanhMuc";
            this.txtTenDanhMuc.PasswordChar = '\0';
            this.txtTenDanhMuc.PlaceholderText = "";
            this.txtTenDanhMuc.SelectedText = "";
            this.txtTenDanhMuc.Size = new System.Drawing.Size(286, 37);
            this.txtTenDanhMuc.TabIndex = 3;
            // 
            // txtIDMuc
            // 
            this.txtIDMuc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIDMuc.DefaultText = "DM01";
            this.txtIDMuc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIDMuc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIDMuc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDMuc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDMuc.Enabled = false;
            this.txtIDMuc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDMuc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIDMuc.ForeColor = System.Drawing.Color.Black;
            this.txtIDMuc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDMuc.Location = new System.Drawing.Point(160, 59);
            this.txtIDMuc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIDMuc.Name = "txtIDMuc";
            this.txtIDMuc.PasswordChar = '\0';
            this.txtIDMuc.PlaceholderText = "";
            this.txtIDMuc.SelectedText = "";
            this.txtIDMuc.Size = new System.Drawing.Size(286, 37);
            this.txtIDMuc.TabIndex = 2;
            // 
            // txtTim
            // 
            this.txtTim.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTim.DefaultText = "";
            this.txtTim.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTim.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTim.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTim.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTim.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTim.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTim.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTim.Location = new System.Drawing.Point(66, 17);
            this.txtTim.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTim.Name = "txtTim";
            this.txtTim.PasswordChar = '\0';
            this.txtTim.PlaceholderText = "Nhập tên danh mục";
            this.txtTim.SelectedText = "";
            this.txtTim.Size = new System.Drawing.Size(286, 35);
            this.txtTim.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnLuu);
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.btnLamMoi);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(3, 100);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label5.Location = new System.Drawing.Point(462, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 30);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tên danh mục";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label1.Location = new System.Drawing.Point(8, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 30);
            this.label1.TabIndex = 13;
            this.label1.Text = "Mã danh mục";
            // 
            // dtgvDanhMuc
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtgvDanhMuc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvDanhMuc.BackgroundColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvDanhMuc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvDanhMuc.ColumnHeadersHeight = 40;
            this.dtgvDanhMuc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDMuc,
            this.TenDanhMuc});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvDanhMuc.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvDanhMuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvDanhMuc.GridColor = System.Drawing.Color.Black;
            this.dtgvDanhMuc.Location = new System.Drawing.Point(0, 0);
            this.dtgvDanhMuc.Name = "dtgvDanhMuc";
            this.dtgvDanhMuc.RowHeadersVisible = false;
            this.dtgvDanhMuc.RowHeadersWidth = 62;
            this.dtgvDanhMuc.RowTemplate.Height = 28;
            this.dtgvDanhMuc.Size = new System.Drawing.Size(948, 395);
            this.dtgvDanhMuc.TabIndex = 0;
            this.dtgvDanhMuc.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvDanhMuc.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgvDanhMuc.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgvDanhMuc.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgvDanhMuc.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgvDanhMuc.ThemeStyle.BackColor = System.Drawing.Color.DimGray;
            this.dtgvDanhMuc.ThemeStyle.GridColor = System.Drawing.Color.Black;
            this.dtgvDanhMuc.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtgvDanhMuc.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvDanhMuc.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dtgvDanhMuc.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgvDanhMuc.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvDanhMuc.ThemeStyle.HeaderStyle.Height = 40;
            this.dtgvDanhMuc.ThemeStyle.ReadOnly = false;
            this.dtgvDanhMuc.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvDanhMuc.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvDanhMuc.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dtgvDanhMuc.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dtgvDanhMuc.ThemeStyle.RowsStyle.Height = 28;
            this.dtgvDanhMuc.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvDanhMuc.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgvDanhMuc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDanhMuc_CellClick);
            // 
            // IDMuc
            // 
            this.IDMuc.DataPropertyName = "IDMuc";
            this.IDMuc.DividerWidth = 1;
            this.IDMuc.HeaderText = "Mã danh mục";
            this.IDMuc.MinimumWidth = 8;
            this.IDMuc.Name = "IDMuc";
            // 
            // TenDanhMuc
            // 
            this.TenDanhMuc.DataPropertyName = "TenDanhMuc";
            this.TenDanhMuc.DividerWidth = 1;
            this.TenDanhMuc.HeaderText = "Tên danh mục";
            this.TenDanhMuc.MinimumWidth = 8;
            this.TenDanhMuc.Name = "TenDanhMuc";
            // 
            // FrmDanhMucMatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(948, 568);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDanhMucMatHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDanhMucMatHang";
            this.Load += new System.EventHandler(this.FrmDanhMucMatHang_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhMuc)).EndInit();
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
        private DevExpress.XtraEditors.SimpleButton btnTim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView dtgvDanhMuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDMuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDanhMuc;
        private Guna.UI2.WinForms.Guna2TextBox txtTim;
        private Guna.UI2.WinForms.Guna2TextBox txtTenDanhMuc;
        private Guna.UI2.WinForms.Guna2TextBox txtIDMuc;
    }
}