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
    
    public partial class DIA_DIEM_DU_LICH
    {
        public DIA_DIEM_DU_LICH()
        {
            this.CHI_TIET_THAM_QUAN = new HashSet<CHI_TIET_THAM_QUAN>();
        }
    
        public int MA_DIA_DIEM { get; set; }
        public Nullable<int> MA_TINH { get; set; }
        public string TEN_DIA_DIEM { get; set; }
    
        public virtual ICollection<CHI_TIET_THAM_QUAN> CHI_TIET_THAM_QUAN { get; set; }
        public virtual TINH TINH { get; set; }
    }
}
