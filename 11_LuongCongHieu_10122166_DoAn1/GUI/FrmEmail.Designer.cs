
namespace FrmTrangChu.cs
{
    partial class FrmEmail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmail));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnSend = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnLamMoi = new DevExpress.XtraEditors.SimpleButton();
            this.txtContent = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtpass = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSender = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnLink = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grbHinhAnh = new Guna.UI2.WinForms.Guna2GroupBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtReceiver = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.mapControl1 = new DevExpress.XtraMap.MapControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            this.guna2GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grbHinhAnh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.guna2GroupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.guna2GroupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.grbHinhAnh);
            this.splitContainer1.Panel1.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1600, 1000);
            this.splitContainer1.SplitterDistance = 534;
            this.splitContainer1.TabIndex = 0;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderRadius = 5;
            this.guna2GroupBox1.Controls.Add(this.btnSend);
            this.guna2GroupBox1.Controls.Add(this.simpleButton1);
            this.guna2GroupBox1.Controls.Add(this.btnLamMoi);
            this.guna2GroupBox1.Controls.Add(this.txtContent);
            this.guna2GroupBox1.Controls.Add(this.txtpass);
            this.guna2GroupBox1.Controls.Add(this.txtSender);
            this.guna2GroupBox1.Controls.Add(this.btnLink);
            this.guna2GroupBox1.Controls.Add(this.label3);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))));
            this.guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Location = new System.Drawing.Point(0, 423);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(534, 577);
            this.guna2GroupBox1.TabIndex = 31;
            this.guna2GroupBox1.Text = "LIÊN HỆ VỚI CHÚNG TÔI";
            this.guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSend
            // 
            this.btnSend.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSend.ImageOptions.SvgImage")));
            this.btnSend.Location = new System.Drawing.Point(314, 376);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(171, 47);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Gửi thông tin";
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(264, 452);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(221, 55);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Chuyển sang ggMap";
            this.simpleButton1.Click += new System.EventHandler(this.ggMap_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.ImageOptions.Image")));
            this.btnLamMoi.Location = new System.Drawing.Point(51, 376);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(125, 47);
            this.btnLamMoi.TabIndex = 4;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // txtContent
            // 
            this.txtContent.AutoSize = true;
            this.txtContent.BorderColor = System.Drawing.Color.Transparent;
            this.txtContent.BorderRadius = 10;
            this.txtContent.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContent.DefaultText = "";
            this.txtContent.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtContent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtContent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContent.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContent.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtContent.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.txtContent.ForeColor = System.Drawing.Color.Black;
            this.txtContent.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtContent.Location = new System.Drawing.Point(51, 163);
            this.txtContent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.PasswordChar = '\0';
            this.txtContent.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtContent.PlaceholderText = "Nội dung";
            this.txtContent.SelectedText = "";
            this.txtContent.Size = new System.Drawing.Size(434, 205);
            this.txtContent.TabIndex = 3;
            // 
            // txtpass
            // 
            this.txtpass.AutoSize = true;
            this.txtpass.BorderColor = System.Drawing.Color.Transparent;
            this.txtpass.BorderRadius = 10;
            this.txtpass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpass.DefaultText = "";
            this.txtpass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtpass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtpass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtpass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtpass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtpass.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.txtpass.ForeColor = System.Drawing.Color.Black;
            this.txtpass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtpass.Location = new System.Drawing.Point(51, 98);
            this.txtpass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '\0';
            this.txtpass.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtpass.PlaceholderText = "Mật khẩu Email ứng dụng của người gửi";
            this.txtpass.SelectedText = "";
            this.txtpass.Size = new System.Drawing.Size(434, 32);
            this.txtpass.TabIndex = 1;
            // 
            // txtSender
            // 
            this.txtSender.AutoSize = true;
            this.txtSender.BorderColor = System.Drawing.Color.Transparent;
            this.txtSender.BorderRadius = 10;
            this.txtSender.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSender.DefaultText = "";
            this.txtSender.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSender.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSender.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSender.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSender.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.txtSender.ForeColor = System.Drawing.Color.Black;
            this.txtSender.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSender.Location = new System.Drawing.Point(51, 56);
            this.txtSender.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSender.Name = "txtSender";
            this.txtSender.PasswordChar = '\0';
            this.txtSender.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtSender.PlaceholderText = "Email người gửi";
            this.txtSender.SelectedText = "";
            this.txtSender.Size = new System.Drawing.Size(434, 32);
            this.txtSender.TabIndex = 0;
            // 
            // btnLink
            // 
            this.btnLink.AutoSize = true;
            this.btnLink.Location = new System.Drawing.Point(47, 135);
            this.btnLink.Name = "btnLink";
            this.btnLink.Size = new System.Drawing.Size(301, 23);
            this.btnLink.TabIndex = 2;
            this.btnLink.TabStop = true;
            this.btnLink.Text = "Cách lấy mật khẩu ứng dụng Email";
            this.btnLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnLink_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(57, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 23);
            this.label3.TabIndex = 16;
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.BorderRadius = 5;
            this.guna2GroupBox2.Controls.Add(this.labelControl4);
            this.guna2GroupBox2.Controls.Add(this.labelControl3);
            this.guna2GroupBox2.Controls.Add(this.pictureBox1);
            this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))));
            this.guna2GroupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GroupBox2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox2.Location = new System.Drawing.Point(0, 0);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.Size = new System.Drawing.Size(534, 223);
            this.guna2GroupBox2.TabIndex = 31;
            this.guna2GroupBox2.Text = "CHÚNG TÔI SẼ GIẢI QUYẾT MỌI THẮC MẮC ";
            this.guna2GroupBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(123, 165);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(291, 23);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "CỬA HÀNG MÁY TÍNH HIEUPC";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.BackColor = System.Drawing.Color.White;
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl3.Appearance.Options.UseBackColor = true;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(182, 137);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(156, 22);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Hưng Yên Province";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(534, 91);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // grbHinhAnh
            // 
            this.grbHinhAnh.BorderRadius = 5;
            this.grbHinhAnh.Controls.Add(this.labelControl1);
            this.grbHinhAnh.Controls.Add(this.txtReceiver);
            this.grbHinhAnh.Controls.Add(this.labelControl2);
            this.grbHinhAnh.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))));
            this.grbHinhAnh.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbHinhAnh.ForeColor = System.Drawing.Color.White;
            this.grbHinhAnh.Location = new System.Drawing.Point(0, 229);
            this.grbHinhAnh.Name = "grbHinhAnh";
            this.grbHinhAnh.Size = new System.Drawing.Size(535, 188);
            this.grbHinhAnh.TabIndex = 31;
            this.grbHinhAnh.Text = "THÔNG TIN VỀ CHÚNG TÔI";
            this.grbHinhAnh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(14, 55);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(491, 22);
            this.labelControl1.TabIndex = 29;
            this.labelControl1.Text = "Địa chỉ : Số 15, Nguyễn Văn Linh,Thành phố Hưng Yên";
            // 
            // txtReceiver
            // 
            this.txtReceiver.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceiver.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtReceiver.Appearance.Options.UseFont = true;
            this.txtReceiver.Appearance.Options.UseForeColor = true;
            this.txtReceiver.Location = new System.Drawing.Point(14, 149);
            this.txtReceiver.Name = "txtReceiver";
            this.txtReceiver.Size = new System.Drawing.Size(201, 22);
            this.txtReceiver.TabIndex = 29;
            this.txtReceiver.Text = "hieuluong@gmail.com";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(14, 101);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(175, 22);
            this.labelControl2.TabIndex = 29;
            this.labelControl2.Text = "Hotline : 1900 6750";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.pictureBox2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1062, 1000);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Địa chỉ cụ thể";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(2, 34);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1058, 964);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // mapControl1
            // 
            this.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapControl1.Location = new System.Drawing.Point(2, 34);
            this.mapControl1.Name = "mapControl1";
            this.mapControl1.Size = new System.Drawing.Size(1058, 864);
            this.mapControl1.TabIndex = 0;
            // 
            // FrmEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmEmail";
            this.Size = new System.Drawing.Size(1600, 1000);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grbHinhAnh.ResumeLayout(false);
            this.grbHinhAnh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraEditors.SimpleButton btnLamMoi;
        private System.Windows.Forms.LinkLabel btnLink;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private Guna.UI2.WinForms.Guna2GroupBox grbHinhAnh;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private Guna.UI2.WinForms.Guna2TextBox txtSender;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.LabelControl txtReceiver;
        private Guna.UI2.WinForms.Guna2TextBox txtpass;
        private Guna.UI2.WinForms.Guna2TextBox txtContent;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.SimpleButton btnSend;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private DevExpress.XtraMap.MapControl mapControl1;
    }
}
