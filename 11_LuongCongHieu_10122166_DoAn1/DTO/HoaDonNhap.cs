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
    
    public partial class HoaDonNhap
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HoaDonNhap()
        {
            this.CTNhaps = new HashSet<CTNhap>();
        }
    
        public string IDNhap { get; set; }
        public string IDNhacung { get; set; }
        public string IDNhanvien { get; set; }
        public System.DateTime NgayNhap { get; set; }
        public Nullable<double> TongThanhToan { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTNhap> CTNhaps { get; set; }
        public virtual NhanVien NhanVien { get; set; }
        public virtual NhaCungCap NhaCungCap { get; set; }
    }
}
