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
using DevExpress.XtraReports.UI;

namespace FrmTrangChu.cs
{
    public partial class FrmQuanLyHoaDonBan : DevExpress.XtraEditors.XtraUserControl
    {
        private BUS_HoaDonBan BUS_HoaDon = new BUS_HoaDonBan();
        private BUS_KhachHang BUS_KhachHang = new BUS_KhachHang();
        private BUS_NhanVien BUS_NhanVien = new BUS_NhanVien();
        private LienKetCombobox LienKetCombobox = new LienKetCombobox();
        public FrmQuanLyHoaDonBan()
        {
            InitializeComponent();
        }
        private bool ValidateInput()
        {
            return true;
        }
        private void btnShowChitiet_Click(object sender, EventArgs e)
        {
            FrmChiTietHoaDonBan chiTietHoaDonBan = new FrmChiTietHoaDonBan();
            chiTietHoaDonBan.ShowDialog();
        }
        private void btnTaoPhieu_Click(object sender, EventArgs e)
        {
            string idBan = txtMaHDB.Text; // Lấy ID nhập từ textbox
            DataTable chiTietData = BUS_HoaDon.LayHoaDonBan(idBan);
            PhieuHoaDonBan report = new PhieuHoaDonBan();
            report.DataSource = chiTietData;
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();
        }

        private string TaoIDMoi()
        {
            // Lấy danh sách ID chức vụ hiện có từ cơ sở dữ liệu
            DataTable dtHDB = BUS_HoaDon.HienHDB();
            int maxNumber = 0;
            foreach (DataRow row in dtHDB.Rows)
            {
                string id = row["IDBan"].ToString();
                // Giả sử ID có dạng "CVxx" với xx là số
                int number;
                if (int.TryParse(id.Replace("HDB", ""), out number))
                {
                    if (number > maxNumber)
                        maxNumber = number;
                }
            }
            // Tạo ID mới với số tiếp theo
            maxNumber++; // Tăng lên 1 đơn vị
            return "HDB" + maxNumber.ToString("D2"); // Định dạng số với 2 chữ số
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string IDBan = TaoIDMoi();
            if (ValidateInput())
            {

                // Tạo DTO
                DTO_HoaDonBan hdb = new DTO_HoaDonBan(
                    IDBan,
                    txtMaKH.Text,
                    txtMaNV.Text,
                    Convert.ToDateTime(txtNgayBan.Text),
                    float.Parse(txtTongTien.Text)
                );

                // Thêm
                if (BUS_HoaDon.ThemHDB(hdb))
                {        
                    MessageBox.Show("Thêm hoá đơn bán mới thành công");
                    dtgvHoaDonBan.DataSource = BUS_HoaDon.HienHDB(); // refresh datagridview
                    txtMaHDB.Text = TaoIDMoi();
                }
                else
                {
                    MessageBox.Show("Thêm hoá đơn bán mới không thành công");
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
                if (dtgvHoaDonBan.SelectedRows.Count > 0 && ValidateInput())
                {
                    // Lấy row hiện tại
                    DataGridViewRow row = dtgvHoaDonBan.SelectedRows[0];
                    string ID = row.Cells["IDBan"].Value.ToString();

                    // Tạo DTO
                    DTO_HoaDonBan hdb = new DTO_HoaDonBan(
                    txtMaHDB.Text,
                    txtMaKH.Text,
                    txtMaNV.Text,
                    Convert.ToDateTime(txtNgayBan.Text),
                    float.Parse(txtTongTien.Text)
                );

                    // Sửa
                    if (BUS_HoaDon.SuaHDB(hdb))
                    {
                        MessageBox.Show("Cập nhật thông tin hoá đơn bán thành công");
                        dtgvHoaDonBan.DataSource = BUS_HoaDon.HienHDB(); // refresh datagridview
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thông tin hoá đơn bán không thành công");
                        txtMaHDB.Focus();
                    }
                }
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string IDBan = txtMaHDB.Text; // Lấy ID từ textbox hoặc từ DataGridView
            if (MessageBox.Show("Bạn có thật sự muốn xóa không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                // Gọi phương thức Xóa từ BUS
                if (BUS_HoaDon.XoaHDB(IDBan))
                {
                    MessageBox.Show("Xóa thông tin hoá đơn bán thành công!");
                    dtgvHoaDonBan.DataSource = BUS_HoaDon.HienHDB(); // Cập nhật lại danh sách
                }
                else
                {
                    MessageBox.Show("Xóa thông tin hoá đơn bán thất bại.");
                }
            }
            btnLamMoi_Click(sender, e);
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtSoDT.Text = "";
            txtNgayBan.Text = "";
            CapNhatTongTien();
            dtgvHoaDonBan.DataSource = BUS_HoaDon.HienHDB();
            LienKetCombobox.LienKet2DuLieu(BUS_KhachHang.HienKH(), "TenKhach", "IDKhach", txtTenKH);
            LienKetCombobox.LienKet2DuLieu(BUS_KhachHang.HienKH(), "IDKhach", "TenKhach", txtMaKH);
            LienKetCombobox.LienKet2DuLieu(BUS_KhachHang.HienKH(), "TenKhach", "IDKhach", txtTenKH1);
            LienKetCombobox.LienKet2DuLieu(BUS_KhachHang.HienKH(), "IDKhach", "TenKhach", txtMaKH1);
        }
        private void FrmQuanLyHoaDonBan_Load(object sender, EventArgs e)
        {
            dtgvHoaDonBan.DataSource = BUS_HoaDon.HienHDB();
            LienKetCombobox.LienKet2DuLieu(BUS_KhachHang.HienKH(), "TenKhach", "IDKhach", txtTenKH);
            txtTenKH.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged);

            LienKetCombobox.LienKet2DuLieu(BUS_KhachHang.HienKH(), "IDKhach", "TenKhach", txtMaKH);
            txtMaKH.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged);

            LienKetCombobox.LienKet2DuLieu(BUS_KhachHang.HienKH(), "TenKhach", "IDKhach", txtTenKH1);
            txtMaKH1.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged);

            LienKetCombobox.LienKet2DuLieu(BUS_KhachHang.HienKH(), "IDKhach", "TenKhach", txtMaKH1);
            txtTenKH1.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged);


            DataTable dtNhanVien = BUS_NhanVien.HienNV();

            DataView dvNhanVien = new DataView(dtNhanVien);
            dvNhanVien.RowFilter = "IDChucVu = 'CV02'";

            txtTenNV.DataSource = dvNhanVien;
            txtTenNV.DisplayMember = "TenNhanVien";
            txtMaNV.ValueMember = "IDNhanvien";

            txtMaNV.DataSource = dvNhanVien;
            txtMaNV.DisplayMember = "IDNhanvien";
            txtTenNV.ValueMember = "TenNhanVien";

            txtTenNV.SelectedIndexChanged += new EventHandler(ComboBox1_SelectedIndexChanged);
            txtMaNV.SelectedIndexChanged += new EventHandler(ComboBox1_SelectedIndexChanged);
        }
        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Guna2ComboBox ComboBox = sender as Guna2ComboBox;
            if (ComboBox != null && ComboBox.SelectedIndex != -1)
            {
                string khachhang = ((DataRowView)ComboBox.SelectedItem)[ComboBox.ValueMember].ToString();
                DataTable dtKH = BUS_KhachHang.LayKhachHang(khachhang);

                // Cập nhật thông tin khách hàng tương ứng
                if (ComboBox == txtTenKH)
                {
                    txtMaKH.Text = khachhang;
                    // Hiển thị số điện thoại nếu có thông tin khách hàng
                    if (dtKH.Rows.Count > 0)
                    {
                        DataRow dr = dtKH.Rows[0];
                        txtSoDT.Text = dr["SoDienThoai"].ToString();
                    }
                    else
                    {
                        txtSoDT.Clear();
                    }
                }
                else if (ComboBox == txtMaKH)
                {
                    txtTenKH.Text = khachhang;
                    // Hiển thị số điện thoại nếu có thông tin khách hàng
                    if (dtKH.Rows.Count > 0)
                    {
                        DataRow dr = dtKH.Rows[0];
                        txtSoDT.Text = dr["SoDienThoai"].ToString();
                    }
                    else
                    {
                        txtSoDT.Clear();
                    }
                }
                else if (ComboBox == txtTenKH1)
                {
                    txtMaKH1.Text = khachhang;
                }
                else if (ComboBox == txtMaKH1)
                {
                    txtTenKH1.Text = khachhang;
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
        private void dtgvHoaDonBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgvHoaDonBan.Rows[e.RowIndex];
                txtMaHDB.Text = row.Cells["IDBan"].Value.ToString();
                txtMaKH.Text = row.Cells["IDKhach"].Value.ToString();
                txtMaNV.Text = row.Cells["IDNhanvien"].Value.ToString();
                txtNgayBan.Text = row.Cells["NgayBan"].Value.ToString();
                txtTongTien.Text = string.Format("{0:N0}", row.Cells["TongTien"].Value);
            }
        }
        private void CapNhatTongTien()
        {
            string IDBan = txtMaHDB.Text;
            float tongTien = BUS_HoaDon.TinhTongTien(IDBan);
            txtTongTien.Text = tongTien.ToString("N0");
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            DateTime ngay = Convert.ToDateTime(txtNgay.Text);
            DataTable DSHoaDon = BUS_HoaDon.TimHDB1(ngay);
            dtgvHoaDonBan.DataSource = DSHoaDon;
        }

        private void btnTim1_Click(object sender, EventArgs e)
        {
            string maKH = txtMaKH1.Text;
            DataTable DSHoaDon = BUS_HoaDon.TimHDB2(maKH);
            dtgvHoaDonBan.DataSource = DSHoaDon;
        }
    }
}
