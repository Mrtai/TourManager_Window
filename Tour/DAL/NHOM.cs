//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class NHOM
    {
        public NHOM()
        {
            this.NHAN_VIEN_NHOM = new HashSet<NHAN_VIEN_NHOM>();
            this.PHAN_QUYEN = new HashSet<PHAN_QUYEN>();
        }
    
        public int MA_NHOM { get; set; }
        public string TEN_NHOM { get; set; }
        public string GHI_CHU { get; set; }
    
        public virtual ICollection<NHAN_VIEN_NHOM> NHAN_VIEN_NHOM { get; set; }
        public virtual ICollection<PHAN_QUYEN> PHAN_QUYEN { get; set; }
    }
}