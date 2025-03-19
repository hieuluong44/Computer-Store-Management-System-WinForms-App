using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_HoaDonBan
    {
        private string IDBan;
        private string IDKhach;
        private string IDNhanvien;
        private DateTime NgayBan;
        private float TongTien;
        public DTO_HoaDonBan(string IDBan, string IDKhach, string IDNhanvien, DateTime NgayBan, float TongTien)
        {
            this.IDBan = IDBan;
            this.IDKhach = IDKhach;
            this.IDNhanvien = IDNhanvien;
            this.NgayBan = NgayBan;
            this.TongTien = TongTien;
        }
        public string IDBan1 { get => IDBan; set => IDBan = value; }
        public string IDKhach1 { get => IDKhach; set => IDKhach = value; }
        public string IDNhanvien1 { get => IDNhanvien; set => IDNhanvien = value; }
        public DateTime NgayBan1 { get => NgayBan; set => NgayBan = value; }
        public float TongTien1 { get => TongTien; set => TongTien = value; }
    }
}
