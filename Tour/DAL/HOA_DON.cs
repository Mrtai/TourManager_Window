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
    
    public partial class HOA_DON
    {
        public int MA_HD { get; set; }
        public Nullable<int> MA_LOAI_TT { get; set; }
        public int MA_TOUR_DAT { get; set; }
        public Nullable<double> TONG_TIEN { get; set; }
    
        public virtual LOAI_THANH_TOAN LOAI_THANH_TOAN { get; set; }
        public virtual TOUR_DAT TOUR_DAT { get; set; }
    }
}
