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
    
    public partial class MER_UNIT
    {
        public MER_UNIT()
        {
            this.MER_YARNINFO = new HashSet<MER_YARNINFO>();
            this.PRP_ASSIGNDET = new HashSet<PRP_ASSIGNDET>();
            this.PRP_DISTTOFACT = new HashSet<PRP_DISTTOFACT>();
            this.PRP_PRODDET = new HashSet<PRP_PRODDET>();
        }
    
        public byte UNITCD { get; set; }
        public string UNITNM { get; set; }
        public string BASEFLAG { get; set; }
        public Nullable<byte> CONVUNITCD { get; set; }
        public Nullable<decimal> CONVVALUE { get; set; }
        public short INSERTBY { get; set; }
        public System.DateTime INSERTDT { get; set; }
        public Nullable<short> UPDATEBY { get; set; }
        public Nullable<System.DateTime> UPDATEDT { get; set; }
    
        public virtual ICollection<MER_YARNINFO> MER_YARNINFO { get; set; }
        public virtual ICollection<PRP_ASSIGNDET> PRP_ASSIGNDET { get; set; }
        public virtual ICollection<PRP_DISTTOFACT> PRP_DISTTOFACT { get; set; }
        public virtual ICollection<PRP_PRODDET> PRP_PRODDET { get; set; }
    }
}
