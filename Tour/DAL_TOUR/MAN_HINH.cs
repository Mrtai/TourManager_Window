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
    
    public partial class MAN_HINH
    {
        public MAN_HINH()
        {
            this.PHAN_QUYEN = new HashSet<PHAN_QUYEN>();
        }
    
        public int MA_MH { get; set; }
        public string TEN_MAN_HINH { get; set; }
        public Nullable<int> TAG { get; set; }
    
        public virtual ICollection<PHAN_QUYEN> PHAN_QUYEN { get; set; }
    }
}
