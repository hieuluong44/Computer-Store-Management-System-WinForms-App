using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_ChiTietHoaDonNhap
    {
        DAL_ChiTietHoaDonNhap dal_CTN = new DAL_ChiTietHoaDonNhap();
        public DataTable HienCTN()
        {
            return dal_CTN.HienCTN();
        }
        public bool ThemCTN(DTO_ChiTietHoaDonNhap ctn)
        {
            return dal_CTN.ThemCTN(ctn);
        }
        public bool SuaCTN(DTO_ChiTietHoaDonNhap ctn)
        {
            return dal_CTN.SuaCTN(ctn);
        }
        public bool XoaCTN(string IDNhap)
        {
            return dal_CTN.XoaCTN(IDNhap);
        }
        public DataTable TimCTN(string CTNhap)
        {
            return dal_CTN.TimCTN(CTNhap);
        }
    }
}
