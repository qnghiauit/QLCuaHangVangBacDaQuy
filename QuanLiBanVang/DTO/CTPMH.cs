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
    
    public partial class CTPMH
    {
        public int SoPhieuMua { get; set; }
        public int STT { get; set; }
        public Nullable<int> MaSP { get; set; }
        public Nullable<int> MaLoaiSP { get; set; }
        public int SoLuong { get; set; }
        public double TrongLuong { get; set; }
        public decimal GiaMua { get; set; }
        public decimal Thanhtien { get; set; }
    
        public virtual LOAISANPHAM LOAISANPHAM { get; set; }
        public virtual PHIEUMUAHANG PHIEUMUAHANG { get; set; }
        public virtual SANPHAM SANPHAM { get; set; }
    }
}
