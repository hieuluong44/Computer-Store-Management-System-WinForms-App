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
    public partial class FrmQuanLyKhachHang : DevExpress.XtraEditors.XtraUserControl
    {
        private BUS_KhachHang bUS_Khach = new BUS_KhachHang();
        public FrmQuanLyKhachHang()
        {
            InitializeComponent();
        }
        private void FrmQuanLyKhachHang_Load(object sender, EventArgs e)
        {
            dtgvDanhSachKhachHang.DataSource = bUS_Khach.HienKH();
        }
        private bool ValidateInput()
        {
            return true;
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            foreach(Control cr in this.groupBox1.Controls)
            {
                if(cr is TextBox || cr is System.Windows.Forms.ComboBox)
                {
                    cr.Text = "";
                    txtIDKhach.Text = "KH01";
                }
            }
            dtgvDanhSachKhachHang.DataSource = bUS_Khach.HienKH();
        }
        private string TaoIDMoi()
        {
            // Lấy danh sách ID chức vụ hiện có từ cơ sở dữ liệu
            DataTable dtKh = bUS_Khach.HienKH();
            int maxNumber = 0;
            foreach (DataRow row in dtKh.Rows)
            {
                string id = row["IDKhach"].ToString();
                // Giả sử ID có dạng "CVxx" với xx là số
                int number;
                if (int.TryParse(id.Replace("KH", ""), out number))
                {
                    if (number > maxNumber)
                        maxNumber = number;
                }
            }

            // Tạo ID mới với số tiếp theo
            maxNumber++; // Tăng lên 1 đơn vị
            return "KH" + maxNumber.ToString("D2"); // Định dạng số với 2 chữ số
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string IDKH = TaoIDMoi();
            if (ValidateInput())
            {

                // Tạo DTO
                DTO_KhachHang kh = new DTO_KhachHang(
                    IDKH,
                    txtTenKhach.Text,
                    txtGioiTinh.Text,
                    txtSoDienThoai.Text,
                    txtCCCD.Text,
                    txtEmail.Text,
                    txtDiaChi.Text
                );

                // Thêm
                if (bUS_Khach.ThemKH(kh))
                {
                    MessageBox.Show("Thêm khách hàng mới thành công");
                    dtgvDanhSachKhachHang.DataSource = bUS_Khach.HienKH(); // refresh datagridview
                    txtIDKhach.Text = TaoIDMoi();
                }
                else
                {
                    MessageBox.Show("Thêm khách hàng mới không thành công");
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
                if (dtgvDanhSachKhachHang.SelectedRows.Count > 0 && ValidateInput())
                {
                    // Lấy row hiện tại
                    DataGridViewRow row = dtgvDanhSachKhachHang.SelectedRows[0];
                    string ID = row.Cells["IDKhach1"].Value.ToString();

                    // Tạo DTO
                    DTO_KhachHang kh = new DTO_KhachHang(
                     txtIDKhach.Text,
                     txtTenKhach.Text,
                     txtGioiTinh.Text,
                     txtSoDienThoai.Text,
                     txtCCCD.Text,
                     txtEmail.Text,
                     txtDiaChi.Text);

                    // Sửa
                    if (bUS_Khach.SuaKH(kh))
                    {
                        MessageBox.Show("Cập nhật thông tin khách hàng thành công");
                        dtgvDanhSachKhachHang.DataSource = bUS_Khach.HienKH(); // refresh datagridview
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thông tin khách hàng không thành công");
                        txtIDKhach.Focus();
                    }
                }
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string idKhach = txtIDKhach.Text; // Lấy ID từ textbox hoặc từ DataGridView
            if (MessageBox.Show("Bạn có thật sự muốn xóa không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                // Gọi phương thức Xóa từ BUS
                if (bUS_Khach.XoaTk(idKhach))
                {
                    MessageBox.Show("Xóa thông tin khách hàng thành công!");
                    dtgvDanhSachKhachHang.DataSource = bUS_Khach.HienKH(); // Cập nhật lại danh sách
                }
                else
                {
                    MessageBox.Show("Xóa thông tin khách hàng thất bại.");
                }
            }
            btnLamMoi_Click(sender, e);
        }
        private void dtgvDanhSachKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Điền thông tin vào các textbox khi click vào một cell trong DataGridView
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgvDanhSachKhachHang.Rows[e.RowIndex];
                txtIDKhach.Text = row.Cells["IDKhach1"].Value.ToString();
                txtTenKhach.Text = row.Cells["TenKhach1"].Value.ToString();
                txtGioiTinh.Text = row.Cells["GioiTinh1"].Value.ToString();
                txtSoDienThoai.Text = row.Cells["SoDienThoai1"].Value.ToString();
                txtCCCD.Text = row.Cells["CCCD1"].Value.ToString();
                txtEmail.Text = row.Cells["Email1"].Value.ToString();
                txtDiaChi.Text = row.Cells["DiaChi1"].Value.ToString();
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string TenKH = txtTim.Text.Trim();
            string SDT = txtTim.Text.Trim();
            DataTable danhSachKH = bUS_Khach.TimKH(TenKH,SDT);
            dtgvDanhSachKhachHang.DataSource = danhSachKH;
        }
    }
}
