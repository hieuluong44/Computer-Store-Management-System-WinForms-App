using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ChucVu
    {
        private string IDChucVu;
        private string ChucVu;
        private int HeSoLuong;
        public DTO_ChucVu(string IDChucVu, string ChucVu, int HeSoLuong)
        {
            this.IDChucVu = IDChucVu;
            this.ChucVu = ChucVu;
            this.HeSoLuong = HeSoLuong;
        }
        public string IDChucVu1 { get => IDChucVu; set => IDChucVu = value; }
        public string ChucVu1 { get => ChucVu; set => ChucVu = value; }
        public int HeSoLuong1 { get => HeSoLuong; set => HeSoLuong = value; }
    }
    public class DTO_TinhLuong
    {
        private string IDTinhLuong;
        private string IDNhanvien;
        private string IDChucVu;
        private float LuongCoBan;
        private float Thuong;
        private float Phat;
        private float TongLuong;
        public DTO_TinhLuong(string IDTinhLuong, string IDNhanvien, string IDChucVu, float LuongCoBan, float Thuong, float Phat, float TongLuong)
        {
            this.IDTinhLuong = IDTinhLuong;
            this.IDNhanvien = IDNhanvien;
            this.IDChucVu = IDChucVu;
            this.LuongCoBan = LuongCoBan;
            this.Thuong = Thuong;
            this.Phat = Phat;
            this.TongLuong = TongLuong;
        }
        public string IDTinhLuong1 { get => IDTinhLuong; set => IDTinhLuong = value; }
        public string IDNhanvien1 { get => IDNhanvien; set => IDNhanvien = value; }
        public string IDChucVu1 { get => IDChucVu; set => IDChucVu = value; }
        public float LuongCoBan1 { get => LuongCoBan;set=> LuongCoBan = value; }
        public float Thuong1 { get => Thuong; set => Thuong = value; }
        public float Phat1 { get => Phat; set => Phat = value; }
        public float TongLuong1 { get => TongLuong; set => TongLuong = value; }
    }
}
