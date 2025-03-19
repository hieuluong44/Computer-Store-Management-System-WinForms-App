using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL;
using DTO;


namespace BUS
{
    public class BUS_NhanVien
    {
        DAL_NhanVien dalNV = new DAL_NhanVien();
        public DataTable HienNV()
        {
            return dalNV.HienNV();
        }
        public DataTable XacThuc(string IDNhanvien, string SoDienThoai, string IDChucVu, string CCCD)
        {
            return dalNV.XacThuc(IDNhanvien, SoDienThoai, IDChucVu, CCCD);
        }
        public DataTable LayNhanVien(string MaCV)
        {
            return dalNV.LayNhanVien(MaCV);
        }
        public bool ThemNV(DTO_NhanVien nv)
        {
            return dalNV.ThemNV(nv);
        }
        public bool SuaNV(DTO_NhanVien nv)
        {
            return dalNV.SuaNV(nv);
        }
        public bool XoaNV(string IDNhanVien)
        {
            return dalNV.XoaNV(IDNhanVien);
        }
        public DataTable TimNV(string MaNV, string TenNV)
        {
            return dalNV.TimNV(MaNV, TenNV);
        }
        public DataTable TimNV1(string MaCV)
        {
            return dalNV.TimNV1(MaCV);
        }
    }
}
