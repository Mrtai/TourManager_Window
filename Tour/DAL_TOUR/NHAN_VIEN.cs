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
    
    public partial class NHAN_VIEN
    {
        public NHAN_VIEN()
        {
            this.NHAN_VIEN_NHOM = new HashSet<NHAN_VIEN_NHOM>();
            this.TOUR_DAT = new HashSet<TOUR_DAT>();
        }
    
        public int MA_NV { get; set; }
        public string TEN_NV { get; set; }
        public string DIA_CHI { get; set; }
        public string EMAIL { get; set; }
        public string USERNAME { get; set; }
        public byte[] PASSWORD { get; set; }
    
        public virtual ICollection<NHAN_VIEN_NHOM> NHAN_VIEN_NHOM { get; set; }
        public virtual ICollection<TOUR_DAT> TOUR_DAT { get; set; }
    }
}
