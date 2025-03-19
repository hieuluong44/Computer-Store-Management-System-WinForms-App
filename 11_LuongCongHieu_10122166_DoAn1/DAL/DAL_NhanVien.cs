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
    public class DAL_NhanVien : Connection_Database
    {
        public DataTable HienNV()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from NhanVien", Con);
            DataTable dtNhanVien = new DataTable();
            da.Fill(dtNhanVien);
            return dtNhanVien;
        }
        public DataTable XacThuc(string IDNhanvien, string SoDienThoai, string IDChucVu, string CCCD)
        {
            string query = "SELECT * FROM NhanVien WHERE IDNhanvien = @IDNhanvien AND SoDienThoai LIKE @SoDienThoai AND IDChucVu = @IDChucVu AND CCCD LIKE @CCCD";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            da.SelectCommand.Parameters.AddWithValue("@IDNhanvien", IDNhanvien);
            da.SelectCommand.Parameters.AddWithValue("@SoDienThoai", SoDienThoai);
            da.SelectCommand.Parameters.AddWithValue("@IDChucVu", IDChucVu);
            da.SelectCommand.Parameters.AddWithValue("@CCCD", CCCD);
            DataTable dtNhanVien = new DataTable();
            da.Fill(dtNhanVien);
            return dtNhanVien;
        }
        public DataTable LayNhanVien(string Macv)
        {
            string query = "SELECT IDNhanvien, TenNhanVien FROM NhanVien WHERE IDChucVu = @IDChucVu";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            da.SelectCommand.Parameters.AddWithValue("@IDChucVu", Macv);
            DataTable dtNhanVien = new DataTable();
            da.Fill(dtNhanVien);
            return dtNhanVien;
        }

        public DataTable TimNV1(string maCV)
        {
            string strTim = "SELECT * FROM NhanVien WHERE IDChucVu LIKE @IDChucVu";
            SqlDataAdapter da = new SqlDataAdapter(strTim, Con);
            da.SelectCommand.Parameters.AddWithValue("@IDChucVu", "%" + maCV + "%");
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public bool ThemNV(DTO_NhanVien nv)
        {

            try
            {
                if (Con.State == System.Data.ConnectionState.Open)
                {
                    Con.Close();
                }

                Con.Open();
                string strThem = "INSERT INTO NhanVien (IDNhanvien, IDChucVu, TenNhanVien, Gioitinh, Email, NgaySinh, SoDienThoai, CCCD, DiaChi, Anh) " +
                                 "VALUES (@IDNhanvien, @IDChucVu, @TenNhanVien, @Gioitinh, @Email, @NgaySinh, @SoDienThoai, @CCCD, @DiaChi, @Anh)";
                SqlCommand cmd = new SqlCommand(strThem, Con);
                cmd.Parameters.AddWithValue("@IDNhanvien", nv.IDNhanVien1.Trim());
                cmd.Parameters.AddWithValue("@IDChucVu", nv.IDChucVu1.Trim());
                cmd.Parameters.AddWithValue("@TenNhanVien", nv.TenNhanVien1.Trim());
                cmd.Parameters.AddWithValue("@Gioitinh", nv.Gioitinh1.Trim());
                cmd.Parameters.AddWithValue("@Email", nv.Email1.Trim());
                cmd.Parameters.AddWithValue("@NgaySinh", nv.NgaySinh1);
                cmd.Parameters.AddWithValue("@SoDienThoai", nv.SoDienThoai1);
                cmd.Parameters.AddWithValue("@CCCD", nv.CCCD1.Trim());
                cmd.Parameters.AddWithValue("@DiaChi", nv.DiaChi1.Trim());
                cmd.Parameters.AddWithValue("@Anh", nv.Anh1);

                return cmd.ExecuteNonQuery() > 0;
            }
            finally
            {
                Con.Close();
            }
        }

        public DataTable TimNV(string maNV, string TenNV)
        {
            string strTim = "SELECT * FROM NhanVien WHERE IDNhanvien LIKE @IDNhanvien OR TenNhanVien LIKE @TenNhanVien";
            SqlDataAdapter da = new SqlDataAdapter(strTim, Con);
            da.SelectCommand.Parameters.AddWithValue("@IDNhanvien", "%" + maNV + "%");
            da.SelectCommand.Parameters.AddWithValue("@TenNhanVien", "%" + TenNV + "%");
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public bool SuaNV(DTO_NhanVien nv)
        {
            try
            {
                // Ensure the connection is closed before trying to open it
                if (Con.State == System.Data.ConnectionState.Open)
                {
                    Con.Close();
                }

                Con.Open();
                string strSua = "UPDATE NhanVien SET IDChucVu = @IDChucVu, TenNhanVien = @TenNhanVien, Gioitinh = @Gioitinh, Email = @Email, NgaySinh = @NgaySinh, SoDienThoai = @SoDienThoai, CCCD = @CCCD, DiaChi = @DiaChi, Anh = @Anh WHERE IDNhanVien = @IDNhanVien";
                SqlCommand cmd = new SqlCommand(strSua, Con);
                cmd.Parameters.AddWithValue("@IDNhanvien", nv.IDNhanVien1.Trim());
                cmd.Parameters.AddWithValue("@IDChucVu", nv.IDChucVu1.Trim());
                cmd.Parameters.AddWithValue("@TenNhanVien", nv.TenNhanVien1.Trim());
                cmd.Parameters.AddWithValue("@Gioitinh", nv.Gioitinh1.Trim());
                cmd.Parameters.AddWithValue("@Email", nv.Email1.Trim());
                cmd.Parameters.AddWithValue("@NgaySinh", nv.NgaySinh1);
                cmd.Parameters.AddWithValue("@SoDienThoai", nv.SoDienThoai1);
                cmd.Parameters.AddWithValue("@CCCD", nv.CCCD1.Trim());
                cmd.Parameters.AddWithValue("@DiaChi", nv.DiaChi1.Trim());
                cmd.Parameters.AddWithValue("@Anh", nv.Anh1);

                return cmd.ExecuteNonQuery() > 0;
            }
            finally
            {
                Con.Close();
            }
        }
        public bool XoaNV(string IDNhanVien)
        {
            // Ensure the connection is closed before trying to open it
            if (Con.State == System.Data.ConnectionState.Open)
            {
                Con.Close();
            }

            Con.Open();
            string strXoa = "DELETE FROM NhanVien WHERE IDNhanVien = @IDNhanVien";
            SqlCommand cmd = new SqlCommand(strXoa, Con);
            cmd.Parameters.AddWithValue("@IDNhanVien", IDNhanVien.Trim());

            bool result = cmd.ExecuteNonQuery() > 0;
            Con.Close();
            return result;
        }

    }
}