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
    
    public partial class MER_SIZEINFO
    {
        public MER_SIZEINFO()
        {
            this.MER_ORDERDET = new HashSet<MER_ORDERDET>();
            this.MER_SKETCHDET = new HashSet<MER_SKETCHDET>();
        }
    
        public short SIZECD { get; set; }
        public string SIZENM { get; set; }
        public short INSERTBY { get; set; }
        public System.DateTime INSERTDT { get; set; }
        public Nullable<short> UPDATEBY { get; set; }
        public Nullable<System.DateTime> UPDATEDT { get; set; }
    
        public virtual ICollection<MER_ORDERDET> MER_ORDERDET { get; set; }
        public virtual ICollection<MER_SKETCHDET> MER_SKETCHDET { get; set; }
    }
}
