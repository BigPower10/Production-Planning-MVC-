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
    
    public partial class MER_ORDER_CATEGORY
    {
        public byte SLNO { get; set; }
        public int ORDSLNO { get; set; }
        public byte SECCODE { get; set; }
        public string CATEGORY { get; set; }
        public short INSERTBY { get; set; }
        public System.DateTime INSERTDT { get; set; }
        public Nullable<short> UPDATEBY { get; set; }
        public Nullable<System.DateTime> UPDATEDT { get; set; }
    
        public virtual HRP_SECTION HRP_SECTION { get; set; }
        public virtual MER_ORDERDET MER_ORDERDET { get; set; }
    }
}