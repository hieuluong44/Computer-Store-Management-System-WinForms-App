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


namespace FrmTrangChu.cs
{
    public partial class FrmDanhMucMatHang : Form
    {
        private BUS_DanhMuc BUS_DanhMuc = new BUS_DanhMuc();
        public FrmDanhMucMatHang()
        {
            InitializeComponent();
        }
        private void FrmDanhMucMatHang_Load(object sender, EventArgs e)
        {
            dtgvDanhMuc.DataSource = BUS_DanhMuc.HienDM();
        }
        private bool ValidateInput()
        {
            return true;
        }
        private string TaoIDMoi()
        {
            // Lấy danh sách ID chức vụ hiện có từ cơ sở dữ liệu
            DataTable dtHDB = BUS_DanhMuc.HienDM();
            int maxNumber = 0;
            foreach (DataRow row in dtHDB.Rows)
            {
                string id = row["IDMuc"].ToString();
                // Giả sử ID có dạng "CVxx" với xx là số
                int number;
                if (int.TryParse(id.Replace("DM", ""), out number))
                {
                    if (number > maxNumber)
                        maxNumber = number;
                }
            }
            // Tạo ID mới với số tiếp theo
            maxNumber++; // Tăng lên 1 đơn vị
            return "DM" + maxNumber.ToString("D2"); // Định dạng số với 2 chữ số
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTenDanhMuc.Text = "";
        }
        // Các chức năng
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string IDMuc = TaoIDMoi();
            if (ValidateInput())
            {

                // Tạo DTO
                DTO_DanhMuc dm = new DTO_DanhMuc(
                    IDMuc,
                    txtTenDanhMuc.Text
                );

                // Thêm
                if (BUS_DanhMuc.ThemDM(dm))
                {
                    MessageBox.Show("Thêm danh mục mới thành công");
                    dtgvDanhMuc.DataSource = BUS_DanhMuc.HienDM(); // refresh datagridview
                    txtIDMuc.Text = TaoIDMoi();
                }
                else
                {
                    MessageBox.Show("Thêm danh mục mới không thành công");
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
                if (dtgvDanhMuc.SelectedRows.Count > 0 && ValidateInput())
                {
                    // Lấy row hiện tại
                    DataGridViewRow row = dtgvDanhMuc.SelectedRows[0];
                    string ID = row.Cells["IDMuc"].Value.ToString();

                    // Tạo DTO
                    DTO_DanhMuc dm = new DTO_DanhMuc(
                    txtIDMuc.Text,
                    txtTenDanhMuc.Text
                );

                    // Sửa
                    if (BUS_DanhMuc.SuaDM(dm))
                    {
                        MessageBox.Show("Cập nhật thông tin danh mục thành công");
                        dtgvDanhMuc.DataSource = BUS_DanhMuc.HienDM(); // refresh datagridview
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thông tin danh mục không thành công");
                        txtIDMuc.Focus();
                    }
                }
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string IDMuc = txtIDMuc.Text; // Lấy ID từ textbox hoặc từ DataGridView
            if (MessageBox.Show("Bạn có thật sự muốn xóa không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                // Gọi phương thức Xóa từ BUS
                if (BUS_DanhMuc.XoaDM(IDMuc))
                {
                    MessageBox.Show("Xóa thông tin danh mục thành công!");
                    dtgvDanhMuc.DataSource = BUS_DanhMuc.HienDM(); // Cập nhật lại danh sách
                }
                else
                {
                    MessageBox.Show("Xóa thông tin danh mục thất bại.");
                }
            }
            btnLamMoi_Click(sender, e);
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            string Tim = txtTim.Text.Trim();
            DataTable danhSachDanhMuc = BUS_DanhMuc.TimDM(Tim);
            dtgvDanhMuc.DataSource = danhSachDanhMuc;
        }
        private void dtgvDanhMuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgvDanhMuc.Rows[e.RowIndex];
                txtIDMuc.Text = row.Cells["IDMuc"].Value.ToString();
                txtTenDanhMuc.Text = row.Cells["TenDanhMuc"].Value.ToString();

                txtIDMuc.Focus();
            }
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
    }
}
