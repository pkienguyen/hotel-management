//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLKhachSan
{
    using System;
    using System.Collections.Generic;
    
    public partial class BangThuePhong
    {
        public string ID { get; set; }
        public string IDPhong { get; set; }
        public string IDKhachHang { get; set; }
        public Nullable<System.DateTime> NgayDat { get; set; }
        public Nullable<System.DateTime> CheckIn { get; set; }
        public Nullable<int> SoNguoi { get; set; }
        public int IDTinhTrang { get; set; }
    
        public virtual KhachHang KhachHang { get; set; }
        public virtual Phong Phong { get; set; }
        public virtual TinhTrangPhong TinhTrangPhong { get; set; }
    }
}