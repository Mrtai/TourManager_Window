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
    
    public partial class PHAN_QUYEN
    {
        public int MA_NHOM { get; set; }
        public int MA_MH { get; set; }
        public Nullable<bool> CO_QUYEN { get; set; }
    
        public virtual MAN_HINH MAN_HINH { get; set; }
        public virtual NHOM NHOM { get; set; }
    }
}
