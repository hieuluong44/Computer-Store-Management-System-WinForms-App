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
    public class DAL_DanhMuc : Connection_Database
    {
        public DataTable HienDM()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from DanhMuc", Con);
            DataTable dtDM = new DataTable();
            da.Fill(dtDM);
            return dtDM;
        }

        public bool ThemDM(DTO_DanhMuc dm)
        {
            try
            {
                Con.Open();
                string strThem = "INSERT INTO DanhMuc (IDMuc, TenDanhMuc) " +
                                 "VALUES (@IDMuc, @TenDanhMuc)";
                SqlCommand cmd = new SqlCommand(strThem, Con);
                cmd.Parameters.AddWithValue("@IDMuc", dm.IDMuc1);
                cmd.Parameters.AddWithValue("@TenDanhMuc", dm.TenDanhMuc1);
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

        public bool SuaDM(DTO_DanhMuc dm)
        {
            try
            {
                Con.Open();
                string strThem = "Update DanhMuc set TenDanhMuc = @TenDanhMuc where IDMuc = @IDMuc";
                SqlCommand cmd = new SqlCommand(strThem, Con);
                cmd.Parameters.AddWithValue("@IDMuc", dm.IDMuc1);
                cmd.Parameters.AddWithValue("@TenDanhMuc", dm.TenDanhMuc1);
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

        public bool XoaDM(string iDMuc)
        {
            try
            {
                Con.Open();
                // Sửa lỗi trong câu lệnh SQL: sử dụng tham số để tránh lỗi SQL injection
                string strXoa = "DELETE FROM DanhMuc WHERE IDMuc = @IDMuc";
                SqlCommand cmd = new SqlCommand(strXoa, Con);
                cmd.Parameters.AddWithValue("@IDMuc", iDMuc);
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

        public DataTable TimDM(string tenDanhMuc)
        {
            string strTim = "SELECT * FROM DanhMuc WHERE TenDanhMuc like @TenDanhMuc";
            SqlDataAdapter da = new SqlDataAdapter(strTim, Con);
            da.SelectCommand.Parameters.AddWithValue("@TenDanhMuc", "%" + tenDanhMuc + "%");
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt; throw new NotImplementedException();
        }
    }
}
