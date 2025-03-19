using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_NhaCungCap
    {
        private string IDNhacung;
        private string TenNhacung;
        private string DiaChi;
        private string Email;
        private string SoDienThoai;

        public DTO_NhaCungCap(string IDNhacung, string TenNhacung, string DiaChi, string Email, string SoDienThoai )
        {
            this.IDNhacung = IDNhacung;
            this.TenNhacung = TenNhacung;
            this.DiaChi = DiaChi;
            this.Email = Email;
            this.SoDienThoai = SoDienThoai;
        }
        public string IDNhacung1 { get => IDNhacung; set => IDNhacung = value; }
        public string TenNhacung1 { get => TenNhacung; set => TenNhacung = value; }
        public string DiaChi1 { get => DiaChi; set => DiaChi = value; }
        public string Email1 { get => Email; set => Email = value; }
        public string SoDienThoai1 { get => SoDienThoai; set => SoDienThoai = value; }
    }
}
