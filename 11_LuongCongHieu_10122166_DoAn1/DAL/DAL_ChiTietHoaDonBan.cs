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
    public class DAL_ChiTietHoaDonBan : Connection_Database
    {
        public DataTable HienCT()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from CTBan", Con);
            DataTable dtHDB = new DataTable();
            da.Fill(dtHDB);
            return dtHDB;
        }
        public DataTable TimCT(string iDBan)
        {
            string strTim = "SELECT * FROM CTBan WHERE IDBan LIKE @IDBan";
            SqlDataAdapter da = new SqlDataAdapter(strTim, Con);
            da.SelectCommand.Parameters.AddWithValue("@IDBan", "%" + iDBan + "%");
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable LayHoaDonBan(string idBan)
        {
            SqlDataAdapter da = new SqlDataAdapter("sp_HienThiPhieuBan", Con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@IDBan", idBan);
            DataTable dtChiTietHDN = new DataTable();
            da.Fill(dtChiTietHDN);
            return dtChiTietHDN;
        }
        public bool ThemCT(DTO_ChiTietHoaDonBan cthd)
        {
            try
            {
                Con.Open();
                string strThem = "INSERT INTO CTBan (IDChitietBan,IDBan, IDMatHang,SoLuong,DonGiaXuat,ThanhTien) " +
                                 "VALUES (@IDChitietBan, @IDBan, @IDMatHang,@SoLuong, @DonGiaXuat,@ThanhTien)";
                SqlCommand cmd = new SqlCommand(strThem, Con);
                cmd.Parameters.AddWithValue("@IDChitietBan", cthd.IDChitietBan1);
                cmd.Parameters.AddWithValue("@IDBan", cthd.IDBan1);
                cmd.Parameters.AddWithValue("@IDMatHang", cthd.IDMatHang1);
                cmd.Parameters.AddWithValue("@SoLuong", cthd.Soluong1);
                cmd.Parameters.AddWithValue("@DonGiaXuat", cthd.DonGiaXuat1);
                cmd.Parameters.AddWithValue("@ThanhTien", cthd.ThanhTien1);
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
        public bool SuaCT(DTO_ChiTietHoaDonBan cthd)
        {
            try
            {
                Con.Open();
                string strThem = "UPDATE CTBan SET IDBan = @IDBan, IDMatHang = @IDMatHang, SoLuong = @SoLuong, DonGiaXuat = @DonGiaXuat, ThanhTien = @ThanhTien WHERE IDChitietBan = @IDChitietBan";
                SqlCommand cmd = new SqlCommand(strThem, Con);
                cmd.Parameters.AddWithValue("@IDChitietBan", cthd.IDChitietBan1);
                cmd.Parameters.AddWithValue("@IDBan", cthd.IDBan1);
                cmd.Parameters.AddWithValue("@IDMatHang", cthd.IDMatHang1);
                cmd.Parameters.AddWithValue("@SoLuong", cthd.Soluong1);
                cmd.Parameters.AddWithValue("@DonGiaXuat", cthd.DonGiaXuat1);
                cmd.Parameters.AddWithValue("@ThanhTien", cthd.ThanhTien1);
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
        public bool XoaCT(string iDChitietBan)
        {
            try
            {
                Con.Open();
                // Sửa lỗi trong câu lệnh SQL: sử dụng tham số để tránh lỗi SQL injection
                string strXoa = "DELETE FROM CTBan WHERE IDChitietBan = @IDChitietBan";
                SqlCommand cmd = new SqlCommand(strXoa, Con);
                cmd.Parameters.AddWithValue("@IDChitietBan", iDChitietBan);
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
        public float TinhTongTien(string maHDB)
        {
            float tongTien = 0;
            using (SqlCommand cmd = new SqlCommand("TinhTongTienChoHDB", Con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IDBan", maHDB);

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
    }
}
