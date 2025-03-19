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
    public partial class FrmQuanLyChucVu_TinhLuong : DevExpress.XtraEditors.XtraUserControl
    {
        private BUS_NhanVien bUS_NhanVien = new BUS_NhanVien();
        private BUS_ChucVu BUS_ChucVu = new BUS_ChucVu();
        private BUS_TinhLuong BUS_TinhLuong = new BUS_TinhLuong();
        LienKetCombobox combobox = new LienKetCombobox();
        public FrmQuanLyChucVu_TinhLuong()
        {
            InitializeComponent();
        }
        private void FrmQuanLyChucVu_TinhLuong_Load(object sender, EventArgs e)
        {
            dtgvHeSoChucVu.DataSource = BUS_ChucVu.HienCV();
            dtgvTinhLuong.DataSource = BUS_TinhLuong.HienTL();

            combobox.LienKet1DuLieu(bUS_NhanVien.HienNV(), "IDNhanvien", txtIDNhanvien);

            combobox.LienKet1DuLieu(BUS_ChucVu.HienCV(), "ChucVu", txtTim1);

            combobox.LienKet2DuLieu(BUS_ChucVu.HienCV(), "ChucVu", "IDChucVu", txtTenChucVu1);
            txtTenChucVu1.SelectedIndexChanged += new EventHandler(ChucVu_SelectedIndexChanged);

            combobox.LienKet2DuLieu(BUS_ChucVu.HienCV(), "IDChucVu", "ChucVu", txtMaChucVu1);
            txtMaChucVu1.SelectedIndexChanged += new EventHandler(ChucVu_SelectedIndexChanged);

            combobox.LienKet2DuLieu(BUS_ChucVu.HienCV(), "ChucVu", "IDChucVu", txtTenCV);
            txtMaCV.SelectedIndexChanged += new EventHandler(ChucVu_SelectedIndexChanged);

            combobox.LienKet2DuLieu(BUS_ChucVu.HienCV(), "IDChucVu", "ChucVu", txtMaCV);
            txtTenCV.SelectedIndexChanged += new EventHandler(ChucVu_SelectedIndexChanged);
        }
        public bool ValidateInput()
        {
            return true;
        }
        private void dtgvHeSoChucVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgvHeSoChucVu.Rows[e.RowIndex];
                txtMaChucVu.Text = row.Cells["IDChucVu"].Value.ToString();
                txtTenChucVu.Text = row.Cells["ChucVu"].Value.ToString();
                txtHeSoLuong.Text = row.Cells["HeSoLuong"].Value.ToString();
                txtMaChucVu.Focus();
            }
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTenChucVu.Text = "";
            txtHeSoLuong.Text = "";
            dtgvHeSoChucVu.DataSource = BUS_ChucVu.HienCV();
            combobox.LienKet1DuLieu(bUS_NhanVien.HienNV(), "IDNhanvien", txtIDNhanvien);
            combobox.LienKet1DuLieu(BUS_ChucVu.HienCV(), "ChucVu", txtTim1);
            combobox.LienKet2DuLieu(BUS_ChucVu.HienCV(), "ChucVu", "IDChucVu", txtTenChucVu1);
            combobox.LienKet2DuLieu(BUS_ChucVu.HienCV(), "IDChucVu", "ChucVu", txtMaChucVu1);
            combobox.LienKet2DuLieu(BUS_ChucVu.HienCV(), "ChucVu", "IDChucVu", txtTenCV);
            combobox.LienKet2DuLieu(BUS_ChucVu.HienCV(), "IDChucVu", "ChucVu", txtMaCV);
        }
        private string IDChucvu()
        {
            // Lấy danh sách ID chức vụ hiện có từ cơ sở dữ liệu
            DataTable dtChucVu = BUS_ChucVu.HienCV();
            int maxNumber = 0;
            // Duyệt qua danh sách để tìm số lớn nhất
            foreach (DataRow row in dtChucVu.Rows)
            {
                int number;
                string id = row["IDChucVu"].ToString();
                // Giả sử ID có dạng "CVxx" với xx là số

                if (int.TryParse(id.Replace("CV", ""), out number))
                {
                    if (number > maxNumber)
                        maxNumber = number;
                }
            }
            // Tạo ID mới với số tiếp theo
            maxNumber++; // Tăng lên 1 đơn vị
            return "CV" + maxNumber.ToString("D2"); // Định dạng số với 2 chữ số
        }
        // Các chức năng
        private void btnLuu_Click(object sender, EventArgs e)
        {
            int hesoluong;
            bool isHeSoLuongvalid = int.TryParse(txtHeSoLuong.Text, out hesoluong);
            if (ValidateInput())
            {
                // Tạo ID chức vụ mới
                string maChucVuMoi = IDChucvu();

                // Tạo DTO với hệ số lương là số nguyên và ID chức vụ mới
                DTO_ChucVu cv = new DTO_ChucVu(
                    maChucVuMoi,
                    txtTenChucVu.Text,
                    hesoluong
                );
                if (BUS_ChucVu.ThemCV(cv))
                {
                    MessageBox.Show("Thêm chức vụ mới thành công");
                    dtgvHeSoChucVu.DataSource = BUS_ChucVu.HienCV(); // refresh datagridview
                    txtMaChucVu.Text = IDChucvu(); // Cập nhật ID chức vụ mới cho lần thêm tiếp theo
                }
                else
                {
                    MessageBox.Show("Thêm chức vụ mới không thành công");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập lại thông tin");
            }
            btnLamMoi_Click(sender, e);
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            int hesoluong;
            bool isHeSoLuongvalid = int.TryParse(txtHeSoLuong.Text, out hesoluong);
            if (MessageBox.Show("Bạn có muốn sửa không?", "Sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (dtgvHeSoChucVu.SelectedRows.Count > 0 && ValidateInput())
                {
                    DataGridViewRow row = dtgvHeSoChucVu.SelectedRows[0];
                    string IDChucVu = row.Cells["IDChucVu"].Value.ToString();
                    DTO_ChucVu cv = new DTO_ChucVu(
                        txtMaChucVu.Text,
                        txtTenChucVu.Text,
                        hesoluong
                        );
                    if (BUS_ChucVu.SuaCV(cv))
                    {
                        MessageBox.Show("Cập nhật thông tin chức vụ thành công");
                        dtgvHeSoChucVu.DataSource = BUS_ChucVu.HienCV();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thông tin chức vụ không thành công");
                        txtMaChucVu.Focus();
                    }
                }
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string MaChucVu = txtMaChucVu.Text; // Lấy ID từ textbox hoặc từ DataGridView
            if (MessageBox.Show("Bạn có thật sự muốn xóa không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                // Gọi phương thức Xóa từ BUS
                if (BUS_ChucVu.XoaCV(MaChucVu))
                {
                    MessageBox.Show("Xóa thông tin chức vụ thành công!");
                    dtgvHeSoChucVu.DataSource = BUS_ChucVu.HienCV(); // Cập nhật lại danh sách
                }
                else
                {
                    MessageBox.Show("Xóa thông tin chức vụ thất bại.");
                }
            }
            btnLamMoi_Click(sender, e);
        }
        // tìm bằng tên chức vụ
        private void txtTim1_Click(object sender, EventArgs e)
        {
            string TenCV = txtTim1.Text.Trim();
            DataTable danhSachCV = BUS_ChucVu.TimCV(TenCV);
            dtgvHeSoChucVu.DataSource = danhSachCV;
        }

        // Tính lương
        private void btnrefresh_Click(object sender, EventArgs e)
        {
            txtLuongCoBan.Text = "";
            txtThuong.Text = "";
            txtPhat.Text = "";
            txtTongLuong.Text = "";// Liên kết dữ liệu nhân viên với ComboBox
        }
        private string IDLuong()
        {
            // Lấy danh sách ID chức vụ hiện có từ cơ sở dữ liệu
            DataTable dtLuong = BUS_TinhLuong.HienTL();
            int maxNumber = 0;
            foreach (DataRow row in dtLuong.Rows)
            {
                string id = row["IDTinhLuong"].ToString();
                // Giả sử ID có dạng "CVxx" với xx là số
                int number;
                if (int.TryParse(id.Replace("TL", ""), out number))
                {
                    if (number > maxNumber)
                        maxNumber = number;
                }
            }
            // Tạo ID mới với số tiếp theo
            maxNumber++; // Tăng lên 1 đơn vị
            return "TL" + maxNumber.ToString("D2");
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string IDLuongMoi = IDLuong();
            if (ValidateInput())
            {
                // Tạo đối tượng DTO với các giá trị đã chuyển đổi
                DTO_TinhLuong tl = new DTO_TinhLuong(
                    IDLuongMoi,
                    txtIDNhanvien.Text,
                    txtMaChucVu1.Text,
                    float.Parse(txtLuongCoBan.Text),
                    float.Parse(txtThuong.Text),
                    float.Parse(txtPhat.Text),
                    float.Parse(txtTongLuong.Text)
                    );
                // Thực hiện thêm vào cơ sở dữ liệu
                if (BUS_TinhLuong.ThemTL(tl))
                {
                    MessageBox.Show("Thêm loại tài khoản thành công");
                    dtgvTinhLuong.DataSource = BUS_TinhLuong.HienTL();
                    txtIDTinhLuong.Text = IDLuong();
                }
                else
                {
                    MessageBox.Show("Thêm loại tài khoản không thành công");
                }
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ thông tin");
            }
            btnLamMoi_Click(sender, e);
            txtIDTinhLuong.Focus();
        }
        private void btnFix_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn sửa không?", "Sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (dtgvTinhLuong.SelectedRows.Count > 0 && ValidateInput())
                {
                    DataGridViewRow row = dtgvTinhLuong.SelectedRows[0];
                    string ID = row.Cells["IDTinhLuong"].Value.ToString();

                    // Tạo đối tượng DTO với các giá trị đã chuyển đổi
                    DTO_TinhLuong tl = new DTO_TinhLuong(
                        txtIDTinhLuong.Text,
                        txtIDNhanvien.Text,
                        txtMaChucVu1.Text,
                        float.Parse(txtLuongCoBan.Text),
                        float.Parse(txtThuong.Text),
                        float.Parse(txtPhat.Text),
                        float.Parse(txtTongLuong.Text)
                        );
                    if (BUS_TinhLuong.SuaTL(tl))
                    {
                        MessageBox.Show("Cập nhật thông tin lương thành công");
                        dtgvTinhLuong.DataSource = BUS_TinhLuong.HienTL();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thông tin lương không thành công");
                        txtIDTinhLuong.Focus();
                    }
                }
            }
        }
        private void btldelete_Click(object sender, EventArgs e)
        {
            string IDLuong = txtIDTinhLuong.Text; // Lấy ID từ textbox hoặc từ DataGridView
            if (MessageBox.Show("Bạn có thật sự muốn xóa không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                // Gọi phương thức Xóa từ BUS
                if (BUS_TinhLuong.XoaTL(IDLuong))
                {
                    MessageBox.Show("Xóa thông tin lương thành công!");
                    dtgvTinhLuong.DataSource = BUS_TinhLuong.HienTL(); // Cập nhật lại danh sách
                }
                else
                {
                    MessageBox.Show("Xóa thông tin lương thất bại.");
                }
            }
            btnLamMoi_Click(sender, e);
        }
        private void btnTinhTong_Click(object sender, EventArgs e)
        {
            int heSoLuong = int.Parse(txtHeSoLuong.Text.Trim());
            string IDTinhLuong;
            float LuongCoBan, Thuong, Phat, TongLuong;
            Thuong = float.Parse(txtThuong.Text.Trim());
            Phat = float.Parse(txtPhat.Text.Trim());
            LuongCoBan = float.Parse(txtLuongCoBan.Text.Trim());
            IDTinhLuong = txtIDTinhLuong.Text;
            float TongTien = BUS_TinhLuong.tinhLuong(heSoLuong, LuongCoBan, Thuong, Phat, IDTinhLuong);
            txtTongLuong.Text = TongTien.ToString("N2");
        }
        private void dtgvTinhLuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgvTinhLuong.Rows[e.RowIndex];
                txtIDTinhLuong.Text = row.Cells["IDTinhLuong"].Value.ToString();
                txtIDNhanvien.Text = row.Cells["IDNhanvien"].Value.ToString();
                txtMaChucVu1.Text = row.Cells["IDChucVu1"].Value.ToString();
                txtLuongCoBan.Text = string.Format("{0:N0}", row.Cells["LuongCoBan"].Value);
                txtThuong.Text = string.Format("{0:N0}", row.Cells["Thuong"].Value);
                txtPhat.Text = string.Format("{0:N0}", row.Cells["Phat"].Value);
                txtTongLuong.Text = string.Format("{0:N0}", row.Cells["TongLuong"].Value);

                txtIDTinhLuong.Focus();
            }
            dtgvHeSoChucVu_CellClick(sender, e);
        }
        private void ChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            Guna2ComboBox comboBox = sender as Guna2ComboBox;
            if (comboBox != null && comboBox.SelectedIndex != -1)
            {
                string maChucVu = ((DataRowView)comboBox.SelectedItem)[comboBox.ValueMember].ToString();
                DataTable dtNhanVien = bUS_NhanVien.LayNhanVien(maChucVu);
                if (comboBox == txtTenChucVu1)
                {
                    txtMaChucVu1.Text = maChucVu;
                    // Hiển thị thông tin nhân viên đầu tiên (nếu có)
                    if (dtNhanVien.Rows.Count > 0)
                    {
                        DataRow dr = dtNhanVien.Rows[0];
                        txtTenNhanVien.Text = dr["TenNhanVien"].ToString();
                    }
                    // Gán danh sách nhân viên vào combo box
                    txtIDNhanvien.DataSource = dtNhanVien;
                    txtIDNhanvien.DisplayMember = "IDNhanvien";
                    txtIDNhanvien.ValueMember = "IDNhanvien";
                }
                else if (comboBox == txtMaChucVu1)
                {
                    txtTenChucVu1.Text = maChucVu;
                }
                else if (comboBox == txtTenCV)
                {
                    txtMaCV.Text = maChucVu;
                }
                else if (comboBox == txtMaCV)
                {
                    txtTenCV.Text = maChucVu;
                }
               
                //lấy danh sách nhân viên có cùng chức vụ
            }
        }
        // tìm bằng mã chức vụ
        private void btnTim_Click(object sender, EventArgs e)
        {
            string IDCV = txtMaCV.Text.Trim();
            DataTable danhSachTL = BUS_TinhLuong.TimTL(IDCV);
            dtgvTinhLuong.DataSource = danhSachTL;
        }
    }
}
