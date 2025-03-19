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
    public class DAL_HoaDonNhap : Connection_Database
    {
        public DataTable HienHDN()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from HoaDonNhap", Con);
            DataTable dtHDN = new DataTable();
            da.Fill(dtHDN);
            return dtHDN;
        }
        public bool ThemHDN(DTO_HoaDonNhap hdn)
        {
            try
            {
                Con.Open();
                string strThem = "INSERT INTO HoaDonNhap (IDNhap, IDNhacung,IDNhanvien,NgayNhap,TongThanhToan) " +
                                 "VALUES (@IDNhap, @IDNhacung,@IDNhanvien, @NgayNhap,@TongThanhToan)";
                SqlCommand cmd = new SqlCommand(strThem, Con);
                cmd.Parameters.AddWithValue("@IDNhap", hdn.IDNhap1);
                cmd.Parameters.AddWithValue("@IDNhacung", hdn.IDNhacung1);
                cmd.Parameters.AddWithValue("@IDNhanvien", hdn.IDNhanvien1);
                cmd.Parameters.AddWithValue("@NgayNhap", hdn.NgayNhap1);
                cmd.Parameters.AddWithValue("@TongThanhToan", hdn.TongThanhToan1);
                if (cmd.ExecuteNonQuery() > 0)
                { return true; }
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
            finally
            {
                Con.Close();
            }
            return false;
        }

        public DataTable TimHDN2(string iDNhacung)
        {
            string strTim = "SELECT * FROM HoaDonNhap WHERE IDNhacung like @IDNhacung";
            SqlDataAdapter da = new SqlDataAdapter(strTim, Con);
            da.SelectCommand.Parameters.AddWithValue("@IDNhacung", "%" + iDNhacung + "%");
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt; throw new NotImplementedException();
        }

        public DataTable TimHDN1(DateTime ngayNhap)
        {
            string strTim = "SELECT * FROM HoaDonNhap WHERE NgayNhap like @NgayNhap ";
            SqlDataAdapter da = new SqlDataAdapter(strTim, Con);
            da.SelectCommand.Parameters.AddWithValue("@NgayNhap", "%" + ngayNhap + "%");
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt; throw new NotImplementedException();
        }

        public bool SuaHDN(DTO_HoaDonNhap hdn)
        {
            try
            {
                Con.Open();
                string strThem = "Update HoaDonNhap set IDNhacung = @IDNhacung ,IDNhanvien = @IDNhanvien,NgayNhap = @NgayNhap,TongThanhToan = @TongThanhToan where IDNhap = @IDNhap";
                SqlCommand cmd = new SqlCommand(strThem, Con);
                cmd.Parameters.AddWithValue("@IDNhap", hdn.IDNhap1);
                cmd.Parameters.AddWithValue("@IDNhacung", hdn.IDNhacung1);
                cmd.Parameters.AddWithValue("@IDNhanvien", hdn.IDNhanvien1);
                cmd.Parameters.AddWithValue("@NgayNhap", hdn.NgayNhap1);
                cmd.Parameters.AddWithValue("@TongThanhToan", hdn.TongThanhToan1);
                if (cmd.ExecuteNonQuery() > 0)
                { return true; }
            }
            catch (Exception e) { }
            finally
            {
                Con.Close();
            }
            return false;
        }
        public bool XoaHDN(string iDNhap)
        {
            try
            {
                Con.Open();
                // Sửa lỗi trong câu lệnh SQL: sử dụng tham số để tránh lỗi SQL injection
                string strXoa = "DELETE FROM HoaDonNhap WHERE IDNhap = @IDNhap";
                SqlCommand cmd = new SqlCommand(strXoa, Con);
                cmd.Parameters.AddWithValue("@IDNhap", iDNhap);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e) { }
            finally
            {
                Con.Close();

            }
            return false;
        }
        public DataTable LayHoaDonNhap(string idNhap)
        {
            SqlDataAdapter da = new SqlDataAdapter("sp_HienThiPhieuNhap", Con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@IDNhap", idNhap);
            DataTable dtChiTietHDN = new DataTable();
            da.Fill(dtChiTietHDN);
            return dtChiTietHDN;
        }
    }
}
