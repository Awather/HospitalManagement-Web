using System;
using HospitalManagement_Web.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace HospitalManagement_Web.DBAccess
{
    public class HospitalContext : DbContext
    {

        public HospitalContext() : base("HospitalContext")
        {
        }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<Registration> Registrations { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }


    }
}