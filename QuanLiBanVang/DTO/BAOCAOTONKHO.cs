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
    
    public partial class BAOCAOTONKHO
    {
        public System.DateTime NgayBC { get; set; }
        public int MaSP { get; set; }
        public int TonDau { get; set; }
        public int SoLuongMua { get; set; }
        public int SoLuongBan { get; set; }
        public int TonCuoi { get; set; }
    
        public virtual SANPHAM SANPHAM { get; set; }
    }
}
