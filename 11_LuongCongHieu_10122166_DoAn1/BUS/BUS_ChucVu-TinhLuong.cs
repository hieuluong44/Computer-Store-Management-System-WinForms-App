using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_ChucVu
    {
        DAL_ChucVu dalCV = new DAL_ChucVu();
        public DataTable HienCV()
        {
            return dalCV.HienCV();
        }
        public bool ThemCV(DTO_ChucVu cv)
        {
            return dalCV.ThemCV(cv);
        }
        public bool SuaCV(DTO_ChucVu cv)
        {
            return dalCV.SuaCV(cv);
        }
        public bool XoaCV(string IDChucVu)
        {
            return dalCV.XoaCV(IDChucVu);
        }
        public DataTable TimCV(string TenCV)
        {
            return dalCV.TimCV(TenCV);
        }
    }
    public class BUS_TinhLuong
    {
        DAL_TinhLuong dalTL = new DAL_TinhLuong();
        public DataTable HienTL()
        {
            return dalTL.HienTL();
        }
        public bool ThemTL(DTO_TinhLuong tl)
        {
            return dalTL.ThemTL(tl);
        }
        public bool SuaTL(DTO_TinhLuong tl)
        {
            return dalTL.SuaTL(tl);
        }
        public bool XoaTL(string IDTinhLuong)
        {
            return dalTL.XoaTL(IDTinhLuong);
        }
        public DataTable TimTL(string tl)
        {
            return dalTL.TimTL(tl);
        }
        public float tinhLuong(int heSoLuong, float LuongCoBan, float Thuong, float Phat, string IDTinhLuong)
        {
            return dalTL.tinhLuong(heSoLuong, LuongCoBan, Thuong, Phat, IDTinhLuong);
        }

    }
}
