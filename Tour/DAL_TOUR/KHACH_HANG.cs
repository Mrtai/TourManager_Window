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
    
    public partial class KHACH_HANG
    {
        public KHACH_HANG()
        {
            this.TOUR_DAT = new HashSet<TOUR_DAT>();
        }
    
        public int MA_KHACH_HANG { get; set; }
        public string TEN { get; set; }
        public string EMAIL { get; set; }
        public string DIEN_THOAI { get; set; }
        public Nullable<System.DateTime> NGAY_SINH { get; set; }
        public string DIA_CHI { get; set; }
    
        public virtual ICollection<TOUR_DAT> TOUR_DAT { get; set; }
    }
}
