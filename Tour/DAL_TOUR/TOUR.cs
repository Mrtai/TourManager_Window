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
    
    public partial class TOUR
    {
        public TOUR()
        {
            this.CHUONG_TRINH_TOUR = new HashSet<CHUONG_TRINH_TOUR>();
            this.LICH_KHOI_HANH = new HashSet<LICH_KHOI_HANH>();
        }
    
        public int MA_TOUR { get; set; }
        public Nullable<int> MA_LOAI { get; set; }
        public string TEN_TOUR { get; set; }
        public Nullable<int> SO_NGAY { get; set; }
        public Nullable<int> SO_CHO { get; set; }
        public Nullable<double> GIA { get; set; }
        public Nullable<double> DISCOUNT { get; set; }
        public string IMAGE { get; set; }
    
        public virtual ICollection<CHUONG_TRINH_TOUR> CHUONG_TRINH_TOUR { get; set; }
        public virtual ICollection<LICH_KHOI_HANH> LICH_KHOI_HANH { get; set; }
        public virtual LOAI_TOUR LOAI_TOUR { get; set; }
    }
}
