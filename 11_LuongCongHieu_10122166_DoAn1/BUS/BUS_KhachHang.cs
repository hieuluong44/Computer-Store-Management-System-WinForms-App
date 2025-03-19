using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_KhachHang
    {
        DAL_KhachHang dalKH = new DAL_KhachHang();
        public DataTable HienKH()
        {
            return dalKH.HienKH();
        }
        public DataTable LayKhachHang(string Khach)
        {
            return dalKH.LayKhachHang(Khach);
        }
        public bool ThemKH(DTO_KhachHang kh)
        {
            return dalKH.ThemKH(kh);
        }
        public bool SuaKH(DTO_KhachHang kh)
        {
            return dalKH.SuaKH(kh);
        }
        public bool XoaTk(string IDKhach)
        {
            return dalKH.XoaTK(IDKhach);
        }
        public DataTable TimKH(string TenKhach, string SoDienThoai)
        {
            return dalKH.TimKH(TenKhach, SoDienThoai);
        }
    }
}
