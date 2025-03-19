using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS;
using System.Data.SqlClient;
using Guna.UI2.WinForms;

namespace FrmTrangChu.cs
{
    public partial class FrmQuenMatKhau : DevExpress.XtraEditors.XtraForm
    {
        BUS_TaiKhoan taiKhoan = new BUS_TaiKhoan();
        LienKetCombobox LienKetCombobox = new LienKetCombobox();
        BUS_ChucVu chucVu = new BUS_ChucVu();
        BUS_NhanVien nhanVien = new BUS_NhanVien();
        public FrmQuenMatKhau()
        {
            InitializeComponent();
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            if (txtMKmoi.Text.Trim() == txtLapLai.Text.Trim())
            {
                if (taiKhoan.DoiMatKhau(txtTenDangNhap.Text.Trim(), txtMKmoi.Text.Trim()))
                {
                    MessageBox.Show("Đổi mật khẩu thành công, vui lòng đăng nhập lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    FrmDangNhap dangNhap = new FrmDangNhap();
                    dangNhap.ShowDialog();
                }
                else MessageBox.Show("Mật khẩu cũ không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Mật khẩu mới không trùng nhau!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void txtTenCV_SelectedIndexChanged(object sender, EventArgs e)
        {
            Guna2ComboBox ComboBox = sender as Guna2ComboBox;
            if (ComboBox != null && ComboBox.SelectedIndex != -1)
            {
                string maChucVu = ((DataRowView)ComboBox.SelectedItem)[ComboBox.ValueMember].ToString();
                if (ComboBox == txtTenCV)
                {
                    txtMaCV.Text = maChucVu;
                }
            }
        }
        private void FrmQuenMatKhau_Load(object sender, EventArgs e)
        {
            LienKetCombobox.LienKet2DuLieu(chucVu.HienCV(), "ChucVu", "IDChucVu", txtTenCV);
            txtTenCV.SelectedIndexChanged += new EventHandler(txtTenCV_SelectedIndexChanged);
            grbDoiMK.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmDangNhap dangNhap = new FrmDangNhap();
            dangNhap.ShowDialog();
        }

        private void btnXacThuc_Click(object sender, EventArgs e)
        {
            string IDNhanvien = txtIDNhanvien.Text.Trim();
            string SoDienThoai = txtSDT.Text.Trim();
            string IDChucVu = txtMaCV.Text.Trim();
            string CCCD = txtCCCD.Text.Trim();

            DataTable result = nhanVien.XacThuc(IDNhanvien,SoDienThoai,IDChucVu,CCCD);

            if (result.Rows.Count > 0)
            {
                // Lấy tên nhân viên từ kết quả trả về
                string tenNhanVien = result.Rows[0]["TenNhanVien"].ToString();

                MessageBox.Show($"Thông tin hợp lệ của nhân viên: {tenNhanVien}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                grbDoiMK.Enabled = true;
                txtTenDangNhap.Text = txtIDNhanvien.Text;
            }
            else
            {
                MessageBox.Show("Thông tin không chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtSDT.Text = "";
            txtCCCD.Text = "";
        }
    }
}