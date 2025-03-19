using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_ChiTietHoaDonBan
    {
        DAL_ChiTietHoaDonBan dal_CTHD = new DAL_ChiTietHoaDonBan();
        public DataTable HienCT()
        {
            return dal_CTHD.HienCT();
        }
        public bool ThemCT(DTO_ChiTietHoaDonBan cthd)
        {
            return dal_CTHD.ThemCT(cthd);
        }
        public bool SuaCT(DTO_ChiTietHoaDonBan cthd)
        {
            return dal_CTHD.SuaCT(cthd);
        }
        public bool XoaCT(string IDChitietBan)
        {
            return dal_CTHD.XoaCT(IDChitietBan);
        }
        public DataTable TimCT(string IDBan)
        {
            return dal_CTHD.TimCT(IDBan);
        }
    }
}
