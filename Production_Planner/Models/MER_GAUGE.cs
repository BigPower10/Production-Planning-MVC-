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
    
    public partial class MER_GAUGE
    {
        public MER_GAUGE()
        {
            this.MER_SKETCHMAS = new HashSet<MER_SKETCHMAS>();
            this.PRP_MODULE = new HashSet<PRP_MODULE>();
            this.MER_ORDERMAS = new HashSet<MER_ORDERMAS>();
        }
    
        public byte GAUGECD { get; set; }
        public string GAUGENM { get; set; }
        public short INSERTBY { get; set; }
        public System.DateTime INSERTDT { get; set; }
        public Nullable<short> UPDATEBY { get; set; }
        public Nullable<System.DateTime> UPDATEDT { get; set; }
    
        public virtual ICollection<MER_SKETCHMAS> MER_SKETCHMAS { get; set; }
        public virtual ICollection<PRP_MODULE> PRP_MODULE { get; set; }
        public virtual ICollection<MER_ORDERMAS> MER_ORDERMAS { get; set; }
    }
}
