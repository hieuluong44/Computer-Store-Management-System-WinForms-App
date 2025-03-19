using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_NhanVien
    {
        private string IDNhanvien;
        private string IDChucVu;
        private string TenNhanVien;
        private string Gioitinh;
        private string Email;
        private DateTime NgaySinh;
        private string SoDienThoai;
        private string CCCD;
        private string DiaChi;
        private byte[] Anh;

        public DTO_NhanVien(string IDNhanvien, string IDChucVu, string TenNhanVien, string Gioitinh, string Email, DateTime NgaySinh, string SoDienThoai, string CCCD, string DiaChi, byte[] Anh)
        {
            this.IDNhanvien = IDNhanvien;
            this.IDChucVu = IDChucVu;
            this.TenNhanVien = TenNhanVien;
            this.Gioitinh = Gioitinh;
            this.Email = Email;
            this.NgaySinh = NgaySinh;
            this.SoDienThoai = SoDienThoai;
            this.CCCD = CCCD;
            this.DiaChi = DiaChi;
            this.Anh = Anh;
        }

        public string IDNhanVien1 { get => IDNhanvien; set => IDNhanvien = value; }
        public string IDChucVu1 { get => IDChucVu; set => IDChucVu = value; }
        public string TenNhanVien1 { get => TenNhanVien; set => TenNhanVien = value; }
        public string Gioitinh1 { get => Gioitinh; set => Gioitinh = value; }
        public string Email1 { get => Email; set => Email = value; }
        public DateTime NgaySinh1 { get => NgaySinh; set => NgaySinh = value; }
        public string SoDienThoai1 { get => SoDienThoai; set => SoDienThoai = value; }
        public string CCCD1 { get => CCCD; set => CCCD = value; }
        public string DiaChi1 { get => DiaChi; set => DiaChi = value; }
        public byte[] Anh1 { get => Anh; set => Anh = value; }


        


    }
}
