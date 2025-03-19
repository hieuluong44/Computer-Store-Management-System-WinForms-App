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
    public partial class FrmQuanLyHangHoa : DevExpress.XtraEditors.XtraUserControl
    {
        private BUS_MatHang bUS_MatHang = new BUS_MatHang();
        private BUS_DanhMuc BUS_DanhMuc = new BUS_DanhMuc();
        private LienKetCombobox LienKetCombobox = new LienKetCombobox();
        public FrmQuanLyHangHoa()
        {
            InitializeComponent();
        }
        private bool ValidateInput()
        {
            return true;
        }
        private string TaoIDMoi()
        {
            // Lấy danh sách ID chức vụ hiện có từ cơ sở dữ liệu
            DataTable dtNhanVien = bUS_MatHang.Hienmn();
            int maxNumber = 0;

            // Duyệt qua danh sách để tìm số lớn nhất
            foreach (DataRow row in dtNhanVien.Rows)
            {
                string id = row["IDMatHang"].ToString();
                // Giả sử ID có dạng "CVxx" với xx là số
                int number;
                if (int.TryParse(id.Replace("MH", ""), out number))
                {
                    if (number > maxNumber)
                        maxNumber = number;
                }
            }
            // Tạo ID mới với số tiếp theo
            maxNumber++; // Tăng lên 1 đơn vị
            return "MH" + maxNumber.ToString("D2"); // Định dạng số với 2 chữ số
        }
        private void FrmQuanLyHangHoa_Load(object sender, EventArgs e)
        {
            dtgvDanhSachMatHang.DataSource = bUS_MatHang.Hienmn();
            LienKetCombobox.LienKet2DuLieu(BUS_DanhMuc.HienDM(), "IDMuc", "TenDanhMuc", txtIDDanhMuc);
            txtIDDanhMuc.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged);

            LienKetCombobox.LienKet2DuLieu(BUS_DanhMuc.HienDM(), "TenDanhMuc", "IDMuc", txtTenDanhMuc);
            txtTenDanhMuc.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged);

            LienKetCombobox.LienKet2DuLieu(BUS_DanhMuc.HienDM(), "IDMuc", "TenDanhMuc", txtMaDM);
            txtMaDM.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged);

            LienKetCombobox.LienKet2DuLieu(BUS_DanhMuc.HienDM(), "TenDanhMuc", "IDMuc", txtTenDM);
            txtTenDM.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged);
        }
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
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTenMH.Text = "";
            txtDonGia.Text = "";
            txtBaoHanh.Text = "";
            txtChiTiet.Text = "";
            dtgvDanhSachMatHang.DataSource = bUS_MatHang.Hienmn();
            LienKetCombobox.LienKet2DuLieu(BUS_DanhMuc.HienDM(), "IDMuc", "TenDanhMuc", txtIDDanhMuc);
            LienKetCombobox.LienKet2DuLieu(BUS_DanhMuc.HienDM(), "TenDanhMuc", "IDMuc", txtTenDanhMuc);
            LienKetCombobox.LienKet2DuLieu(BUS_DanhMuc.HienDM(), "IDMuc", "TenDanhMuc", txtMaDM);
            LienKetCombobox.LienKet2DuLieu(BUS_DanhMuc.HienDM(), "TenDanhMuc", "IDMuc", txtTenDM);
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            int SoLuong;
            string IDMatHang = TaoIDMoi();
            int.TryParse(txtSoLuong.Text, out SoLuong);
            if (ValidateInput())
            {
                // Tạo DTO
                DTO_MatHang mh = new DTO_MatHang(
                    IDMatHang,
                    txtIDDanhMuc.Text,
                    txtTenMH.Text,
                    float.Parse(txtDonGia.Text),
                    txtBaoHanh.Text,
                    ImageToBase64(ptrAnh.Image, System.Drawing.Imaging.ImageFormat.Png),
                    SoLuong,
                    txtChiTiet.Text
                );

                // Thêm
                if (bUS_MatHang.ThemMH(mh))
                {
                    MessageBox.Show("Thêm mặt hàng mới thành công");
                    dtgvDanhSachMatHang.DataSource = bUS_MatHang.Hienmn(); // refresh datagridview
                    txtIDMatHang.Text = TaoIDMoi();
                }
                else
                {
                    MessageBox.Show("Thêm mặt hàng mới không thành công");
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
            int SoLuong;
            string IDMatHang = txtIDMatHang.Text;
            int.TryParse(txtSoLuong.Text, out SoLuong);
            if (MessageBox.Show("Bạn có muốn sửa không?", "Sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (dtgvDanhSachMatHang.SelectedRows.Count > 0 && ValidateInput())
                {
                    // Lấy row hiện tại
                    DataGridViewRow row = dtgvDanhSachMatHang.SelectedRows[0];
                    string ID = row.Cells["IDMatHang"].Value.ToString();

                    // Tạo DTO
                    DTO_MatHang mh = new DTO_MatHang(
                    txtIDMatHang.Text,
                    txtIDDanhMuc.Text,
                    txtTenMH.Text,
                    float.Parse(txtDonGia.Text),
                    txtBaoHanh.Text,
                    ImageToBase64(ptrAnh.Image, System.Drawing.Imaging.ImageFormat.Png),
                    SoLuong,
                    txtChiTiet.Text
                    );

                    // Sửa
                    if (bUS_MatHang.SuaMH(mh))
                    {
                        MessageBox.Show("Cập nhật thông tin mặt hàng thành công");
                        dtgvDanhSachMatHang.DataSource = bUS_MatHang.Hienmn(); // refresh datagridview
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thông tin mặt hàng không thành công");
                        txtIDMatHang.Focus();
                    }
                }
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string IDMatHang = txtIDMatHang.Text; // Lấy ID từ textbox hoặc từ DataGridView
            if (MessageBox.Show("Bạn có thật sự muốn xóa không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                // Gọi phương thức Xóa từ BUS
                if (bUS_MatHang.XoaMH(IDMatHang))
                {
                    MessageBox.Show("Xóa thông tin mặt hàng thành công!");
                    dtgvDanhSachMatHang.DataSource = bUS_MatHang.Hienmn(); // Cập nhật lại danh sách
                }
                else
                {
                    MessageBox.Show("Xóa thông tin mặt hàng thất bại.");
                }
            }
            btnLamMoi_Click(sender, e);
        }

        private void dtgvDanhSachMatHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgvDanhSachMatHang.Rows[e.RowIndex];
                txtIDMatHang.Text = row.Cells["IDMatHang"].Value.ToString();
                txtIDDanhMuc.Text = row.Cells["IDMuc"].Value.ToString();
                txtTenMH.Text = row.Cells["Tenmathang"].Value.ToString();
                txtDonGia.Text = string.Format("{0:N0}", row.Cells["DonGia"].Value);
                txtBaoHanh.Text = row.Cells["BaoHanh"].Value.ToString();
                txtSoLuong.Text = row.Cells["SoLuong"].Value.ToString();
                txtChiTiet.Text = row.Cells["ChiTiet"].Value.ToString();
                if (row.Cells["Anh"].Value != DBNull.Value)
                {
                    byte[] imageBytes = (byte[])row.Cells["Anh"].Value;
                    ptrAnh.Image = Base64ToImage(imageBytes);
                    ptrAnh.SizeMode = PictureBoxSizeMode.Zoom; // Đặt chế độ hiển thị ảnh để fit với kích thước của PictureBox
                }
                else
                {
                    ptrAnh.Image = null; // Nếu không có ảnh, đặt PictureBox thành null
                }
                txtIDMatHang.Focus();
            }
        }
        private void btnShowDanhMuc_Click(object sender, EventArgs e)
        {
            FrmDanhMucMatHang danhMucMatHang = new FrmDanhMucMatHang();
            danhMucMatHang.ShowDialog();
        }
        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Guna2ComboBox ComboBox = sender as Guna2ComboBox;
            if (ComboBox != null && ComboBox.SelectedIndex != -1)
            {
                string maDanhMuc = ((DataRowView)ComboBox.SelectedItem)[ComboBox.ValueMember].ToString();
                if (ComboBox == txtTenDanhMuc)
                {
                    txtIDDanhMuc.Text = maDanhMuc;
                }
                else if (ComboBox == txtIDDanhMuc)
                {
                    txtTenDanhMuc.Text = maDanhMuc;
                }
                else if (ComboBox == txtMaDM)
                {
                    txtTenDM.Text = maDanhMuc;
                }
                else if (ComboBox == txtTenDM)
                {
                    txtMaDM.Text = maDanhMuc;
                }
            }
        }

        private void btnTimbangTen_Click(object sender, EventArgs e)
        {
            string tenMH = txtTim.Text;
            DataTable DanhsachMH = bUS_MatHang.TimbangMH(tenMH);
            dtgvDanhSachMatHang.DataSource = DanhsachMH;
        }

        private void txtTimBangDM_Click(object sender, EventArgs e)
        {
            string maDM = txtMaDM.Text;
            DataTable DanhsachMH = bUS_MatHang.TimbangDM(maDM);
            dtgvDanhSachMatHang.DataSource = DanhsachMH;
        }
    }
}
