using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_HoaDonNhap
    {
        private string IDNhap;
        private string IDNhacung;
        private string IDNhanvien;
        private DateTime NgayNhap;
        private float TongThanhToan;
        public DTO_HoaDonNhap(string IDNhap, string IDNhacung, string IDNhanvien, DateTime NgayNhap, float TongThanhToan)
        {
            this.IDNhap = IDNhap;
            this.IDNhacung = IDNhacung;
            this.IDNhanvien = IDNhanvien;
            this.NgayNhap = NgayNhap;
            this.TongThanhToan = TongThanhToan;
        }
        public string IDNhap1 { get => IDNhap; set => IDNhap = value; }
        public string IDNhacung1 { get => IDNhacung; set => IDNhacung = value; }
        public string IDNhanvien1 { get => IDNhanvien; set => IDNhanvien = value; }
        public DateTime NgayNhap1 { get => NgayNhap; set => NgayNhap = value; }
        public float TongThanhToan1 { get => TongThanhToan; set => TongThanhToan = value; }
    }
}
