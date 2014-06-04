﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ContosoSiteCodeFirst.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
namespace ContosoSiteCodeFirst.DAL
{
    public class SchoolContext : DbContext
    {
        public SchoolContext()
            : base("ScoolContext")
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}