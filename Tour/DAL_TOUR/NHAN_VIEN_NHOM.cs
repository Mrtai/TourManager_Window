//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL_TOUR
{
    using System;
    using System.Collections.Generic;
    
    public partial class NHAN_VIEN_NHOM
    {
        public int MA_NV { get; set; }
        public int MA_NHOM { get; set; }
        public string GHI_CHU { get; set; }
    
        public virtual NHAN_VIEN NHAN_VIEN { get; set; }
        public virtual NHOM NHOM { get; set; }
    }
}