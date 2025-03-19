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
    public partial class FrmQuanLyNhanVien : DevExpress.XtraEditors.XtraUserControl
    {
        private BUS_NhanVien BUS_NhanVien = new BUS_NhanVien();
        private BUS_ChucVu BUS_ChucVu = new BUS_ChucVu();
        private LienKetCombobox LienKetCombobox = new LienKetCombobox();
        public FrmQuanLyNhanVien()
        {
            InitializeComponent();
        }
        private bool ValidateInput()
        {
            return true;
        }
        private void FrmQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            dtgvDanhSachNhanVien.DataSource = BUS_NhanVien.HienNV();
            LienKetCombobox.LienKet2DuLieu(BUS_ChucVu.HienCV(), "ChucVu", "IDChucVu", txtTenChucVu);
            txtTenChucVu.SelectedIndexChanged += new EventHandler(ChucVu_SelectedIndexChanged);
            LienKetCombobox.LienKet2DuLieu(BUS_ChucVu.HienCV(), "IDChucVu", "ChucVu", txtIDChucVu);
            txtIDChucVu.SelectedIndexChanged += new EventHandler(ChucVu_SelectedIndexChanged);


            LienKetCombobox.LienKet2DuLieu(BUS_ChucVu.HienCV(), "ChucVu", "IDChucVu", txtTenChucVu1);
            txtTenChucVu1.SelectedIndexChanged += new EventHandler(ChucVu_SelectedIndexChanged);
            LienKetCombobox.LienKet2DuLieu(BUS_ChucVu.HienCV(), "IDChucVu", "ChucVu", txtMaChucVu1);
            txtMaChucVu1.SelectedIndexChanged += new EventHandler(ChucVu_SelectedIndexChanged);
        }
        // Thêm ảnh
        private void btnAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Picture file (.png,.jpg)|*.png;*.jpg";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                ptrAnh.Image = Image.FromFile(openFile.FileName);
                ptrAnh.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
        public byte[] ImageToBase64(Image image, System.Drawing.Imaging.ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, format);
                byte[] imageBytes = ms.ToArray();
                return imageBytes;
            }
        }
        public Image Base64ToImage(byte[] imageBytes)
        {
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }
        //--------------------------------------------------------------------
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTenNhanVien.Text = "";
            ptrAnh.Image = null;
            foreach (Control cr in this.groupBox3.Controls)
            {
                if (cr is TextBox || cr is DateEdit || cr is System.Windows.Forms.ComboBox)
                {
                    cr.Text = "";
                }
            }
            dtgvDanhSachNhanVien.DataSource = BUS_NhanVien.HienNV();
            LienKetCombobox.LienKet2DuLieu(BUS_ChucVu.HienCV(), "ChucVu", "IDChucVu", txtTenChucVu);
            LienKetCombobox.LienKet2DuLieu(BUS_ChucVu.HienCV(), "IDChucVu", "ChucVu", txtIDChucVu);
            LienKetCombobox.LienKet2DuLieu(BUS_ChucVu.HienCV(), "ChucVu", "IDChucVu", txtTenChucVu1);
            LienKetCombobox.LienKet2DuLieu(BUS_ChucVu.HienCV(), "IDChucVu", "ChucVu", txtMaChucVu1);
        }
        private string TaoIDMoi()
        {
            // Lấy danh sách ID chức vụ hiện có từ cơ sở dữ liệu
            DataTable dtNhanVien = BUS_NhanVien.HienNV();
            int maxNumber = 0;

            // Duyệt qua danh sách để tìm số lớn nhất
            foreach (DataRow row in dtNhanVien.Rows)
            {
                string id = row["IDNhanVien"].ToString();
                // Giả sử ID có dạng "CVxx" với xx là số
                int number;
                if (int.TryParse(id.Replace("NV", ""), out number))
                {
                    if (number > maxNumber)
                        maxNumber = number;
                }
            }
            // Tạo ID mới với số tiếp theo
            maxNumber++; // Tăng lên 1 đơn vị
            return "NV" + maxNumber.ToString("D2"); // Định dạng số với 2 chữ số
        }
        //Các chức năng
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string IDNhanVien = txtIDNhanVien.Text;
            if (ValidateInput())
            {
                // Tạo DTO
                DTO_NhanVien nv = new DTO_NhanVien(
                    IDNhanVien,
                    txtIDChucVu.Text,
                    txtTenNhanVien.Text,
                    txtGioiTinh.Text,
                    txtEmail.Text,
                    Convert.ToDateTime(txtNgaySinh.Text),
                    txtSoDienThoai.Text,
                    txtCCCD.Text,
                    txtDiaChi.Text,
                    ImageToBase64(ptrAnh.Image, System.Drawing.Imaging.ImageFormat.Png)
                );
                // Thêm
                if (BUS_NhanVien.ThemNV(nv))
                {
                    MessageBox.Show("Thêm nhân viên thành công");
                    dtgvDanhSachNhanVien.DataSource = BUS_NhanVien.HienNV(); // refresh datagridview
                    txtIDNhanVien.Text = TaoIDMoi();
                }
                else
                {
                    MessageBox.Show("Thêm nhân viên không thành công");
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
                if (dtgvDanhSachNhanVien.SelectedRows.Count > 0 && ValidateInput())
                {
                    // Lấy row hiện tại
                    DataGridViewRow row = dtgvDanhSachNhanVien.SelectedRows[0];
                    string ID = row.Cells["IDNhanVien1"].Value.ToString();

                    // Tạo DTO
                    DTO_NhanVien nv = new DTO_NhanVien(
                        txtIDNhanVien.Text,
                        txtIDChucVu.Text,
                        txtTenNhanVien.Text,
                        txtGioiTinh.Text,
                        txtEmail.Text,
                        Convert.ToDateTime(txtNgaySinh.Text),
                        txtSoDienThoai.Text,
                        txtCCCD.Text,
                        txtDiaChi.Text,
                        ImageToBase64(ptrAnh.Image, System.Drawing.Imaging.ImageFormat.Png)
                    );

                    // Sửa
                    if (BUS_NhanVien.SuaNV(nv))
                    {
                        MessageBox.Show("Cập nhật thông tin nhân viên thành công");
                        dtgvDanhSachNhanVien.DataSource = BUS_NhanVien.HienNV(); // refresh datagridview
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thông tin nhân viên không thành công");
                        txtIDNhanVien.Focus();
                    }
                }
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string idNhanVien = txtIDNhanVien.Text; // Lấy ID từ textbox hoặc từ DataGridView
            if (MessageBox.Show("Bạn có thật sự muốn xóa không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                // Gọi phương thức Xóa từ BUS
                if (BUS_NhanVien.XoaNV(idNhanVien))
                {
                    MessageBox.Show("Xóa thông tin nhân viên thành công!");
                    dtgvDanhSachNhanVien.DataSource = BUS_NhanVien.HienNV(); // Cập nhật lại danh sách
                }
                else
                {
                    MessageBox.Show("Xóa thông tin nhân viên thất bại.");
                }
            }
            btnLamMoi_Click(sender, e);
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            string TenNV = txtTim.Text.Trim();
            string maNV = txtTim.Text.Trim();
            DataTable danhSachNV = BUS_NhanVien.TimNV(maNV, TenNV);
            dtgvDanhSachNhanVien.DataSource = danhSachNV;
        }
        private void txtTimBangCV_Click(object sender, EventArgs e)
        {
            string MaCV = txtMaChucVu1.Text.Trim();
            DataTable danhSachNV = BUS_NhanVien.TimNV1(MaCV);
            dtgvDanhSachNhanVien.DataSource = danhSachNV;
        }
        private void dtgvDanhSachNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Điền thông tin vào các textbox khi click vào một cell trong DataGridView
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgvDanhSachNhanVien.Rows[e.RowIndex];
                txtIDNhanVien.Text = row.Cells["IDNhanVien1"].Value.ToString();
                txtIDChucVu.Text = row.Cells["IDChucVu1"].Value.ToString();
                txtTenNhanVien.Text = row.Cells["TenNhanVien1"].Value.ToString();
                txtGioiTinh.Text = row.Cells["GioiTinh1"].Value.ToString();
                txtEmail.Text = row.Cells["Email1"].Value.ToString();
                txtNgaySinh.Text = row.Cells["NgaySinh1"].Value.ToString();
                txtSoDienThoai.Text = row.Cells["SoDienThoai1"].Value.ToString();
                txtCCCD.Text = row.Cells["CCCD1"].Value.ToString();
                txtDiaChi.Text = row.Cells["DiaChi1"].Value.ToString();
                if (row.Cells["Anh1"].Value != DBNull.Value)
                {
                    byte[] imageBytes = (byte[])row.Cells["Anh1"].Value;
                    ptrAnh.Image = Base64ToImage(imageBytes);
                    ptrAnh.SizeMode = PictureBoxSizeMode.Zoom; // Đặt chế độ hiển thị ảnh để fit với kích thước của PictureBox
                }
                else
                {
                    ptrAnh.Image = null; // Nếu không có ảnh, đặt PictureBox thành null
                }
                txtIDNhanVien.Focus();
            }
        }
        private void ChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            Guna2ComboBox ComboBox = sender as Guna2ComboBox;
            if (ComboBox != null && ComboBox.SelectedIndex != -1)
            {
                string maChucVu = ((DataRowView)ComboBox.SelectedItem)[ComboBox.ValueMember].ToString();
                if (ComboBox == txtIDChucVu)
                {
                    txtTenChucVu.Text = maChucVu;
                }
                else if (ComboBox == txtTenChucVu)
                {
                    txtIDChucVu.Text = maChucVu;
                }
                if (ComboBox == txtMaChucVu1)
                {
                    txtTenChucVu1.Text = maChucVu;
                }
                else if (ComboBox == txtTenChucVu1)
                {
                    txtMaChucVu1.Text = maChucVu;
                }
            }
        }
    }
}
