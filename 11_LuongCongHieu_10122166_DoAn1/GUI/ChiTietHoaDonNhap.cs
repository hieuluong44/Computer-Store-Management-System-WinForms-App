using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using BUS;
using DTO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Guna.UI2.WinForms;
using DevExpress.XtraGrid.Views.Grid;

namespace FrmTrangChu.cs
{
    public partial class FrmChiTietHoaDonNhap : DevExpress.XtraEditors.XtraForm
    {
        private BUS_HoaDonNhap BUS_HoaDonNhap = new BUS_HoaDonNhap();
        private BUS_ChiTietHoaDonNhap BUS_ChiTietHoaDonNhap = new BUS_ChiTietHoaDonNhap();
        private BUS_MatHang BUS_MatHang = new BUS_MatHang();
        private LienKetCombobox lienKetCombobox = new LienKetCombobox();
        public FrmChiTietHoaDonNhap()
        {
            InitializeComponent();
        }
        private bool ValidateInput()
        {
            return true;
        }
        private string TaoIDMoi()// Tạo ID mới tăng dần
        {
            // Lấy danh sách ID chức vụ hiện có từ cơ sở dữ liệu
            DataTable dtHDB = BUS_ChiTietHoaDonNhap.HienCTN();
            int maxNumber = 0;
            foreach (DataRow row in dtHDB.Rows)
            {
                string id = row["IDChitietnhap"].ToString();
                int number;
                if (int.TryParse(id.Replace("CTN", ""), out number))
                {
                    if (number > maxNumber)
                        maxNumber = number;
                }
            }
            // Tạo ID mới với số tiếp theo
            maxNumber++; // Tăng lên 1 đơn vị
            return "CTN" + maxNumber.ToString("D2"); // Định dạng số với 2 chữ số
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtDonGiaNhap.Text = "";
            txtSoLuong.ToString();
            txtThanhTien.Text = "";
            dtgvChiTietNhap.DataSource = BUS_ChiTietHoaDonNhap.HienCTN();
            lienKetCombobox.LienKet1DuLieu(BUS_HoaDonNhap.HienHDN(), "IDNhap", txtIDNhap);
            lienKetCombobox.LienKet1DuLieu(BUS_HoaDonNhap.HienHDN(), "IDNhap", txtTim);
            lienKetCombobox.LienKet2DuLieu(BUS_MatHang.Hienmn(), "Tenmathang", "IDMatHang", txtTenMatHang);
            lienKetCombobox.LienKet2DuLieu(BUS_MatHang.Hienmn(), "IDMatHang", "Tenmathang", txtIDMatHang);
        }
        private void dtgvChiTietNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgvChiTietNhap.Rows[e.RowIndex];
                txtIDChitietNhap.Text = row.Cells["IDChitietnhap"].Value.ToString();
                txtIDNhap.Text = row.Cells["IDNhap"].Value.ToString();
                txtIDMatHang.Text = row.Cells["IDMatHang"].Value.ToString();
                txtSoLuong.Text = row.Cells["SoLuong"].Value.ToString();
                txtDonGiaNhap.Text = string.Format("{0:N0}", row.Cells["DonGiaNhap"].Value);
                txtThanhTien.Text = string.Format("{0:N0}", row.Cells["ThanhTien"].Value);
            }
        }
        private void FrmChiTietHoaDonNhap_Load(object sender, EventArgs e)
        {
            dtgvChiTietNhap.DataSource = BUS_ChiTietHoaDonNhap.HienCTN();
            lienKetCombobox.LienKet1DuLieu(BUS_HoaDonNhap.HienHDN(), "IDNhap", txtIDNhap);
            lienKetCombobox.LienKet1DuLieu(BUS_HoaDonNhap.HienHDN(), "IDNhap", txtTim);

            lienKetCombobox.LienKet2DuLieu(BUS_MatHang.Hienmn(), "Tenmathang", "IDMatHang", txtTenMatHang);
            txtTenMatHang.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged);

            lienKetCombobox.LienKet2DuLieu(BUS_MatHang.Hienmn(), "IDMatHang", "Tenmathang", txtIDMatHang);
            txtIDMatHang.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged);
        }
        // Các chức năng
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string IDChiTietNhap = TaoIDMoi();
            if (ValidateInput())
            {
                // Tạo DTO
                DTO_ChiTietHoaDonNhap cthdn = new DTO_ChiTietHoaDonNhap(
                    IDChiTietNhap,
                    txtIDNhap.Text,
                    txtIDMatHang.Text,
                    int.Parse(txtSoLuong.Text),
                    float.Parse(txtDonGiaNhap.Text),
                    float.Parse(txtThanhTien.Text)
                );
                // Thêm
                if (BUS_ChiTietHoaDonNhap.ThemCTN(cthdn))
                {
                    // Xác nhận nhập hàng => số lượng tăng
                    BUS_MatHang.TangSoLuongMatHang(txtIDMatHang.Text, int.Parse(txtSoLuong.Text));
                    MessageBox.Show("Thêm chi tiết hoá đơn nhập mới thành công");
                    dtgvChiTietNhap.DataSource = BUS_ChiTietHoaDonNhap.HienCTN(); // refresh datagridview
                    txtIDChitietNhap.Text = TaoIDMoi();
                }
                else
                {
                    MessageBox.Show("Thêm chi tiết hoá đơn bán nhập không thành công");
                }
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ thông tin");
            }
            btnLamMoi_Click(sender, e);
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn sửa không?", "Sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (dtgvChiTietNhap.SelectedRows.Count > 0 && ValidateInput())
                {

                    // Lấy row hiện tại
                    DataGridViewRow row = dtgvChiTietNhap.SelectedRows[0];
                    string ID = row.Cells["IDChitietnhap"].Value.ToString();

                    // Tạo DTO
                    DTO_ChiTietHoaDonNhap cthdn = new DTO_ChiTietHoaDonNhap(
                      txtIDChitietNhap.Text,
                      txtIDNhap.Text,
                      txtIDMatHang.Text,
                      int.Parse(txtSoLuong.Text),
                      float.Parse(txtDonGiaNhap.Text),
                      float.Parse(txtThanhTien.Text)
                  );

                    // Sửa
                    if (BUS_ChiTietHoaDonNhap.SuaCTN(cthdn))
                    {
                        MessageBox.Show("Cập nhật thông tin chi tiết hoá đơn nhập thành công");
                        dtgvChiTietNhap.DataSource = BUS_ChiTietHoaDonNhap.HienCTN(); // refresh datagridview
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thông tin chi tiết hoá đơn nhập không thành công");
                        txtIDChitietNhap.Focus();
                    }
                }
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string IDChitietNhap = txtIDChitietNhap.Text; // Lấy ID từ textbox hoặc từ DataGridView
            if (MessageBox.Show("Bạn có thật sự muốn xóa không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                // Gọi phương thức Xóa từ BUS
                if (BUS_ChiTietHoaDonNhap.XoaCTN(IDChitietNhap))
                {
                    // Xoá hoá đơn nhập => Huỷ nhập => số lượng trở về ban đầu
                    BUS_MatHang.GiamSoLuongMatHang(txtIDMatHang.Text, int.Parse(txtSoLuong.Text));
                    MessageBox.Show("Xóa thông tin chi tiết hoá đơn nhập thành công!");
                    dtgvChiTietNhap.DataSource = BUS_ChiTietHoaDonNhap.HienCTN(); // Cập nhật lại danh sách
                }
                else
                {
                    MessageBox.Show("Xóa thông tin chi tiết hoá đơn bán thất bại.");
                }
            }
            btnLamMoi_Click(sender, e);
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            string IDNhap = txtTim.Text.Trim();
            DataTable danhSachCTN = BUS_ChiTietHoaDonNhap.TimCTN(IDNhap);
            dtgvChiTietNhap.DataSource = danhSachCTN;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult DangXuat;
            DangXuat = MessageBox.Show("Xác nhận thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DangXuat == DialogResult.Yes)
            {
                this.Close();
            }
        }
        // Sự kiện liên kết mặt hàng với combobox 
        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Guna2ComboBox ComboBox = sender as Guna2ComboBox;
            if (ComboBox != null && ComboBox.SelectedIndex != -1)
            {
                string MatHang = ((DataRowView)ComboBox.SelectedItem)[ComboBox.ValueMember].ToString();
                DataTable dtMatHang = BUS_MatHang.LayMatHang(MatHang);

                // Cập nhật control tương ứng
                if (ComboBox == txtTenMatHang)
                {
                    txtIDMatHang.Text = MatHang;
                }
                else if (ComboBox == txtIDMatHang)
                {
                    txtTenMatHang.Text = MatHang;
                }

                // Cập nhật đơn giá
                if (dtMatHang.Rows.Count > 0)
                {
                    DataRow dr = dtMatHang.Rows[0];
                    txtDonGiaNhap.Text = dr["DonGia"].ToString();
                }
                else
                {
                    txtDonGiaNhap.Clear();
                }
            }
        }
        // Sự kiện tính ra tổng tiền ở cột tổng tiền
        private void txtDonGiaNhap_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDonGiaNhap.Text) && float.TryParse(txtDonGiaNhap.Text, out float donGiaNhap))
            {
                int soLuong = (int)txtSoLuong.Value;
                float thanhTien = donGiaNhap * soLuong;
                txtThanhTien.Text = thanhTien.ToString("N2");
            }
        }
        private void txtSoLuong_ValueChanged(object sender, EventArgs e)
        {
            txtDonGiaNhap_TextChanged(sender, e);
        }
    }
}