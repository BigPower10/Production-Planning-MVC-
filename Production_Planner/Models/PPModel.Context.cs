﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ProductionPlannerEntities : DbContext
    {
        public ProductionPlannerEntities()
            : base("name=ProductionPlannerEntities")
        {
            this.Configuration.ProxyCreationEnabled = false;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CMN_COUNTRY> CMN_COUNTRY { get; set; }
        public virtual DbSet<HRP_COMPUNIT> HRP_COMPUNIT { get; set; }
        public virtual DbSet<HRP_HOLIDAY> HRP_HOLIDAY { get; set; }
        public virtual DbSet<HRP_SECTION> HRP_SECTION { get; set; }
        public virtual DbSet<MER_COMPCODE> MER_COMPCODE { get; set; }
        public virtual DbSet<MER_CP> MER_CP { get; set; }
        public virtual DbSet<MER_CP_ORDER> MER_CP_ORDER { get; set; }
        public virtual DbSet<MER_GAUGE> MER_GAUGE { get; set; }
        public virtual DbSet<MER_LABDIP> MER_LABDIP { get; set; }
        public virtual DbSet<MER_LCREGIS> MER_LCREGIS { get; set; }
        public virtual DbSet<MER_ORDER_CATEGORY> MER_ORDER_CATEGORY { get; set; }
        public virtual DbSet<MER_ORDERCOLOR> MER_ORDERCOLOR { get; set; }
        public virtual DbSet<MER_ORDERDET> MER_ORDERDET { get; set; }
        public virtual DbSet<MER_ORDERMAS> MER_ORDERMAS { get; set; }
        public virtual DbSet<MER_SIZEINFO> MER_SIZEINFO { get; set; }
        public virtual DbSet<MER_SKETCHDET> MER_SKETCHDET { get; set; }
        public virtual DbSet<MER_SKETCHMAS> MER_SKETCHMAS { get; set; }
        public virtual DbSet<MER_SMV> MER_SMV { get; set; }
        public virtual DbSet<MER_UNIT> MER_UNIT { get; set; }
        public virtual DbSet<MER_YARNCOLOR> MER_YARNCOLOR { get; set; }
        public virtual DbSet<MER_YARNINFO> MER_YARNINFO { get; set; }
        public virtual DbSet<PRP_ASSIGNDET> PRP_ASSIGNDET { get; set; }
        public virtual DbSet<PRP_ASSIGNMAS> PRP_ASSIGNMAS { get; set; }
        public virtual DbSet<PRP_DISTTOFACT> PRP_DISTTOFACT { get; set; }
        public virtual DbSet<PRP_MODULE> PRP_MODULE { get; set; }
        public virtual DbSet<PRP_PRODDET> PRP_PRODDET { get; set; }
        public virtual DbSet<PRP_PRODMAS> PRP_PRODMAS { get; set; }
    }
}
