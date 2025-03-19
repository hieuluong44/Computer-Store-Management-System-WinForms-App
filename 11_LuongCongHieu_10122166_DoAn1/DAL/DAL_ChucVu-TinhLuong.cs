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
    public class DAL_ChucVu : Connection_Database
    {
        public DataTable HienCV()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from HeSoChucVu", Con);
            DataTable dtChucVu = new DataTable();
            da.Fill(dtChucVu);
            return dtChucVu;
        }
        public bool ThemCV(DTO_ChucVu cv)
        {
            try
            {
                // Ensure the connection is closed before trying to open it
                if (Con.State == System.Data.ConnectionState.Open)
                {
                    Con.Close();
                }

                Con.Open();
                string strThem = "INSERT INTO HeSoChucVu (IDChucVu, ChucVu, HeSoLuong) " +
                                 "VALUES (@IDChucVu, @ChucVu, @HeSoLuong)";
                SqlCommand cmd = new SqlCommand(strThem, Con);
                cmd.Parameters.AddWithValue("@IDChucVu", cv.IDChucVu1.Trim());
                cmd.Parameters.AddWithValue("@ChucVu", cv.ChucVu1.Trim());
                cmd.Parameters.AddWithValue("@HeSoLuong", cv.HeSoLuong1);
                return cmd.ExecuteNonQuery() > 0;
            }
            finally
            {
                Con.Close();
            }
        }
        public bool SuaCV(DTO_ChucVu cv)
        {
            try
            {
                // Ensure the connection is closed before trying to open it
                if (Con.State == System.Data.ConnectionState.Open)
                {
                    Con.Close();
                }

                Con.Open();
                string strThem = "Update HeSoChucVu set ChucVu = @ChucVu, HeSoLuong = @HeSoLuong where IDChucVu = @IDChucVu";
                SqlCommand cmd = new SqlCommand(strThem, Con);
                cmd.Parameters.AddWithValue("@IDChucVu", cv.IDChucVu1.Trim());
                cmd.Parameters.AddWithValue("@ChucVu", cv.ChucVu1.Trim());
                cmd.Parameters.AddWithValue("@HeSoLuong", cv.HeSoLuong1);
                return cmd.ExecuteNonQuery() > 0;
            }
            finally
            {
                Con.Close();
            }
        }

        public bool XoaCV(string iDChucVu)
        {
            // Ensure the connection is closed before trying to open it
            if (Con.State == System.Data.ConnectionState.Open)
            {
                Con.Close();
            }

            Con.Open();
            string strXoa = "DELETE FROM HeSoChucVu WHERE IDChucVu = @IDChucVu";
            SqlCommand cmd = new SqlCommand(strXoa, Con);
            cmd.Parameters.AddWithValue("@IDChucVu", iDChucVu.Trim());

            bool result = cmd.ExecuteNonQuery() > 0;
            Con.Close();
            return result;
        }

        public DataTable TimCV(string cv)
        {
            string strTim = "SELECT * FROM HeSoChucVu WHERE ChucVu like @ChucVu";
            SqlDataAdapter da = new SqlDataAdapter(strTim, Con);
            da.SelectCommand.Parameters.AddWithValue("@ChucVu", "%" + cv + "%");
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
    public class DAL_TinhLuong : Connection_Database
    {
        public DataTable HienTL()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TinhLuong", Con);
            DataTable dtTinhLuong = new DataTable();
            da.Fill(dtTinhLuong);
            return dtTinhLuong;
        }

        public bool ThemTL(DTO_TinhLuong tl)
        {
            try
            {
                Con.Open();
                string strThem = "INSERT INTO TinhLuong (IDTinhLuong,IDNhanvien, IDChucVu, LuongCoBan, Thuong, Phat, TongLuong) " +
                                 "VALUES (@IDTinhLuong, @IDNhanvien, @IDChucVu, @LuongCoBan, @Thuong, @Phat, @TongLuong)";
                SqlCommand cmd = new SqlCommand(strThem, Con);
                cmd.Parameters.AddWithValue("@IDTinhLuong", tl.IDTinhLuong1.Trim());
                cmd.Parameters.AddWithValue("@IDNhanvien", tl.IDNhanvien1.Trim());
                cmd.Parameters.AddWithValue("@IDChucVu", tl.IDChucVu1.Trim());
                cmd.Parameters.AddWithValue("@LuongCoBan", tl.LuongCoBan1);
                cmd.Parameters.AddWithValue("@Thuong", tl.Thuong1);
                cmd.Parameters.AddWithValue("@Phat", tl.Phat1);
                cmd.Parameters.AddWithValue("@TongLuong", tl.TongLuong1);
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception e) { }
            finally
            {
                Con.Close();
            }
            return false;
        }



        public bool XoaTL(string iDTinhLuong)
        {
            // Ensure the connection is closed before trying to open it
            if (Con.State == System.Data.ConnectionState.Open)
            {
                Con.Close();
            }

            Con.Open();
            string strXoa = "DELETE FROM TinhLuong WHERE IDTinhLuong = @IDTinhLuong";
            SqlCommand cmd = new SqlCommand(strXoa, Con);
            cmd.Parameters.AddWithValue("@IDTinhLuong", iDTinhLuong.Trim());

            bool result = cmd.ExecuteNonQuery() > 0;
            Con.Close();
            return result;
        }

        public DataTable TimTL(string tl)
        {
            string strTim = "SELECT * FROM TinhLuong WHERE IDChucVu LIKE @IDChucVu";
            SqlDataAdapter da = new SqlDataAdapter(strTim, Con);
            da.SelectCommand.Parameters.AddWithValue("@IDChucVu", "%" + tl + "%");
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public float tinhLuong(int HeSoLuong, float LuongCoBan, float Thuong, float Phat, string IDTinhLuong)
        {
            float TongLuong = 0;
            string lenh = $"sp_TinhTongLuong '{LuongCoBan}', '{HeSoLuong}', '{Thuong}', '{Phat}', '{IDTinhLuong}'";
            using (SqlConnection connection = new SqlConnection("Data Source=HIEUPC;Initial Catalog=Đồ án 1 : Quản lý cửa hàng máy tính;Integrated Security=True"))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(lenh, connection))
                {
                    // Sử dụng ExecuteScalar để lấy tổng lương trả về
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        TongLuong = Convert.ToSingle(result);
                    }
                    connection.Close();
                }
            }
            return TongLuong;
        }

        public bool SuaTL(DTO_TinhLuong tl)
        {
            try
            {
                if (Con.State == System.Data.ConnectionState.Open)
                {
                    Con.Close();
                }
                Con.Open();
                string strSua = "UPDATE TinhLuong SET IDNhanvien = @IDNhanvien, IDChucVu = @IDChucVu, LuongCoBan = @LuongCoBan, Thuong = @Thuong, Phat = @Phat, TongLuong = @TongLuong WHERE IDTinhLuong = @IDTinhLuong";
                SqlCommand cmd = new SqlCommand(strSua, Con);
                cmd.Parameters.AddWithValue("@IDTinhLuong", tl.IDTinhLuong1.Trim());
                cmd.Parameters.AddWithValue("@IDNhanvien", tl.IDNhanvien1.Trim());
                cmd.Parameters.AddWithValue("@IDChucVu", tl.IDChucVu1.Trim());
                cmd.Parameters.AddWithValue("@LuongCoBan", tl.LuongCoBan1);
                cmd.Parameters.AddWithValue("@Thuong", tl.Thuong1);
                cmd.Parameters.AddWithValue("@Phat", tl.Phat1);
                cmd.Parameters.AddWithValue("@TongLuong", tl.TongLuong1);

                return cmd.ExecuteNonQuery() > 0;
            }
            finally
            {
                Con.Close();
            }
        }
    }
}
