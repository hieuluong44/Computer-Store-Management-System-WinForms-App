using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_TaiKhoan
    {
        private string TenDangNhap;
        private string IDChucVu;
        private string MatKhau;

        public DTO_TaiKhoan(string TenDangNhap, string IDChucVu, string MatKhau)
        {
            this.TenDangNhap = TenDangNhap;
            this.IDChucVu = IDChucVu;
            this.MatKhau = MatKhau;
        }

        public string TenDangNhap1 { get => TenDangNhap; set => TenDangNhap = value; }
        public string IDChucVu1 { get => IDChucVu; set => IDChucVu = value; }
        public string MatKhau1 { get => MatKhau; set => MatKhau = value; }

    }
}
