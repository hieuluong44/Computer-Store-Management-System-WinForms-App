using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_NhaCungCap
    {
        DAL_NhaCungCap dalNCC = new DAL_NhaCungCap();
        public DataTable HienNCC()
        {
            return dalNCC.HienNCC();
        }
        public DataTable LayNCC(string Nhacung)
        {
            return dalNCC.LayNCC(Nhacung);
        }
        public bool ThemNCC(DTO_NhaCungCap ncc)
        {
            return dalNCC.ThemNCC(ncc);
        }
        public bool SuaNCC(DTO_NhaCungCap ncc)
        {
            return dalNCC.SuaNCC(ncc);
        }
        public bool XoaNCC(string IDNhacung)
        {
            return dalNCC.XoaNCC(IDNhacung);
        }
        public DataTable TimNCC(string TenNhacung,string SoDienThoai)
        {
            return dalNCC.TimNCC(TenNhacung, SoDienThoai);
        }
    }
}
