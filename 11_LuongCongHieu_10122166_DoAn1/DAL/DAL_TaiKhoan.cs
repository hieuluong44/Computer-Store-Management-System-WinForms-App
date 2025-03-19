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
    public class DAL_TaiKhoan : Connection_Database
    {
        public DataTable HienTK()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TaiKhoan", Con);
            DataTable dtTaiKhoan = new DataTable();
            da.Fill(dtTaiKhoan);
            return dtTaiKhoan;
        }
        public DataTable LayTK(string tenDangNhap, string matKhau)
        {
            string strTim = "select * from TaiKhoan where TenDangNhap = @TenDangNhap and MatKhau = @MatKhau";
            SqlDataAdapter da = new SqlDataAdapter(strTim, Con);
            da.SelectCommand.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
            da.SelectCommand.Parameters.AddWithValue("@MatKhau", matKhau);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable TimTKbangCV(string maCV)
        {
            string strTim = "SELECT * FROM TaiKhoan WHERE IDChucVu LIKE @IDChucVu";
            SqlDataAdapter da = new SqlDataAdapter(strTim, Con);
            da.SelectCommand.Parameters.AddWithValue("@IDChucVu", "%" + maCV + "%");
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public bool DoiMatKhau(string tenDangNhap, string newPassword)
        {
            try
            {
                Con.Open();
                using (SqlCommand cmd = new SqlCommand("DoiMatKhau", Con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("TenDangNhap", tenDangNhap);
                    cmd.Parameters.AddWithValue("newPassword", newPassword);
                    if (cmd.ExecuteNonQuery() > 0)
                        return true;
                    else
                        return false;
                }
            }catch (Exception) {  }
            finally
            {
                Con.Close();
            }
            return false;
        }

        public DataTable TimTKbangNV(string maNV)
        {
            string strTim = "SELECT * FROM TaiKhoan WHERE TenDangNhap LIKE @TenDangNhap";
            SqlDataAdapter da = new SqlDataAdapter(strTim, Con);
            da.SelectCommand.Parameters.AddWithValue("@TenDangNhap", "%" + maNV + "%");
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public bool ThemTK(DTO_TaiKhoan tk)
        {
            Con.Open();
            string strThem = "INSERT INTO TaiKhoan (TenDangNhap,IDChucVu, MatKhau) " +
                             "VALUES (@TenDangNhap, @IDChucVu, @MatKhau)";
            SqlCommand cmd = new SqlCommand(strThem, Con);
            cmd.Parameters.AddWithValue("@TenDangNhap", tk.TenDangNhap1);
            cmd.Parameters.AddWithValue("@MatKhau", tk.MatKhau1);
            cmd.Parameters.AddWithValue("@IDChucVu", tk.IDChucVu1);
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            else
                return false;

            Con.Close();

            return false;
        }

        public bool SuaTK(DTO_TaiKhoan tk)
        {
            Con.Open();
            string strSua = "UPDATE TaiKhoan SET  IDChucVu = @IDChucVu, MatKhau = @MatKhau WHERE TenDangNhap = @TenDangNhap";
            SqlCommand cmd = new SqlCommand(strSua, Con);
            cmd.Parameters.AddWithValue("@TenDangNhap", tk.TenDangNhap1);
            cmd.Parameters.AddWithValue("@MatKhau", tk.MatKhau1);
            cmd.Parameters.AddWithValue("@IDChucVu", tk.IDChucVu1);
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            else
                return false;

            Con.Close();

            return false;
        }

        public bool XoaTK(string tenDangNhap)
        {
            Con.Open();
            // Sửa lỗi trong câu lệnh SQL: sử dụng tham số để tránh lỗi SQL injection
            string strXoa = "DELETE FROM TaiKhoan WHERE TenDangNhap = @TenDangNhap";
            SqlCommand cmd = new SqlCommand(strXoa, Con);
            cmd.Parameters.AddWithValue("@TenDangNhap", tenDangNhap.Trim());

            if (cmd.ExecuteNonQuery() > 0)
            { return true; }
            Con.Close();
            return false;
        }
    }
}
