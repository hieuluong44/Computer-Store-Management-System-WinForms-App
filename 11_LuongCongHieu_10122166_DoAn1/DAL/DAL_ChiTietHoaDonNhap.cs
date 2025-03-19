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
    public class DAL_ChiTietHoaDonNhap : Connection_Database
    {
        public DataTable HienCTN()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from CTNhap", Con);
            DataTable dtHDN = new DataTable();
            da.Fill(dtHDN);
            return dtHDN;
        }

        public bool ThemCTN(DTO_ChiTietHoaDonNhap ctn)
        {
            try
            {
                Con.Open();
                string strThem = "INSERT INTO CTNhap (IDChitietnhap,IDNhap, IDMatHang,SoLuong,DonGiaNhap,ThanhTien) " +
                                 "VALUES (@IDChitietnhap, @IDNhap, @IDMatHang,@SoLuong, @DonGiaNhap,@ThanhTien)";
                SqlCommand cmd = new SqlCommand(strThem, Con);
                cmd.Parameters.AddWithValue("@IDChitietnhap", ctn.IDChitietnhap1);
                cmd.Parameters.AddWithValue("@IDNhap", ctn.IDNhap1);
                cmd.Parameters.AddWithValue("@IDMatHang", ctn.IDMatHang1);
                cmd.Parameters.AddWithValue("@SoLuong", ctn.Soluong1);
                cmd.Parameters.AddWithValue("@DonGiaNhap", ctn.DonGiaNhap1);
                cmd.Parameters.AddWithValue("@ThanhTien", ctn.ThanhTien1);
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

        public float TinhTongTien(string iDNhap)
        {
            float tongTien = 0;
            using (SqlCommand cmd = new SqlCommand("TinhTongTienChoHDN", Con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IDNhap", iDNhap);

                Con.Open();
                var result = cmd.ExecuteScalar();
                if (result != null)
                {
                    tongTien = Convert.ToSingle(result);
                }
                Con.Close();
            }
            return tongTien;
        }

        public bool SuaCTN(DTO_ChiTietHoaDonNhap ctn)
        {
            try
            {
                Con.Open();
                string strThem = "Update CTNhap set IDNhap = @IDNhap,IDMatHang = @IDMatHang,SoLuong = @SoLuong, DonGiaNhap = @DonGiaNhap, ThanhTien = @ThanhTien where IDChitietnhap = @IDChitietnhap";
                SqlCommand cmd = new SqlCommand(strThem, Con);
                cmd.Parameters.AddWithValue("@IDChitietnhap", ctn.IDChitietnhap1);
                cmd.Parameters.AddWithValue("@IDNhap", ctn.IDNhap1);
                cmd.Parameters.AddWithValue("@IDMatHang", ctn.IDMatHang1);
                cmd.Parameters.AddWithValue("@SoLuong", ctn.Soluong1);
                cmd.Parameters.AddWithValue("@DonGiaNhap", ctn.DonGiaNhap1);
                cmd.Parameters.AddWithValue("@ThanhTien", ctn.ThanhTien1);
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

        public bool XoaCTN(string iDNhap)
        {
            try
            {
                Con.Open();
                // Sửa lỗi trong câu lệnh SQL: sử dụng tham số để tránh lỗi SQL injection
                string strXoa = "DELETE FROM CTNhap WHERE IDChitietnhap = @IDChitietnhap";
                SqlCommand cmd = new SqlCommand(strXoa, Con);
                cmd.Parameters.AddWithValue("@IDChitietnhap", iDNhap);
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

        public DataTable TimCTN(string IDCTN)
        {
            string strTim = "SELECT * FROM CTNhap WHERE IDNhap LIKE @IDNhap";
            SqlDataAdapter da = new SqlDataAdapter(strTim, Con);
            da.SelectCommand.Parameters.AddWithValue("@IDNhap",IDCTN);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
