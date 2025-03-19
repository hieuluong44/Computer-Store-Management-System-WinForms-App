using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ChiTietHoaDonNhap
    {
        private string IDChitietnhap;
        private string IDNhap;
        private string IDMatHang;
        private int Soluong;
        private float DonGiaNhap;
        private float ThanhTien;
        public DTO_ChiTietHoaDonNhap(string IDChitietnhap, string IDNhap, string IDMatHang, int Soluong, float DonGiaNhap, float ThanhTien)
        {
            this.IDChitietnhap = IDChitietnhap;
            this.IDNhap = IDNhap;
            this.IDMatHang = IDMatHang;
            this.Soluong = Soluong;
            this.DonGiaNhap = DonGiaNhap;
            this.ThanhTien = ThanhTien;
        }
        public string IDChitietnhap1 { get => IDChitietnhap; set => IDChitietnhap = value; }
        public string IDNhap1 { get => IDNhap; set => IDNhap = value; }
        public string IDMatHang1 { get => IDMatHang; set => IDMatHang = value; }
        public int Soluong1 { get => Soluong; set => Soluong = value; }
        public float DonGiaNhap1 { get => DonGiaNhap; set => DonGiaNhap = value; }
        public float ThanhTien1 { get => ThanhTien; set => ThanhTien = value; }
    }
}
