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
    public class DAL_NhaCungCap : Connection_Database
    {
        public DataTable HienNCC()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from NhaCungCap", Con);
            DataTable dtNCC = new DataTable();
            da.Fill(dtNCC);
            return dtNCC;
        }

        public DataTable LayNCC(string Nhacung)
        {
            // Sử dụng tham số trong câu truy vấn để lọc nhân viên theo mã chức vụ
            string query = "SELECT SoDienThoai FROM NhaCungCap WHERE IDNhacung = @IDNhacung OR TenNhacung = @TenNhacung ";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            da.SelectCommand.Parameters.AddWithValue("@IDNhacung", Nhacung);
            da.SelectCommand.Parameters.AddWithValue("@TenNhacung", Nhacung);
            DataTable dtNCC = new DataTable();
            da.Fill(dtNCC);
            return dtNCC;
        }
        public bool ThemNCC(DTO_NhaCungCap ncc)
        {
            try
            {
                Con.Open();
                string strThem = "INSERT INTO NhaCungCap (IDNhacung, TenNhacung, DiaChi, Email, SoDienThoai) " +
                                 "VALUES (@IDNhacung, @TenNhacung,@DiaChi, @Email,@SoDienThoai)";
                SqlCommand cmd = new SqlCommand(strThem, Con);
                cmd.Parameters.AddWithValue("@IDNhacung", ncc.IDNhacung1);
                cmd.Parameters.AddWithValue("@TenNhacung", ncc.TenNhacung1);
                cmd.Parameters.AddWithValue("@DiaChi", ncc.DiaChi1);
                cmd.Parameters.AddWithValue("@Email", ncc.Email1);
                cmd.Parameters.AddWithValue("@SoDienThoai", ncc.SoDienThoai1);
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

        public bool SuaNCC(DTO_NhaCungCap ncc)
        {
            try
            {
                Con.Open();
                string strThem = "Update NhaCungCap set TenNhacung = @TenNhacung,DiaChi = @DiaChi, Email = @Email,SoDienThoai = @SoDienThoai where  IDNhacung = @IDNhacung";
                SqlCommand cmd = new SqlCommand(strThem, Con);
                cmd.Parameters.AddWithValue("@IDNhacung", ncc.IDNhacung1);
                cmd.Parameters.AddWithValue("@TenNhacung", ncc.TenNhacung1);
                cmd.Parameters.AddWithValue("@DiaChi", ncc.DiaChi1);
                cmd.Parameters.AddWithValue("@Email", ncc.Email1);
                cmd.Parameters.AddWithValue("@SoDienThoai", ncc.SoDienThoai1);
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

        public bool XoaNCC(string iDNhaCung)
        {
            try
            {
                Con.Open();
                // Sửa lỗi trong câu lệnh SQL: sử dụng tham số để tránh lỗi SQL injection
                string strXoa = "DELETE FROM NhaCungCap WHERE IDNhacung = @IDNhacung";
                SqlCommand cmd = new SqlCommand(strXoa, Con);
                cmd.Parameters.AddWithValue("@IDNhacung", iDNhaCung);

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

        public DataTable TimNCC(string tenNhacung, string soDienThoai)
        {
            string strTim = "SELECT * FROM NhaCungCap WHERE TenNhacung LIKE @TenNhacung OR SoDienThoai LIKE @SoDienThoai";
            SqlDataAdapter da = new SqlDataAdapter(strTim, Con);
            da.SelectCommand.Parameters.AddWithValue("@TenNhacung", "%" + tenNhacung + "%");
            da.SelectCommand.Parameters.AddWithValue("@SoDienThoai", "%" + soDienThoai + "%");
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt; throw new NotImplementedException();
        }
    }
}
