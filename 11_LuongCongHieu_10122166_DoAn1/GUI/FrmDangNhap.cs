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
using System.Data.SqlClient;

namespace FrmTrangChu.cs
{
    public partial class FrmDangNhap : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        BUS_TaiKhoan taiKhoan = new BUS_TaiKhoan();
        private int dem = 0;
        public FrmDangNhap()
        {
            InitializeComponent();
        }
        private void btnAnHien_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.PasswordChar == '*')
            {
                // Hiện mật khẩu
                txtMatKhau.PasswordChar = '\0';
            }
            else
            {
                // Ẩn mật khẩu
                txtMatKhau.PasswordChar = '*';
            }
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtTaiKhoan.Text;
            string matKhau = txtMatKhau.Text;
            DataTable dt = taiKhoan.LayTK(tenDangNhap, matKhau);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                FrmTrangChu trangChu = new FrmTrangChu();
                trangChu.Show();
            }
            else
            {
                dem++;
                if (dem > 3)
                {
                    MessageBox.Show("Bạn đã đăng nhập sai quá 3 lần. Vui lòng thử lại sau 1 phút.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnDangNhap.Enabled = false;
                    btnThoat.Enabled = false;
                    Timer unlockTimer = new Timer();
                    unlockTimer.Interval = 60000;
                    unlockTimer.Tick += (s, args) =>
                    {
                        btnDangNhap.Enabled = true;
                        btnThoat.Enabled = true;
                        unlockTimer.Stop();
                    };
                    unlockTimer.Start();
                }
                else
                {
                    MessageBox.Show("Đăng nhập không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult DangXuat;
            DangXuat = MessageBox.Show("Bạn chắc chắn muốn đăng xuất?", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DangXuat == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void btnQuenMatKhau_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmQuenMatKhau quenMatKhau = new FrmQuenMatKhau();
            quenMatKhau.ShowDialog();       
        }
    }
}
