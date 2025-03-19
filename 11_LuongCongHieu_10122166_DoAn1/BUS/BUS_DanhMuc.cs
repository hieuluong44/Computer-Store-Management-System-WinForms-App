using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_DanhMuc
    {
        DAL_DanhMuc dal_DM = new DAL_DanhMuc();
        public DataTable HienDM()
        {
            return dal_DM.HienDM();
        }
        public bool ThemDM(DTO_DanhMuc dm)
        {
            return dal_DM.ThemDM(dm);
        }
        public bool SuaDM(DTO_DanhMuc dm)
        {
            return dal_DM.SuaDM(dm);
        }
        public bool XoaDM(string IDMuc)
        {
            return dal_DM.XoaDM(IDMuc);
        }
        public DataTable TimDM(string TenDanhMuc)
        {
            return dal_DM.TimDM(TenDanhMuc);
        }
    }
}
