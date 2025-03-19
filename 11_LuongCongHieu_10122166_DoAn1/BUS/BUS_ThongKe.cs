using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_ThongKe
    {
        DAL_ThongKe thongke = new DAL_ThongKe();

        public DataTable ThongKeDoanhThu(DateTime fromDate, DateTime toDate)
        {
            return thongke.ThongKeDoanhThu(fromDate, toDate);
        }
        public DataTable HangBanChay(DateTime fromDate, DateTime toDate)
        {
            return thongke.HangBanChay(fromDate, toDate);
        }
        public DataTable HangTonKho()
        {
            return thongke.HangTonKho();
        }
    }
}
