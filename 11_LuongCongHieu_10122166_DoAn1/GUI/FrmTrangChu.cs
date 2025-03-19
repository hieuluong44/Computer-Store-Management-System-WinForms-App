using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS;
using DevExpress.XtraEditors;
using DTO;
using System.Threading.Tasks;
using System.IO;
using DevExpress.XtraGrid.Views.Grid;

namespace FrmTrangChu.cs
{
    public partial class FrmTrangChu : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        private BUS_NhanVien nhanVien = new BUS_NhanVien();
        public FrmTrangChu()
        {
            InitializeComponent();
        }
        FrmQuanLyHangHoa quanLyHangHoa;
        FrmQuanLyNhanVien quanlynhanvien;
        FrmQuanLyTaiKhoan quanLyTaiKhoan;
        FrmEmail email;
        FrmQuanLyHoaDonBan QuanLyHoaDonBan;
        FrmQuanLyHoaDonNhap quanLyHoaDonNhap;
        FrmQuanLyChucVu_TinhLuong quanLyChucVu_TinhLuong;
        FrmQuanLyKhachHang quanLyKhachHang;
        FrmQuanLyNhaCungCap nhaCungCap;
        FrmQuanLyThongKeDoanhThu thongKeDoanhThu;
        FrmQuanLyThongKeMatHang thongKeMatHang;
        private void btnQuanLyNhanVien_Click(object sender, EventArgs e)
        {
            if (quanlynhanvien == null)
            {
                quanlynhanvien = new FrmQuanLyNhanVien();
                quanlynhanvien.Dock = DockStyle.Fill;
                FrmShowForm.Controls.Add(quanlynhanvien);
                quanlynhanvien.BringToFront();
            }
            else quanlynhanvien.BringToFront();
        }
        private void btnQuanLyMatHang_Click(object sender, EventArgs e)
        {
            if (quanLyHangHoa == null)
            {
                quanLyHangHoa = new FrmQuanLyHangHoa();
                quanLyHangHoa.Dock = DockStyle.Fill;
                FrmShowForm.Controls.Add(quanLyHangHoa);
                quanLyHangHoa.BringToFront();
            }
            else quanLyHangHoa.BringToFront();
        }
        private void btnHoTro_Click(object sender, EventArgs e)
        {
            if (email == null)
            {
                email = new FrmEmail();
                email.Dock = DockStyle.Fill;
                FrmShowForm.Controls.Add(email);
                email.BringToFront();
            }
            else email.BringToFront();
        }
        private void btnHoaDonBan_Click(object sender, EventArgs e)
        {
            if (QuanLyHoaDonBan == null)
            {
                QuanLyHoaDonBan = new FrmQuanLyHoaDonBan();
                QuanLyHoaDonBan.Dock = DockStyle.Fill;
                FrmShowForm.Controls.Add(QuanLyHoaDonBan);
                QuanLyHoaDonBan.BringToFront();
            }
            else QuanLyHoaDonBan.BringToFront();
        }
        private void btnChucVuLuong_Click(object sender, EventArgs e)
        {
            if (quanLyChucVu_TinhLuong == null)
            {
                quanLyChucVu_TinhLuong = new FrmQuanLyChucVu_TinhLuong();
                quanLyChucVu_TinhLuong.Dock = DockStyle.Fill;
                FrmShowForm.Controls.Add(quanLyChucVu_TinhLuong);
                quanLyChucVu_TinhLuong.BringToFront();
            }
            else quanLyChucVu_TinhLuong.BringToFront();
        }
        private void btnQuanLyKhachHang_Click(object sender, EventArgs e)
        {
            if (quanLyKhachHang == null)
            {
                quanLyKhachHang = new FrmQuanLyKhachHang();
                quanLyKhachHang.Dock = DockStyle.Fill;
                FrmShowForm.Controls.Add(quanLyKhachHang);
                quanLyKhachHang.BringToFront();
            }
            else quanLyKhachHang.BringToFront();
        }
        private void btnQuanLyNhaCung_Click(object sender, EventArgs e)
        {
            if (nhaCungCap == null)
            {
                nhaCungCap = new FrmQuanLyNhaCungCap();
                nhaCungCap.Dock = DockStyle.Fill;
                FrmShowForm.Controls.Add(nhaCungCap);
                nhaCungCap.BringToFront();
            }
            else nhaCungCap.BringToFront();
        }
        private void btnHoaDonNhap_Click(object sender, EventArgs e)
        {
            if (quanLyHoaDonNhap == null)
            {
                quanLyHoaDonNhap = new FrmQuanLyHoaDonNhap();

                FrmShowForm.Controls.Add(quanLyHoaDonNhap);
                quanLyHoaDonNhap.BringToFront();
            }
            else quanLyHoaDonNhap.BringToFront();
        }
        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            if (quanLyTaiKhoan == null)
            {
                quanLyTaiKhoan = new FrmQuanLyTaiKhoan();
                quanLyTaiKhoan.Dock = DockStyle.Fill;
                FrmShowForm.Controls.Add(quanLyTaiKhoan);
                quanLyTaiKhoan.BringToFront();
            }
            else quanLyTaiKhoan.BringToFront();
        }
        private void btnThongKeDoanhThu_Click(object sender, EventArgs e)
        {
            if (thongKeDoanhThu == null)
            {
                thongKeDoanhThu = new FrmQuanLyThongKeDoanhThu();
                thongKeDoanhThu.Dock = DockStyle.Fill;
                FrmShowForm.Controls.Add(thongKeDoanhThu);
                thongKeDoanhThu.BringToFront();
            }
            else thongKeDoanhThu.BringToFront();
        }
        private void btnThongKeMatHang_Click(object sender, EventArgs e)
        {
            if (thongKeMatHang == null)
            {
                thongKeMatHang = new FrmQuanLyThongKeMatHang();
                thongKeMatHang.Dock = DockStyle.Fill;
                FrmShowForm.Controls.Add(thongKeMatHang);
                thongKeMatHang.BringToFront();
            }
            else thongKeMatHang.BringToFront();
        }
        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            if (show == null)
            {
                show.Dock = DockStyle.Fill;
                FrmShowForm.Controls.Add(show);
                show.BringToFront();
            }
            else show.BringToFront();
        }
        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult DangXuat;
            DangXuat = MessageBox.Show("Bạn chắc chắn muốn đăng xuất?", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DangXuat == DialogResult.Yes)
            {
                this.Close();
                FrmDangNhap login = new FrmDangNhap();
                login.Show();
            }

        }
    }
}
