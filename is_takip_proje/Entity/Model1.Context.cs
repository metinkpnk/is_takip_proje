﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace is_takip_proje.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DbİsTakipEntities : DbContext
    {
        public DbİsTakipEntities()
            : base("name=DbİsTakipEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TblAdmin> TblAdmin { get; set; }
        public virtual DbSet<TblCağrilar> TblCağrilar { get; set; }
        public virtual DbSet<TblDepartmanlar> TblDepartmanlar { get; set; }
        public virtual DbSet<TblFirmalar> TblFirmalar { get; set; }
        public virtual DbSet<TblGörevDetaylar> TblGörevDetaylar { get; set; }
        public virtual DbSet<TblGörevler> TblGörevler { get; set; }
        public virtual DbSet<TblPersonel> TblPersonel { get; set; }
    }
}
