using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_HoaDonBan
    {
        DAL_HoaDonBan dal_HDB = new DAL_HoaDonBan();
        DAL_ChiTietHoaDonBan dal_CTHD = new DAL_ChiTietHoaDonBan();
        public DataTable HienHDB()
        {
            return dal_HDB.HienHDB();
        }
        public DataTable LayHoaDonBan(string idBan)
        {
            return dal_CTHD.LayHoaDonBan(idBan);
        }
        public bool ThemHDB(DTO_HoaDonBan hdb)
        {
            return dal_HDB.ThemHDB(hdb);
        }
        public bool SuaHDB(DTO_HoaDonBan hdb)
        {
            return dal_HDB.SuaHDB(hdb);
        }
        public bool XoaHDB(string IDBan)
        {
            return dal_HDB.XoaHDB(IDBan);
        }
        public DataTable TimHDB1(DateTime NgayBan)
        {
            return dal_HDB.TimHDB1(NgayBan);
        }
        public DataTable TimHDB2(string IDKhach)
        {
            return dal_HDB.TimHDB2(IDKhach);
        }
        public float TinhTongTien(string IDBan)
        {
            return dal_CTHD.TinhTongTien(IDBan);
        }
    }
}
