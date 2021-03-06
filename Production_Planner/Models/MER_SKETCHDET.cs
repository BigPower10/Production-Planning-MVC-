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
    
    public partial class MER_SKETCHDET
    {
        public MER_SKETCHDET()
        {
            this.MER_ORDERDET = new HashSet<MER_ORDERDET>();
        }
    
        public int SKETCHID { get; set; }
        public int SKETCHSLNO { get; set; }
        public int ORDCD { get; set; }
        public string ORDERNO { get; set; }
        public Nullable<short> YARNCD { get; set; }
        public Nullable<short> ORDCOLCD { get; set; }
        public Nullable<short> SIZECD { get; set; }
        public Nullable<int> ORDQTY { get; set; }
        public Nullable<int> PRODQTY { get; set; }
        public Nullable<decimal> WEIGHT { get; set; }
        public Nullable<System.DateTime> SHIPDT { get; set; }
        public string IMGFLAG { get; set; }
        public string STATUS { get; set; }
        public string SEASON { get; set; }
        public string KNITTYPE { get; set; }
        public Nullable<byte> BRANDCD { get; set; }
        public string FLAGIMG { get; set; }
        public Nullable<byte> SAMPLECD { get; set; }
        public string REMARKS { get; set; }
        public short INSERTBY { get; set; }
        public System.DateTime INSERTDT { get; set; }
        public Nullable<short> UPDATEBY { get; set; }
        public Nullable<System.DateTime> UPDATEDT { get; set; }
    
        public virtual MER_ORDERCOLOR MER_ORDERCOLOR { get; set; }
        public virtual ICollection<MER_ORDERDET> MER_ORDERDET { get; set; }
        public virtual MER_SIZEINFO MER_SIZEINFO { get; set; }
        public virtual MER_SKETCHMAS MER_SKETCHMAS { get; set; }
        public virtual MER_YARNINFO MER_YARNINFO { get; set; }
    }
}
