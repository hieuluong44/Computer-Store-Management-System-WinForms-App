//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DTO
{
    using System;
    using System.Collections.Generic;
    
    public partial class CTNhap
    {
        public string IDChitietnhap { get; set; }
        public string IDNhap { get; set; }
        public string IDMatHang { get; set; }
        public Nullable<int> SoLuong { get; set; }
        public Nullable<double> DonGiaNhap { get; set; }
        public Nullable<double> ThanhTien { get; set; }
    
        public virtual MatHang MatHang { get; set; }
        public virtual HoaDonNhap HoaDonNhap { get; set; }
    }
}
