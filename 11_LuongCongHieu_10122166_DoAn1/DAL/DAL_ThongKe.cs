using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_ThongKe : Connection_Database
    {
        public DataTable ThongKeDoanhThu(DateTime fromDate, DateTime toDate)
        {
            try
            {
                Con.Open();
                using (SqlCommand cmd = new SqlCommand("ThongKeDoanhThu", Con))// using quản lý kết nối với CSDL Con, gặp lỗi sẽ tự đóng kết nối
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@FromDate", fromDate);
                    cmd.Parameters.AddWithValue("@ToDate", toDate);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    return dt;
                }
            }
            finally
            {
                if (Con.State == ConnectionState.Open)
                {
                    Con.Close();
                }
            }
        }

        public DataTable HangBanChay(DateTime fromDate, DateTime toDate)
        {
            try
            {
                Con.Open();
                using (SqlCommand cmd = new SqlCommand("HangBanChay", Con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@FromDate", fromDate);
                    cmd.Parameters.AddWithValue("@ToDate", toDate);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    return dt;
                }
            }
            finally
            {
                if (Con.State == ConnectionState.Open)
                {
                    Con.Close();
                }
            }
        }
        public DataTable HangTonKho()
        {
            try
            {
                Con.Open();
                using (SqlCommand cmd = new SqlCommand("HangTonKho", Con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    return dt;
                }
            }
            finally
            {
                if (Con.State == ConnectionState.Open)
                {
                    Con.Close();
                }
            }
          
        }
    }
}
