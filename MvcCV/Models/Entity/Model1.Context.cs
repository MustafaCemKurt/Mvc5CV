﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcCV.Models.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DbCvEntities : DbContext
    {
        public DbCvEntities()
            : base("name=DbCvEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TblAbout> TblAbout { get; set; }
        public virtual DbSet<TblAdmin> TblAdmin { get; set; }
        public virtual DbSet<TblCertificiates> TblCertificiates { get; set; }
        public virtual DbSet<TblCommunication> TblCommunication { get; set; }
        public virtual DbSet<TblEducation> TblEducation { get; set; }
        public virtual DbSet<TblExperience> TblExperience { get; set; }
        public virtual DbSet<TblInterests> TblInterests { get; set; }
        public virtual DbSet<TblSkills> TblSkills { get; set; }
        public virtual DbSet<TblSocial> TblSocial { get; set; }
    }
}
