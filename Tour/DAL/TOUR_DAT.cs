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
    
    public partial class TOUR_DAT
    {
        public TOUR_DAT()
        {
            this.HOA_DON = new HashSet<HOA_DON>();
        }
    
        public int MA_TOUR_DAT { get; set; }
        public Nullable<int> MA_KHACH_HANG { get; set; }
        public Nullable<int> MA_LICH { get; set; }
        public string DIEM_DON { get; set; }
        public Nullable<System.DateTime> NGAY_DAT { get; set; }
        public string TRANG_THAI { get; set; }
    
        public virtual ICollection<HOA_DON> HOA_DON { get; set; }
        public virtual KHACH_HANG KHACH_HANG { get; set; }
        public virtual LICH_KHOI_HANH LICH_KHOI_HANH { get; set; }
    }
}