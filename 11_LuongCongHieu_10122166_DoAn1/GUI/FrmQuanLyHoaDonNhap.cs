using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
using DevExpress.XtraReports.UI;

namespace FrmTrangChu.cs
{
    public partial class FrmQuanLyHoaDonNhap : DevExpress.XtraEditors.XtraUserControl
    {
        private BUS_HoaDonNhap BUS_HoaDonNhap = new BUS_HoaDonNhap();
        private BUS_NhaCungCap BUS_NhaCungCap = new BUS_NhaCungCap();
        private BUS_NhanVien BUS_NhanVien = new BUS_NhanVien();
        private LienKetCombobox LienKetCombobox = new LienKetCombobox();
        public FrmQuanLyHoaDonNhap()
        {
            InitializeComponent();
        }
        private bool ValidateInput()
        {
            return true;
        }
        private void btnShowChitiet_Click(object sender, EventArgs e)
        {
            FrmChiTietHoaDonNhap chiTietHoaDonNhap = new FrmChiTietHoaDonNhap();
            chiTietHoaDonNhap.ShowDialog();
        }
        private void btnTaoPhieu_Click(object sender, EventArgs e)
        {
            string idNhap = txtMaHDN.Text; // Lấy ID nhập từ textbox
            DataTable chiTietData = BUS_HoaDonNhap.LayHoaDonNhap(idNhap);

            PhieuHoaDonNhap report = new PhieuHoaDonNhap();
            report.DataSource = chiTietData;
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();
        }
        private string TaoIDMoi()
        {
            // Lấy danh sách ID chức vụ hiện có từ cơ sở dữ liệu
            DataTable dtHDN = BUS_HoaDonNhap.HienHDN();
            int maxNumber = 0;
            foreach (DataRow row in dtHDN.Rows)
            {
                string id = row["IDNhap"].ToString();
                // Giả sử ID có dạng "CVxx" với xx là số
                int number;
                if (int.TryParse(id.Replace("HDN", ""), out number))
                {
                    if (number > maxNumber)
                        maxNumber = number;
                }
            }

            // Tạo ID mới với số tiếp theo
            maxNumber++; // Tăng lên 1 đơn vị
            return "HDN" + maxNumber.ToString("D2"); // Định dạng số với 2 chữ số
        }
        // Các chức năng
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtSoDT.Text = "";
            txtNgayNhap.Text = "";
            CapNhatTongTien();
            dtgvHoaDonNhap.DataSource = BUS_HoaDonNhap.HienHDN();
            LienKetCombobox.LienKet2DuLieu(BUS_NhaCungCap.HienNCC(), "TenNhacung", "IDNhacung", txtTenNCC);
            LienKetCombobox.LienKet2DuLieu(BUS_NhaCungCap.HienNCC(), "IDNhacung", "TenNhacung", txtMaNCC);
            LienKetCombobox.LienKet2DuLieu(BUS_NhanVien.HienNV(), "TenNhanVien", "IDNhanvien", txtTenNV);
            LienKetCombobox.LienKet2DuLieu(BUS_NhanVien.HienNV(), "IDNhanvien", "TenNhanVien", txtMaNV);
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string IDNhap = TaoIDMoi();
            if (ValidateInput())
            {

                // Tạo DTO
                DTO_HoaDonNhap hdn = new DTO_HoaDonNhap(
                    IDNhap,
                    txtMaNCC.Text,
                    txtMaNV.Text,
                    Convert.ToDateTime(txtNgayNhap.Text),
                    float.Parse(txtTongThanhToan.Text)
                );

                // Thêm
                if (BUS_HoaDonNhap.ThemHDN(hdn))
                {
                    MessageBox.Show("Thêm hoá đơn nhập mới thành công");
                    dtgvHoaDonNhap.DataSource = BUS_HoaDonNhap.HienHDN(); // refresh datagridview
                    txtMaHDN.Text = TaoIDMoi();
                }
                else
                {
                    MessageBox.Show("Thêm hoá đơn nhập mới không thành công");
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
                if (dtgvHoaDonNhap.SelectedRows.Count > 0 && ValidateInput())
                {
                    // Lấy row hiện tại
                    DataGridViewRow row = dtgvHoaDonNhap.SelectedRows[0];
                    string ID = row.Cells["IDNhap"].Value.ToString();

                    // Tạo DTO
                    DTO_HoaDonNhap hdn = new DTO_HoaDonNhap(
                        txtMaHDN.Text,
                        txtMaNCC.Text,
                        txtMaNV.Text,
                        Convert.ToDateTime(txtNgayNhap.Text),
                        float.Parse(txtTongThanhToan.Text)
                    );

                    // Sửa
                    if (BUS_HoaDonNhap.SuaHDN(hdn))
                    {
                        MessageBox.Show("Cập nhật thông tin hoá đơn nhập thành công");
                        dtgvHoaDonNhap.DataSource = BUS_HoaDonNhap.HienHDN(); // refresh datagridview
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thông tin hoá đơn nhập không thành công");
                        txtMaHDN.Focus();
                    }
                }
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string IDNhap = txtMaHDN.Text; // Lấy ID từ textbox hoặc từ DataGridView
            if (MessageBox.Show("Bạn có thật sự muốn xóa không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                // Gọi phương thức Xóa từ BUS
                if (BUS_HoaDonNhap.XoaHDN(IDNhap))
                {
                    MessageBox.Show("Xóa thông tin hoá đơn nhập thành công!");
                    dtgvHoaDonNhap.DataSource = BUS_HoaDonNhap.HienHDN(); // Cập nhật lại danh sách
                }
                else
                {
                    MessageBox.Show("Xóa thông tin hoá đơn nhập thất bại.");
                }
            }
            btnLamMoi_Click(sender, e);
        }
        private void dtgvHoaDonNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgvHoaDonNhap.Rows[e.RowIndex];
                txtMaHDN.Text = row.Cells["IDNhap"].Value.ToString();
                txtMaNCC.Text = row.Cells["IDNhacung"].Value.ToString();
                txtMaNV.Text = row.Cells["IDNhanvien"].Value.ToString();
                txtNgayNhap.Text = row.Cells["NgayNhap"].Value.ToString();
                txtTongThanhToan.Text = string.Format("{0:N0}", row.Cells["TongThanhToan"].Value);
            }
        }
        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Guna2ComboBox ComboBox = sender as Guna2ComboBox;
            if (ComboBox != null && ComboBox.SelectedIndex != -1)
            {
                string IDNhacung = ((DataRowView)ComboBox.SelectedItem)[ComboBox.ValueMember].ToString();
                DataTable dtIDNhacung = BUS_NhaCungCap.LayNCC(IDNhacung);

                // Cập nhật thông tin khách hàng tương ứng
                if (ComboBox == txtTenNCC)
                {
                    txtMaNCC.Text = IDNhacung;
                    // Hiển thị số điện thoại nếu có thông tin khách hàng
                    if (dtIDNhacung.Rows.Count > 0)
                    {
                        DataRow dr = dtIDNhacung.Rows[0];
                        txtSoDT.Text = dr["SoDienThoai"].ToString();
                    }
                    else
                    {
                        txtSoDT.Clear();
                    }
                }
                else if (ComboBox == txtMaNCC)
                {
                    txtTenNCC.Text = IDNhacung;
                    // Hiển thị số điện thoại nếu có thông tin khách hàng
                    if (dtIDNhacung.Rows.Count > 0)
                    {
                        DataRow dr = dtIDNhacung.Rows[0];
                        txtSoDT.Text = dr["SoDienThoai"].ToString();
                    }
                    else
                    {
                        txtSoDT.Clear();
                    }
                }
                else if (ComboBox == txtTenNCC1)
                {
                    txtMaNCC1.Text = IDNhacung;
                }
                else if (ComboBox == txtMaNCC1)
                {
                    txtTenNCC1.Text = IDNhacung;
                }
            }
        }
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Guna2ComboBox ComboBox = sender as Guna2ComboBox;
            if (ComboBox != null && ComboBox.SelectedIndex != -1)
            {
                string maNhanVien = ((DataRowView)ComboBox.SelectedItem)[ComboBox.ValueMember].ToString();
                // Cập nhật thông tin khách hàng tương ứng
                if (ComboBox == txtTenNV)
                {
                    txtMaNV.Text = maNhanVien;
                }
                else if (ComboBox == txtMaNV)
                {
                    txtTenNV.Text = maNhanVien;
                }
            }
        }
        private void FrmQuanLyHoaDonNhap_Load(object sender, EventArgs e)
        {
            dtgvHoaDonNhap.DataSource = BUS_HoaDonNhap.HienHDN();

            LienKetCombobox.LienKet2DuLieu(BUS_NhaCungCap.HienNCC(), "TenNhacung", "IDNhacung", txtTenNCC);
            txtTenNCC.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged);

            LienKetCombobox.LienKet2DuLieu(BUS_NhaCungCap.HienNCC(), "IDNhacung", "TenNhacung", txtMaNCC);
            txtMaNCC.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged);

            LienKetCombobox.LienKet2DuLieu(BUS_NhaCungCap.HienNCC(), "TenNhacung", "IDNhacung", txtTenNCC1);
            txtTenNCC1.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged);

            LienKetCombobox.LienKet2DuLieu(BUS_NhaCungCap.HienNCC(), "IDNhacung", "TenNhacung", txtMaNCC1);
            txtMaNCC1.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged);

            DataTable dtNhanVien = BUS_NhanVien.HienNV();

            DataView dvNhanVien = new DataView(dtNhanVien);
            dvNhanVien.RowFilter = "IDChucVu = 'CV04'";

            txtTenNV.DataSource = dvNhanVien;
            txtTenNV.DisplayMember = "TenNhanVien";
            txtTenNV.ValueMember = "IDNhanvien";

            txtMaNV.DataSource = dvNhanVien;
            txtMaNV.DisplayMember = "IDNhanvien";
            txtMaNV.ValueMember = "TenNhanVien";

            txtTenNV.SelectedIndexChanged += new EventHandler(ComboBox1_SelectedIndexChanged);
            txtMaNV.SelectedIndexChanged += new EventHandler(ComboBox1_SelectedIndexChanged);
        }
        private void CapNhatTongTien()
        {
            string IDNhap = txtMaHDN.Text;
            float tongTien = BUS_HoaDonNhap.TinhTongTien(IDNhap);
            txtTongThanhToan.Text = tongTien.ToString("N0");
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            DateTime ngay = Convert.ToDateTime(txtNgay.Text);
            DataTable DSHoaDon = BUS_HoaDonNhap.TimHDN1(ngay);
            dtgvHoaDonNhap.DataSource = DSHoaDon;
        }

        private void btnTim1_Click(object sender, EventArgs e)
        {
            string maNCC = txtMaNCC1.Text;
            DataTable DSHoaDon = BUS_HoaDonNhap.TimHDN2(maNCC);
            dtgvHoaDonNhap.DataSource = DSHoaDon;
        }
    }
}
