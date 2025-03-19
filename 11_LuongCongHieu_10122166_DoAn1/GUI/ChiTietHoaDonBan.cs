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
using DevExpress.XtraGrid.Views.Grid;
using Guna.UI2.WinForms;

namespace FrmTrangChu.cs
{
    public partial class FrmChiTietHoaDonBan : DevExpress.XtraEditors.XtraForm
    {
        private BUS_HoaDonBan BUS_HoaDonBan = new BUS_HoaDonBan();
        private BUS_ChiTietHoaDonBan bUS_ChiTietHoaDon = new BUS_ChiTietHoaDonBan();
        private BUS_MatHang BUS_MatHang = new BUS_MatHang();
        private LienKetCombobox LienKetCombobox = new LienKetCombobox();
        public FrmChiTietHoaDonBan()
        {
            InitializeComponent();
        }
        private bool ValidateInput()
        {
            return true;
        }
        private void dtgvChiTietBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgvChiTietBan.Rows[e.RowIndex];
                txtIDChitietBan.Text = row.Cells["IDChitietBan"].Value.ToString();
                txtIDBan.Text = row.Cells["IDBan"].Value.ToString();
                txtIDMatHang.Text = row.Cells["IDMatHang"].Value.ToString();
                txtSoLuong.Text = row.Cells["SoLuong"].Value.ToString();
                txtDonGiaXuat.Text = string.Format("{0:N0}", row.Cells["DonGiaXuat"].Value);
                txtThanhTien.Text = string.Format("{0:N0}", row.Cells["ThanhTien"].Value);
            }
        }
        private void FrmChiTietHoaDonBan_Load(object sender, EventArgs e)
        {
            dtgvChiTietBan.DataSource = bUS_ChiTietHoaDon.HienCT();
            LienKetCombobox.LienKet1DuLieu(BUS_HoaDonBan.HienHDB(), "IDBan", txtIDBan);
            LienKetCombobox.LienKet1DuLieu(BUS_HoaDonBan.HienHDB(), "IDBan", txtIDBan1);

            LienKetCombobox.LienKet2DuLieu(BUS_MatHang.Hienmn(), "Tenmathang", "IDMatHang", txtTenMatHang);
            txtTenMatHang.SelectedIndexChanged += new EventHandler(ComboBox1_SelectedIndexChanged);

            LienKetCombobox.LienKet2DuLieu(BUS_MatHang.Hienmn(), "IDMatHang", "Tenmathang", txtIDMatHang);
            txtIDMatHang.SelectedIndexChanged += new EventHandler(ComboBox1_SelectedIndexChanged);
        }
        private string TaoIDMoi()// Tự động tạo iD mới tăng dần
        {
            // Lấy danh sách ID chức vụ hiện có từ cơ sở dữ liệu
            DataTable dtHDB = bUS_ChiTietHoaDon.HienCT();
            int maxNumber = 0;
            foreach (DataRow row in dtHDB.Rows)
            {
                string id = row["IDChitietBan"].ToString();
                int number;
                if (int.TryParse(id.Replace("CTB", ""), out number))
                {
                    if (number > maxNumber)
                        maxNumber = number;
                }
            }
            // Tạo ID mới với số tiếp theo
            maxNumber++; // Tăng lên 1 đơn vị
            return "CTB" + maxNumber.ToString("D2"); // Định dạng số với 2 chữ số
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtDonGiaXuat.Text = "";
            txtSoLuong.ToString();
            txtThanhTien.Text = "";

            // Sự kiện load lại các combobox
            LienKetCombobox.LienKet1DuLieu(BUS_HoaDonBan.HienHDB(), "IDBan", txtIDBan);
            LienKetCombobox.LienKet1DuLieu(BUS_HoaDonBan.HienHDB(), "IDBan", txtIDBan1);
            LienKetCombobox.LienKet2DuLieu(BUS_MatHang.Hienmn(), "Tenmathang", "IDMatHang", txtTenMatHang);
            LienKetCombobox.LienKet2DuLieu(BUS_MatHang.Hienmn(), "IDMatHang", "Tenmathang", txtIDMatHang);
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string IDChitietBan = TaoIDMoi();
            if (ValidateInput())
            {

                // Tạo DTO
                DTO_ChiTietHoaDonBan cthdb = new DTO_ChiTietHoaDonBan(
                    IDChitietBan,
                    txtIDBan.Text,
                    txtIDMatHang.Text,
                    int.Parse(txtSoLuong.Text),
                    float.Parse(txtDonGiaXuat.Text),
                    float.Parse(txtThanhTien.Text)
                );
                // Thêm
                if (bUS_ChiTietHoaDon.ThemCT(cthdb))
                {
                    // Xác nhận thanh toán đơn hàng thành công => số lượng hàng giảm
                    BUS_MatHang.GiamSoLuongMatHang(txtIDMatHang.Text, int.Parse(txtSoLuong.Text));
                    MessageBox.Show("Thêm chi tiết hoá đơn bán mới thành công");
                    dtgvChiTietBan.DataSource = bUS_ChiTietHoaDon.HienCT(); // refresh datagridview
                    txtIDChitietBan.Text = TaoIDMoi();
                }
                else
                {
                    MessageBox.Show("Thêm chi tiết hoá đơn bán mới không thành công");
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
                if (dtgvChiTietBan.SelectedRows.Count > 0 && ValidateInput())
                {
                    // Lấy row hiện tại
                    DataGridViewRow row = dtgvChiTietBan.SelectedRows[0];
                    string ID = row.Cells["IDChitietBan"].Value.ToString();

                    // Tạo DTO
                    DTO_ChiTietHoaDonBan cthdb = new DTO_ChiTietHoaDonBan(
                    txtIDChitietBan.Text,
                    txtIDBan.Text,
                    txtIDMatHang.Text,
                    int.Parse(txtSoLuong.Text),
                    float.Parse(txtDonGiaXuat.Text),
                    float.Parse(txtThanhTien.Text)
                );

                    // Sửa
                    if (bUS_ChiTietHoaDon.SuaCT(cthdb))
                    {
                        MessageBox.Show("Cập nhật thông tin chi tiết hoá đơn bán thành công");
                        dtgvChiTietBan.DataSource = bUS_ChiTietHoaDon.HienCT(); // refresh datagridview
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thông tin chi tiết hoá đơn bán không thành công");
                        txtIDChitietBan.Focus();
                    }
                }
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string IDChitietBan = txtIDChitietBan.Text; // Lấy ID từ textbox hoặc từ DataGridView
            if (MessageBox.Show("Bạn có thật sự muốn xóa không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                // Gọi phương thức Xóa từ BUS
                if (bUS_ChiTietHoaDon.XoaCT(IDChitietBan))
                {
                    // Xoá hoá đơn bán => huỷ hoá đơn số lượng mặt hàng trở về ban đầu
                    BUS_MatHang.TangSoLuongMatHang(txtIDMatHang.Text, int.Parse(txtSoLuong.Text));
                    MessageBox.Show("Xóa thông tin chi tiết hoá đơn bán thành công!");
                    dtgvChiTietBan.DataSource = bUS_ChiTietHoaDon.HienCT(); // Cập nhật lại danh sách
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
            string IDBan = txtIDBan1.Text.Trim();
            DataTable danhSachCTB = bUS_ChiTietHoaDon.TimCT(IDBan);
            dtgvChiTietBan.DataSource = danhSachCTB;
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
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
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
                    txtDonGiaXuat.Text = dr["DonGia"].ToString();
                }
                else
                {
                    txtDonGiaXuat.Clear();
                }
            }
        }
        // Sự kiện tính ra tổng tiền ở cột tổng tiền
        private void txtDonGiaXuat_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDonGiaXuat.Text) && float.TryParse(txtDonGiaXuat.Text, out float DonGiaBan))
            {
                int soLuong = (int)txtSoLuong.Value;
                float thanhTien = DonGiaBan * soLuong;
                txtThanhTien.Text = thanhTien.ToString("N0");
            }
        }
        private void txtSoLuong_ValueChanged(object sender, EventArgs e)
        {
            // Khi số lượng thay đổi, tính toán lại thành tiền
            txtDonGiaXuat_TextChanged(sender, e);
        }
    }
}