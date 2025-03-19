using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_HoaDonNhap
    {
        DAL_HoaDonNhap dal_HDN = new DAL_HoaDonNhap();
        DAL_ChiTietHoaDonNhap dal_CTN = new DAL_ChiTietHoaDonNhap();
        public DataTable HienHDN()
        {
            return dal_HDN.HienHDN();
        }
        public DataTable LayHoaDonNhap(string idNhap)
        {
            return dal_HDN.LayHoaDonNhap(idNhap);
        }
        public bool ThemHDN(DTO_HoaDonNhap hdn)
        {
            return dal_HDN.ThemHDN(hdn);
        }
        public bool SuaHDN(DTO_HoaDonNhap hdn)
        {
            return dal_HDN.SuaHDN(hdn);
        }
        public bool XoaHDN(string IDNhap)
        {
            return dal_HDN.XoaHDN(IDNhap);
        }
        public DataTable TimHDN1(DateTime NgayNhap)
        {
            return dal_HDN.TimHDN1(NgayNhap);
        }
        public DataTable TimHDN2(string IDNhacung)
        {
            return dal_HDN.TimHDN2(IDNhacung);
        }
        public float TinhTongTien(string IDNhap)
        {
            return dal_CTN.TinhTongTien(IDNhap);
        }

    }
}
