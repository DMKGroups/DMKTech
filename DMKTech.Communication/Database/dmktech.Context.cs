﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DMKTech.Communication.Database
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class db_dmktechEntities : DbContext
    {
        public db_dmktechEntities()
            : base("name=db_dmktechEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Table> Tables { get; set; }
        public virtual DbSet<tbl_AdminLogin> tbl_AdminLogin { get; set; }
        public virtual DbSet<tbl_GeneralSetting> tbl_GeneralSetting { get; set; }
        public virtual DbSet<tbl_Role> tbl_Role { get; set; }
        public virtual DbSet<tbl_Category> tbl_Category { get; set; }
    }
}
