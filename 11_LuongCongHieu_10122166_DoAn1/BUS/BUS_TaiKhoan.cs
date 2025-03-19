using DAL;
using DTO;
using System;
using System.Data;
using System.Security.Cryptography;
using System.Text;

namespace BUS
{
    public class BUS_TaiKhoan
    {
        DAL_TaiKhoan dalTK = new DAL_TaiKhoan();
        public bool DoiMatKhau(string TenDangNhap, string newPassword)
        {
            return dalTK.DoiMatKhau(TenDangNhap, newPassword);
        }
        public DataTable HienTK()
        {
            return dalTK.HienTK();
        }
        public bool ThemTK(DTO_TaiKhoan tk)
        {
            return dalTK.ThemTK(tk);
        }
        public bool SuaTK(DTO_TaiKhoan tk)
        {
            return dalTK.SuaTK(tk);
        }
        public bool XoaTk(string TenDangNhap)
        {
            return dalTK.XoaTK(TenDangNhap);
        }
        public DataTable LayTK(string TenDangNhap, string MatKhau)
        {
            return dalTK.LayTK(TenDangNhap, MatKhau);
        }
        public DataTable TimTKbangCV(string maCV)
        {
            return dalTK.TimTKbangCV(maCV);
        }
        public DataTable TimTKbangNV(string maNV)
        {
            return dalTK.TimTKbangNV(maNV);
        }
    }
}
