//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Production_Planner.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CMN_COUNTRY
    {
        public CMN_COUNTRY()
        {
            this.MER_COMPCODE = new HashSet<MER_COMPCODE>();
        }
    
        public byte CONCD { get; set; }
        public string CONNM { get; set; }
        public Nullable<short> COUNTRY_CODE { get; set; }
        public short INSERTBY { get; set; }
        public System.DateTime INSERTDT { get; set; }
        public Nullable<short> UPDATEBY { get; set; }
        public Nullable<System.DateTime> UPDATEDT { get; set; }
    
        public virtual ICollection<MER_COMPCODE> MER_COMPCODE { get; set; }
    }
}
