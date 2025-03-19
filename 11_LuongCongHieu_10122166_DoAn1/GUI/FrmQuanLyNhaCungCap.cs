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
    public partial class FrmQuanLyNhaCungCap : DevExpress.XtraEditors.XtraUserControl
    {
        private BUS_NhaCungCap bUS_NhaCungCap = new BUS_NhaCungCap();
        public FrmQuanLyNhaCungCap()
        {
            InitializeComponent();
        }
        private void FrmQuanLyNhaCungCap_Load(object sender, EventArgs e)
        {
            dtgvDanhSachNhaCung.DataSource = bUS_NhaCungCap.HienNCC();
        }
        private bool ValidateInput()
        {
            return true;
        }
        private string TaoIDMoi()
        {
            // Lấy danh sách ID chức vụ hiện có từ cơ sở dữ liệu
            DataTable dtNCC = bUS_NhaCungCap.HienNCC();
            int maxNumber = 0;
            foreach (DataRow row in dtNCC.Rows)
            {
                string id = row["IDNhacung"].ToString();
                // Giả sử ID có dạng "CVxx" với xx là số
                int number;
                if (int.TryParse(id.Replace("NCC", ""), out number))
                {
                    if (number > maxNumber)
                        maxNumber = number;
                }
            }
            // Tạo ID mới với số tiếp theo
            maxNumber++; // Tăng lên 1 đơn vị
            return "NCC" + maxNumber.ToString("D2"); // Định dạng số với 2 chữ số
        }

        // Các chức năng
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            foreach (Control cr in this.groupBox1.Controls)
            {
                if (cr is TextBox || cr is System.Windows.Forms.ComboBox)
                {
                    cr.Text = "";
                    txtIDNCC.Text = "NCC01";
                }
            }
            dtgvDanhSachNhaCung.DataSource = bUS_NhaCungCap.HienNCC();
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            string TenNCC = txtTim.Text.Trim();
            string SDT = txtTim.Text.Trim();
            DataTable danhSachNCC = bUS_NhaCungCap.TimNCC(TenNCC, SDT);
            dtgvDanhSachNhaCung.DataSource = danhSachNCC;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string IDNCC = TaoIDMoi();
            if (ValidateInput())
            {
                // Tạo DTO
                DTO_NhaCungCap ncc = new DTO_NhaCungCap(
                    IDNCC,
                    txtTenNCC.Text,
                    txtDiaChi.Text,
                    txtEmail.Text,
                    txtSoDienThoai.Text
                );

                // Thêm
                if (bUS_NhaCungCap.ThemNCC(ncc))
                {
                    MessageBox.Show("Thêm nhà cung cấp mới thành công");
                    dtgvDanhSachNhaCung.DataSource = bUS_NhaCungCap.HienNCC(); // refresh datagridview
                }
                else
                {
                    MessageBox.Show("Thêm nhà cung cấp mới không thành công");
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
                if (dtgvDanhSachNhaCung.SelectedRows.Count > 0 && ValidateInput())
                {
                    // Lấy row hiện tại
                    DataGridViewRow row = dtgvDanhSachNhaCung.SelectedRows[0];
                    string ID = row.Cells["IDNhacung1"].Value.ToString();

                    // Tạo DTO
                    DTO_NhaCungCap ncc = new DTO_NhaCungCap(
                   txtIDNCC.Text,
                   txtTenNCC.Text,
                   txtDiaChi.Text,
                   txtEmail.Text,
                   txtSoDienThoai.Text);

                    // Sửa
                    if (bUS_NhaCungCap.SuaNCC(ncc))
                    {
                        MessageBox.Show("Cập nhật thông tin nhà cung cấp thành công");
                        dtgvDanhSachNhaCung.DataSource = bUS_NhaCungCap.HienNCC(); // refresh datagridview
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thông tin nhà cung cấp không thành công");
                        txtIDNCC.Focus();
                    }
                }
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string idNCC = txtIDNCC.Text; // Lấy ID từ textbox hoặc từ DataGridView
            if (MessageBox.Show("Bạn có thật sự muốn xóa không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                // Gọi phương thức Xóa từ BUS
                if (bUS_NhaCungCap.XoaNCC(idNCC))
                {
                    MessageBox.Show("Xóa thông tin nhà cung cấp thành công!");
                    dtgvDanhSachNhaCung.DataSource = bUS_NhaCungCap.HienNCC(); // Cập nhật lại danh sách
                }
                else
                {
                    MessageBox.Show("Xóa thông tin nhà cung cấp thất bại.");
                }
            }
            btnLamMoi_Click(sender, e);
        }
        private void dtgvDanhSachNhaCung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgvDanhSachNhaCung.Rows[e.RowIndex];
                txtIDNCC.Text = row.Cells["IDNhacung1"].Value.ToString();
                txtTenNCC.Text = row.Cells["TenNhacung1"].Value.ToString();
                txtDiaChi.Text = row.Cells["DiaChi1"].Value.ToString();
                txtEmail.Text = row.Cells["Email1"].Value.ToString();
                txtSoDienThoai.Text = row.Cells["SoDienThoai1"].Value.ToString();
            }
        }
    }
}
