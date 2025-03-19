using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_MatHang
    {
        private string IDMatHang;
        private string IDMuc;
        private string Tenmathang;
        private float DonGia;
        private string BaoHanh;
        private byte[] HinhAnh;
        private int SoLuong;
        private string ChiTiet;

        public DTO_MatHang(string IDMatHang, string IDMuc, string Tenmathang, float DonGia , string BaoHanh, byte[] HinhAnh, int SoLuong, string ChiTiet)
        {
            this.IDMatHang = IDMatHang;
            this.IDMuc = IDMuc;
            this.Tenmathang = Tenmathang;
            this.DonGia = DonGia;
            this.BaoHanh = BaoHanh;
            this.HinhAnh = HinhAnh;
            this.SoLuong = SoLuong;
            this.ChiTiet = ChiTiet;
        }

        public string IDMatHang1 { get => IDMatHang; set => IDMatHang = value; }
        public string IDMuc1 { get => IDMuc; set => IDMuc = value; }
        public string Tenmathang1 { get => Tenmathang; set => Tenmathang = value; }
        public float DonGia1 { get => DonGia; set => DonGia = value; }
        public string BaoHanh1 { get => BaoHanh; set => BaoHanh = value; }
        public byte[] HinhAnh1 { get => HinhAnh; set => HinhAnh = value; }
        public int SoLuong1 { get => SoLuong; set => SoLuong = value; }
        public string ChiTiet1 { get => ChiTiet; set => ChiTiet = value; }
    }
}
