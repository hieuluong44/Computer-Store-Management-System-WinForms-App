using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL;
using DTO;


namespace BUS
{
    public class BUS_MatHang
    {
        DAL_MatHang dalMH = new DAL_MatHang();
        public DataTable Hienmn()
        {
            return dalMH.HienMH();
        }
        public DataTable LayMatHang(string IDMatHang)
        {
            return dalMH.LayMatHang(IDMatHang);
        }
        public bool ThemMH(DTO_MatHang mh)
        {
            return dalMH.ThemMH(mh);
        }
        public bool SuaMH(DTO_MatHang mh)
        {
            return dalMH.SuaMH(mh);
        }
        public bool XoaMH(string IDMatHang)
        {
            return dalMH.XoaMH(IDMatHang);
        }
        public bool TangSoLuongMatHang(string maMatHang, int soLuong)
        {
            return dalMH.TangSoLuongMatHang(maMatHang, soLuong);
        }
        public bool GiamSoLuongMatHang(string maMatHang, int soLuong)
        {
            return dalMH.GiamSoLuongMatHang(maMatHang, soLuong);
        }
        public DataTable TimbangDM(string maDM)
        {
            return dalMH.TimbangDM(maDM);
        }
        public DataTable TimbangMH(string TenMH)
        {
            return dalMH.TimbangMH(TenMH);
        }
    }
}
