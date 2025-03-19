using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_KhachHang
    {
        private string IDKhach;
        private string TenKhach;
        private string GioiTinh;
        private string SoDienThoai;
        private string CCCD;
        private string Email;
        private string DiaChi;

        public DTO_KhachHang(string IDKhach, string TenKhach, string GioiTinh, string SoDienThoai, string CCCD, string Email, string DiaChi)
        {
            this.IDKhach = IDKhach;
            this.TenKhach = TenKhach;
            this.GioiTinh = GioiTinh;
            this.SoDienThoai = SoDienThoai;
            this.CCCD = CCCD;
            this.Email = Email;
            this.DiaChi = DiaChi;
        }
        public string IDKhach1 { get => IDKhach; set => IDKhach = value; }
        public string TenKhach1 { get => TenKhach; set => TenKhach = value; }
        public string GioiTinh1{ get => GioiTinh; set => GioiTinh = value; }
        public string SoDienThoai1 { get => SoDienThoai; set => SoDienThoai = value; }
        public string CCCD1 { get => CCCD; set => CCCD = value; }
        public string Email1 { get => Email; set => Email = value; }
        public string DiaChi1 { get => DiaChi; set => DiaChi = value; }
    }
}
