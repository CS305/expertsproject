﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using ExpertsProject.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using IdentitySample.Models;

namespace ExpertsProject.DAL
{
    public class ExpertContext : DbContext
    {
        public ExpertContext() : base("ExpertContext")
        {
        }

        public DbSet<Expert> Experts { get; set; }
        public DbSet<Expertise> Expertises { get; set; }
        public DbSet<ApplicationUser> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}