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
    public class DAL_MatHang : Connection_Database
    {
        public DataTable HienMH()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM MatHang", Con);
            DataTable dtMatHang = new DataTable();
            da.Fill(dtMatHang);
            return dtMatHang;
        }

        public DataTable LayMatHang(string iDMatHang)
        {
            string query = "SELECT DonGia FROM MatHang WHERE IDMatHang = @IDMatHang OR Tenmathang = @Tenmathang";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            da.SelectCommand.Parameters.AddWithValue("@IDMatHang", iDMatHang);
            da.SelectCommand.Parameters.AddWithValue("@Tenmathang", iDMatHang);
            DataTable dtMatHang = new DataTable();
            da.Fill(dtMatHang);
            return dtMatHang;
        }
        public bool GiamSoLuongMatHang(string maMatHang, int soLuong)
        {
            try
            {
                Con.Open();
                string strTang = "EXEC SoLuongGiam @IDMatHang, @SoLuong";
                SqlCommand cmd = new SqlCommand(strTang, Con);
                cmd.Parameters.AddWithValue("@IDMatHang", maMatHang);
                cmd.Parameters.AddWithValue("@SoLuong", soLuong);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Con.Close();
            }
            return false;
        }

        public DataTable TimbangMH(string tenMH)
        {
            string strTim = "SELECT * FROM MatHang WHERE Tenmathang like @Tenmathang";
            SqlDataAdapter da = new SqlDataAdapter(strTim, Con);
            da.SelectCommand.Parameters.AddWithValue("@Tenmathang", "%" + tenMH + "%");
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt; throw new NotImplementedException();
        }

        public DataTable TimbangDM(string maDM)
        {
            string strTim = "SELECT * FROM MatHang WHERE IDMuc like @IDMuc";
            SqlDataAdapter da = new SqlDataAdapter(strTim, Con);
            da.SelectCommand.Parameters.AddWithValue("@IDMuc", "%" + maDM + "%");
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt; throw new NotImplementedException();
        }

        public bool TangSoLuongMatHang(string maMatHang, int soLuong)
        {
            try
            {
                Con.Open();
                string strTang = "EXEC SoLuongTang @IDMatHang, @SoLuong";
                SqlCommand cmd = new SqlCommand(strTang, Con);
                cmd.Parameters.AddWithValue("@IDMatHang", maMatHang);
                cmd.Parameters.AddWithValue("@SoLuong", soLuong);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Con.Close();
            }
            return false;
        }
        public bool ThemMH(DTO_MatHang mh)
        {
            try
            {
                Con.Open();
                string strThem = "INSERT INTO MatHang (IDMatHang, IDMuc, Tenmathang, DonGia, BaoHanh, Anh, SoLuong, ChiTiet) " +
                                 "VALUES (@IDMatHang, @IDMuc, @Tenmathang, @DonGia, @BaoHanh, @Anh, @SoLuong, @ChiTiet)";
                SqlCommand cmd = new SqlCommand(strThem, Con);
                cmd.Parameters.AddWithValue("@IDMatHang", mh.IDMatHang1.Trim());
                cmd.Parameters.AddWithValue("@IDMuc", mh.IDMuc1.Trim());
                cmd.Parameters.AddWithValue("@Tenmathang", mh.Tenmathang1.Trim());
                cmd.Parameters.AddWithValue("@DonGia", mh.DonGia1);
                cmd.Parameters.AddWithValue("@BaoHanh", mh.BaoHanh1.Trim());
                cmd.Parameters.AddWithValue("@Anh", mh.HinhAnh1);
                cmd.Parameters.AddWithValue("@SoLuong", mh.SoLuong1);
                cmd.Parameters.AddWithValue("@ChiTiet", mh.ChiTiet1.Trim());

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception e) { }
            finally
            {
                Con.Close();
            }
            return false;
        }

        public bool SuaMH(DTO_MatHang mh)
        {
            try
            {
                Con.Open();
                string strSua = "UPDATE MatHang SET IDMuc = @IDMuc, Tenmathang = @Tenmathang, DonGia = @DonGia, BaoHanh = @BaoHanh, Anh = @Anh, SoLuong = @SoLuong, ChiTiet = @ChiTiet WHERE IDMatHang = @IDMatHang";
                SqlCommand cmd = new SqlCommand(strSua, Con);
                cmd.Parameters.AddWithValue("@IDMatHang", mh.IDMatHang1.Trim());
                cmd.Parameters.AddWithValue("@IDMuc", mh.IDMuc1.Trim());
                cmd.Parameters.AddWithValue("@Tenmathang", mh.Tenmathang1.Trim());
                cmd.Parameters.AddWithValue("@DonGia", mh.DonGia1);
                cmd.Parameters.AddWithValue("@BaoHanh", mh.BaoHanh1.Trim());
                cmd.Parameters.AddWithValue("@Anh", mh.HinhAnh1);
                cmd.Parameters.AddWithValue("@SoLuong", mh.SoLuong1);
                cmd.Parameters.AddWithValue("@ChiTiet", mh.ChiTiet1.Trim());
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception e) { }
            finally
            {
                Con.Close();
            }
            return false;
        }

        public bool XoaMH(string IDMatHang)
        {
            try
            {
                Con.Open();
                string strXoa = "DELETE FROM MatHang WHERE IDMatHang = @IDMatHang";
                SqlCommand cmd = new SqlCommand(strXoa, Con);
                cmd.Parameters.AddWithValue("@IDMatHang", IDMatHang.Trim());

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
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
