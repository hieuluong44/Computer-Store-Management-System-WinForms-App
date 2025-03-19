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
    public class DAL_HoaDonBan : Connection_Database
    {
        public DataTable HienHDB()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from HoaDonBan", Con);
            DataTable dtHDB = new DataTable();
            da.Fill(dtHDB);
            return dtHDB;
        }

       
        public bool ThemHDB(DTO_HoaDonBan hdb)
        {
            try
            {
                Con.Open();
                string strThem = "INSERT INTO HoaDonBan (IDBan, IDKhach,IDNhanvien,NgayBan,TongTien) " +
                                 "VALUES (@IDBan, @IDKhach,@IDNhanvien, @NgayBan,@TongTien)";
                SqlCommand cmd = new SqlCommand(strThem, Con);
                cmd.Parameters.AddWithValue("@IDBan", hdb.IDBan1);
                cmd.Parameters.AddWithValue("@IDKhach", hdb.IDKhach1);
                cmd.Parameters.AddWithValue("@IDNhanvien", hdb.IDNhanvien1);
                cmd.Parameters.AddWithValue("@NgayBan", hdb.NgayBan1);
                cmd.Parameters.AddWithValue("@TongTien", hdb.TongTien1);
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

        public DataTable TimHDB2(string iDKhach)
        {
            string strTim = "SELECT * FROM HoaDonBan WHERE IDKhach like @IDKhach";
            SqlDataAdapter da = new SqlDataAdapter(strTim, Con);
            da.SelectCommand.Parameters.AddWithValue("@IDKhach", "%" + iDKhach + "%");
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt; throw new NotImplementedException();
        }

        public DataTable TimHDB1(DateTime ngayBan)
        {
            string strTim = "SELECT * FROM HoaDonBan WHERE NgayBan like @NgayBan";
            SqlDataAdapter da = new SqlDataAdapter(strTim, Con);
            da.SelectCommand.Parameters.AddWithValue("@NgayBan", "%" + ngayBan + "%");
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt; throw new NotImplementedException();
        }

        public bool SuaHDB(DTO_HoaDonBan hdb)
        {
            try
            {
                Con.Open();
                string strThem = "Update HoaDonBan set IDKhach = @IDKhach ,IDNhanvien = @IDNhanvien,NgayBan = @NgayBan,TongTien = @TongTien where IDBan = @IDBan";
                SqlCommand cmd = new SqlCommand(strThem, Con);
                cmd.Parameters.AddWithValue("@IDBan", hdb.IDBan1);
                cmd.Parameters.AddWithValue("@IDKhach", hdb.IDKhach1);
                cmd.Parameters.AddWithValue("@IDNhanvien", hdb.IDNhanvien1);
                cmd.Parameters.AddWithValue("@NgayBan", hdb.NgayBan1);
                cmd.Parameters.AddWithValue("@TongTien", hdb.TongTien1);
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

        public bool XoaHDB(string iDBan)
        {
            try
            {
                Con.Open();
                // Sửa lỗi trong câu lệnh SQL: sử dụng tham số để tránh lỗi SQL injection
                string strXoa = "DELETE FROM HoaDonBan WHERE IDBan = @IDBan";
                SqlCommand cmd = new SqlCommand(strXoa, Con);
                cmd.Parameters.AddWithValue("@IDBan", iDBan);
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
    }
}
