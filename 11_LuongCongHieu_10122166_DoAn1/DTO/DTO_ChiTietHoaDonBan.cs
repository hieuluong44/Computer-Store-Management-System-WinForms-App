using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ChiTietHoaDonBan
    {
        private string IDChitietBan;
        private string IDBan;
        private string IDMatHang;
        private int Soluong;
        private float DonGiaXuat;
        private float ThanhTien;
        public DTO_ChiTietHoaDonBan(string IDChitietBan, string IDBan, string IDMatHang, int Soluong, float DonGiaXuat, float ThanhTien)
        {
            this.IDChitietBan = IDChitietBan;
            this.IDBan = IDBan;
            this.IDMatHang = IDMatHang;
            this.Soluong = Soluong;
            this.DonGiaXuat = DonGiaXuat;
            this.ThanhTien = ThanhTien;
        }
        public string IDChitietBan1 { get => IDChitietBan; set => IDChitietBan = value; }
        public string IDBan1 { get => IDBan; set => IDBan = value; }
        public string IDMatHang1 { get => IDMatHang; set => IDMatHang = value; }
        public int Soluong1 { get => Soluong; set => Soluong = value; }
        public float DonGiaXuat1 { get => DonGiaXuat; set => DonGiaXuat = value; }
        public float ThanhTien1 { get => ThanhTien; set => ThanhTien = value; }
    }
}
