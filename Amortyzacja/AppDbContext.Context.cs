﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Amortyzacja
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class IODatabaseEntities : DbContext
    {
        public IODatabaseEntities()
            : base("name=IODatabaseEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Amortization> Amortizations { get; set; }
        public virtual DbSet<Employment> Employments { get; set; }
        public virtual DbSet<Hardware> Hardwares { get; set; }
        public virtual DbSet<License> Licenses { get; set; }
        public virtual DbSet<Purchase> Purchases { get; set; }
        public virtual DbSet<Software> Softwares { get; set; }
        public virtual DbSet<Subscription> Subscriptions { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Worker> Workers { get; set; }
    }
}
