//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ThucAnNhanh.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Voucher
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Voucher()
        {
            this.Voucher_KhachHang = new HashSet<Voucher_KhachHang>();
        }
    
        public string ID { get; set; }
        public string MoTa { get; set; }
        public Nullable<System.DateTime> NgayAD { get; set; }
        public Nullable<System.DateTime> NgayKT { get; set; }
        public Nullable<int> SoLuong { get; set; }
        public Nullable<int> Diem { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Voucher_KhachHang> Voucher_KhachHang { get; set; }
    }
}
