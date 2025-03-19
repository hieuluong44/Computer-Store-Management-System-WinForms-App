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
    public class DAL_KhachHang : Connection_Database
    {
        public DataTable HienKH()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from KhachHang", Con);
            DataTable dtKH = new DataTable();
            da.Fill(dtKH);
            return dtKH;
        }

        public DataTable LayKhachHang(string Khach)
        {
            // Sử dụng tham số trong câu truy vấn để lọc nhân viên theo mã chức vụ
            string query = "SELECT SoDienThoai FROM KhachHang WHERE IDKhach = @IDKhach OR TenKhach = @TenKhach ";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            da.SelectCommand.Parameters.AddWithValue("@IDKhach", Khach);
            da.SelectCommand.Parameters.AddWithValue("@TenKhach", Khach);
            DataTable dtKhach = new DataTable();
            da.Fill(dtKhach);
            return dtKhach;
        }

        public bool ThemKH(DTO_KhachHang kh)
        {
            try
            {
                Con.Open();
                string strThem = "INSERT INTO KhachHang (IDKhach, TenKhach,GioiTinh,SoDienThoai,CCCD,Email,DiaChi) " +
                                 "VALUES (@IDKhach, @TenKhach,@GioiTinh, @SoDienThoai,@CCCD, @Email,@DiaChi)";
                SqlCommand cmd = new SqlCommand(strThem, Con);
                cmd.Parameters.AddWithValue("@IDKhach", kh.IDKhach1);
                cmd.Parameters.AddWithValue("@TenKhach", kh.TenKhach1);
                cmd.Parameters.AddWithValue("@GioiTinh", kh.GioiTinh1);
                cmd.Parameters.AddWithValue("@SoDienThoai", kh.SoDienThoai1);
                cmd.Parameters.AddWithValue("@CCCD", kh.CCCD1);
                cmd.Parameters.AddWithValue("@Email", kh.Email1);
                cmd.Parameters.AddWithValue("@DiaChi", kh.DiaChi1);
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

        public bool SuaKH(DTO_KhachHang kh)
        {
            try
            {
                Con.Open();
                string strThem = "Update KhachHang set TenKhach = @TenKhach ,GioiTinh = @GioiTinh,SoDienThoai = @SoDienThoai,CCCD = @CCCD,Email = @Email,DiaChi = @DiaChi where IDKhach = @IDKhach";
                SqlCommand cmd = new SqlCommand(strThem, Con);
                cmd.Parameters.AddWithValue("@IDKhach", kh.IDKhach1);
                cmd.Parameters.AddWithValue("@TenKhach", kh.TenKhach1);
                cmd.Parameters.AddWithValue("@GioiTinh", kh.GioiTinh1);
                cmd.Parameters.AddWithValue("@SoDienThoai", kh.SoDienThoai1);
                cmd.Parameters.AddWithValue("@CCCD", kh.CCCD1);
                cmd.Parameters.AddWithValue("@Email", kh.Email1);
                cmd.Parameters.AddWithValue("@DiaChi", kh.DiaChi1);
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

        public bool XoaTK(string iDKhachHang)
        {
            try
            {
                Con.Open();
                // Sửa lỗi trong câu lệnh SQL: sử dụng tham số để tránh lỗi SQL injection
                string strXoa = "DELETE FROM KhachHang WHERE IDKhach = @IDKhach";
                SqlCommand cmd = new SqlCommand(strXoa, Con);
                cmd.Parameters.AddWithValue("@IDKhach", iDKhachHang.Trim());

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

        public DataTable TimKH(string tenKhachHang, string soDienThoai)
        {
            string strTim = "SELECT * FROM KhachHang WHERE TenKhach like @TenKhach OR SoDienThoai like @SoDienThoai";
            SqlDataAdapter da = new SqlDataAdapter(strTim, Con);
            da.SelectCommand.Parameters.AddWithValue("@TenKhach", "%" + tenKhachHang + "%");
            da.SelectCommand.Parameters.AddWithValue("@SoDienThoai", "%" + soDienThoai + "%");
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt; throw new NotImplementedException();
        }
    }
}
