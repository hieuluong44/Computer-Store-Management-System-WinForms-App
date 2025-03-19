using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_DanhMuc
    {
        private string IDMuc;
        private string TenDanhMuc;
        public DTO_DanhMuc(string IDMuc, string TenDanhMuc)
        {
            this.IDMuc = IDMuc;
            this.TenDanhMuc = TenDanhMuc;
        }
        public string IDMuc1 { get => IDMuc; set => IDMuc = value; }
        public string TenDanhMuc1 { get => TenDanhMuc; set => TenDanhMuc = value; }
    }
}
