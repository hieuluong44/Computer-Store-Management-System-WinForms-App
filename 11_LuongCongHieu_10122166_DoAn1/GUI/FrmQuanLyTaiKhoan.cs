using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
using Guna.UI2.WinForms;

namespace FrmTrangChu.cs
{
    public partial class FrmQuanLyTaiKhoan : DevExpress.XtraEditors.XtraUserControl
    {
        private BUS_TaiKhoan BUS_TaiKhoan = new BUS_TaiKhoan();
        private BUS_ChucVu BUS_ChucVu = new BUS_ChucVu();
        private BUS_NhanVien BUS_NhanVien = new BUS_NhanVien();
        LienKetCombobox LienKetCombobox = new LienKetCombobox();
        public FrmQuanLyTaiKhoan()
        {
            InitializeComponent();
        }
        private void FrmQuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            dtgvDanhSachTK.DataSource = BUS_TaiKhoan.HienTK();
            LienKetCombobox.LienKet1DuLieu(BUS_NhanVien.HienNV(), "TenNhanVien", txtTenNV);
            // liên kết chức vụ và nhân viên
            LienKetCombobox.LienKet2DuLieu(BUS_ChucVu.HienCV(), "ChucVu", "IDChucVu", txtTenCV);
            txtTenCV.SelectedIndexChanged += new EventHandler(txtTenCV_SelectedIndexChanged);
            LienKetCombobox.LienKet2DuLieu(BUS_ChucVu.HienCV(), "IDChucVu", "ChucVu", txtIDChucVu);
            txtIDChucVu.SelectedIndexChanged += new EventHandler(txtTenCV_SelectedIndexChanged);


            // liên kết chức vụ tìm kiếm
            LienKetCombobox.LienKet2DuLieu(BUS_ChucVu.HienCV(), "ChucVu", "IDChucVu", txtTenCV1);
            txtTenCV1.SelectedIndexChanged += new EventHandler(txtTenCV1_SelectedIndexChanged);
            LienKetCombobox.LienKet2DuLieu(BUS_ChucVu.HienCV(), "IDChucVu", "ChucVu", txtMaCV1);
            txtMaCV1.SelectedIndexChanged += new EventHandler(txtTenCV1_SelectedIndexChanged);

            //Liên kết nhân viên tìm kiếm
            LienKetCombobox.LienKet2DuLieu(BUS_NhanVien.HienNV(), "TenNhanVien", "IDNhanvien", txtTenNV1);
            txtMaNV1.SelectedIndexChanged += new EventHandler(txtTenNV1_SelectedIndexChanged);
            LienKetCombobox.LienKet2DuLieu(BUS_NhanVien.HienNV(), "IDNhanvien", "TenNhanVien", txtMaNV1);
            txtTenNV1.SelectedIndexChanged += new EventHandler(txtTenNV1_SelectedIndexChanged);
        }
        private bool ValidateInput()
        {
            return true;
        }
        private void dtgvDanhSachTK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgvDanhSachTK.Rows[e.RowIndex];
                txtTenDangNhap.Text = row.Cells["TenDangNhap"].Value.ToString().Trim();
                txtIDChucVu.Text = row.Cells["IDChucVu"].Value.ToString().Trim();
                txtMatKhau.Text = row.Cells["MatKhau"].Value.ToString().Trim();
            }
            txtTenDangNhap.Focus();
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMatKhau.Text = "";
            dtgvDanhSachTK.DataSource = BUS_TaiKhoan.HienTK();
            LienKetCombobox.LienKet1DuLieu(BUS_NhanVien.HienNV(), "TenNhanVien", txtTenNV);
            LienKetCombobox.LienKet2DuLieu(BUS_ChucVu.HienCV(), "ChucVu", "IDChucVu", txtTenCV);
            LienKetCombobox.LienKet2DuLieu(BUS_ChucVu.HienCV(), "IDChucVu", "ChucVu", txtIDChucVu);
            LienKetCombobox.LienKet2DuLieu(BUS_ChucVu.HienCV(), "ChucVu", "IDChucVu", txtTenCV1);
            LienKetCombobox.LienKet2DuLieu(BUS_ChucVu.HienCV(), "IDChucVu", "ChucVu", txtMaCV1);
            LienKetCombobox.LienKet2DuLieu(BUS_NhanVien.HienNV(), "TenNhanVien", "IDNhanvien", txtTenNV1);
            LienKetCombobox.LienKet2DuLieu(BUS_NhanVien.HienNV(), "IDNhanvien", "TenNhanVien", txtMaNV1);
        }
        // các chức năng
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                // Tạo DTO
                DTO_TaiKhoan tk = new DTO_TaiKhoan(
                    txtTenDangNhap.Text,
                    txtIDChucVu.Text,
                    txtMatKhau.Text
                ); 

                // Thêm
                if (BUS_TaiKhoan.ThemTK(tk))
                {
                    MessageBox.Show("Thêm tài khoản thành công");
                    dtgvDanhSachTK.DataSource = BUS_TaiKhoan.HienTK(); // refresh datagridview
                }
                else
                {
                    MessageBox.Show("Thêm tài khoản không thành công");
                }
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ thông tin");
            }
            btnLamMoi_Click(sender, e);
            txtTenDangNhap.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn sửa không?", "Sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (dtgvDanhSachTK.SelectedRows.Count > 0 && ValidateInput())
                {
                    // Lấy row hiện tại
                    DataGridViewRow row = dtgvDanhSachTK.SelectedRows[0];
                    string ID = row.Cells["@TenDangNhap"].Value.ToString();

                    DTO_TaiKhoan tk = new DTO_TaiKhoan(
                     txtTenDangNhap.Text,
                     txtIDChucVu.Text,
                     txtMatKhau.Text
                    );

                    // Sửa
                    if (BUS_TaiKhoan.SuaTK(tk))
                    {
                        MessageBox.Show("Cập nhật thông tin tài khoản thành công");
                        dtgvDanhSachTK.DataSource = BUS_TaiKhoan.HienTK(); // refresh datagridview
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thông tin tài khoản không thành công");
                    }
                }
            }
            btnLamMoi_Click(sender, e);
            txtTenDangNhap.Focus();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string TenDangNhap = txtTenDangNhap.Text; // Lấy ID từ textbox hoặc từ DataGridView
            if (MessageBox.Show("Bạn có thật sự muốn xóa không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (BUS_TaiKhoan.XoaTk(TenDangNhap))
                {
                    MessageBox.Show("Xóa tài khoản thành công!");
                }
                else
                {
                    MessageBox.Show("Xóa tài khoản thất bại.");
                }
            }
            btnLamMoi_Click(sender, e);
            txtTenDangNhap.Focus();
        }

        private void txtTenCV_SelectedIndexChanged(object sender, EventArgs e)
        {
            Guna2ComboBox comboBox = sender as Guna2ComboBox;
            if (comboBox != null && comboBox.SelectedIndex != -1)
            {
                string maChucVu = ((DataRowView)comboBox.SelectedItem)[comboBox.ValueMember].ToString();
                DataTable dtNhanVien = BUS_NhanVien.LayNhanVien(maChucVu);
                if (comboBox == txtTenCV)
                {
                    txtIDChucVu.Text = maChucVu;
                }
                else if (comboBox == txtIDChucVu)
                {
                    txtTenCV.Text = maChucVu;
                }
                // Hiển thị thông tin nhân viên đầu tiên (nếu có)
                if (dtNhanVien.Rows.Count > 0)
                {
                    DataRow dr = dtNhanVien.Rows[0];
                    txtTenNV.Text = dr["TenNhanVien"].ToString();
                }
                // Gán danh sách nhân viên vào combo box
                txtTenDangNhap.DataSource = dtNhanVien;
                txtTenDangNhap.DisplayMember = "IDNhanvien";
                txtTenDangNhap.ValueMember = "IDNhanvien";
            }
        }
        private void btnTimbangnhanvien_Click(object sender, EventArgs e)
        {
            string tendangnhap = txtMaNV1.Text;
            DataTable danhsachtk = BUS_TaiKhoan.TimTKbangNV(tendangnhap);
            dtgvDanhSachTK.DataSource = danhsachtk;
        }
        private void btnTimbangChucVu_Click(object sender, EventArgs e)
        {
            string maCV = txtMaCV1.Text;
            DataTable danhsachtk = BUS_TaiKhoan.TimTKbangCV(maCV);
            dtgvDanhSachTK.DataSource = danhsachtk;
        }

        private void txtTenCV1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Guna2ComboBox comboBox = sender as Guna2ComboBox;
            if (comboBox != null && comboBox.SelectedIndex != -1)
            {
                string maChucVu = ((DataRowView)comboBox.SelectedItem)[comboBox.ValueMember].ToString();
                if (comboBox == txtTenCV1)
                {
                    txtMaCV1.Text = maChucVu;
                }
                else if (comboBox == txtMaCV1)
                {
                    txtTenCV1.Text = maChucVu;
                }
            }
        }
        private void txtTenNV1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Guna2ComboBox comboBox = sender as Guna2ComboBox;
            if (comboBox != null && comboBox.SelectedIndex != -1)
            {
                string NhanVien = ((DataRowView)comboBox.SelectedItem)[comboBox.ValueMember].ToString();
                if (comboBox == txtTenNV1)
                {
                    txtMaNV1.Text = NhanVien;
                }
                else if (comboBox == txtMaNV1)
                {
                    txtTenNV1.Text = NhanVien;
                }
            }
        }
    }
}
