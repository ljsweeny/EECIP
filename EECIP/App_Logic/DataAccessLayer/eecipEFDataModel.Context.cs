﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EECIP.App_Logic.DataAccessLayer
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EECIPEntities : DbContext
    {
        public EECIPEntities()
            : base("name=EECIPEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<T_OE_ROLES> T_OE_ROLES { get; set; }
        public virtual DbSet<T_OE_SYS_EMAIL_LOG> T_OE_SYS_EMAIL_LOG { get; set; }
        public virtual DbSet<T_OE_SYS_LOG> T_OE_SYS_LOG { get; set; }
        public virtual DbSet<T_OE_USER_ROLES> T_OE_USER_ROLES { get; set; }
        public virtual DbSet<T_OE_APP_SETTINGS> T_OE_APP_SETTINGS { get; set; }
        public virtual DbSet<T_OE_ORGANIZATION_EMAIL_RULE> T_OE_ORGANIZATION_EMAIL_RULE { get; set; }
        public virtual DbSet<T_OE_REF_ENTERPRISE_PLATFORM> T_OE_REF_ENTERPRISE_PLATFORM { get; set; }
        public virtual DbSet<T_OE_REF_REGION> T_OE_REF_REGION { get; set; }
        public virtual DbSet<T_OE_REF_STATE> T_OE_REF_STATE { get; set; }
        public virtual DbSet<T_OE_USERS> T_OE_USERS { get; set; }
        public virtual DbSet<T_OE_REF_TAG_CATEGORIES> T_OE_REF_TAG_CATEGORIES { get; set; }
        public virtual DbSet<T_OE_REF_TAGS> T_OE_REF_TAGS { get; set; }
        public virtual DbSet<T_OE_USER_EXPERTISE> T_OE_USER_EXPERTISE { get; set; }
        public virtual DbSet<T_OE_ORGANIZATION_TAGS> T_OE_ORGANIZATION_TAGS { get; set; }
        public virtual DbSet<T_OE_ORGANIZATION_ENT_SVCS> T_OE_ORGANIZATION_ENT_SVCS { get; set; }
        public virtual DbSet<T_OE_ORGANIZATION> T_OE_ORGANIZATION { get; set; }
        public virtual DbSet<T_OE_USER_NOTIFICATION> T_OE_USER_NOTIFICATION { get; set; }
        public virtual DbSet<T_OE_PROJECT_TAGS> T_OE_PROJECT_TAGS { get; set; }
        public virtual DbSet<T_OE_PROJECTS> T_OE_PROJECTS { get; set; }
    }
}