﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GradApp.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class GradAppEntities : DbContext
    {
        public GradAppEntities()
            : base("name=GradAppEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Area> Areas { get; set; }
        public virtual DbSet<Goal> Goals { get; set; }
        public virtual DbSet<GradProj> GradProjs { get; set; }
        public virtual DbSet<Graduate> Graduates { get; set; }
        public virtual DbSet<Manager> Managers { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}
