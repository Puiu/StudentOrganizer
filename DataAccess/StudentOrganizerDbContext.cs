using DataAccess.EntityConfigurators;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;


namespace DataAccess
{
    public class StudentOrganizerDbContext : DbContext
    {
        public StudentOrganizerDbContext() : base("name=SchoolDBConnectionString")
        {

        }

        public DbSet<ClassDb> Classes { get; set; }
        public DbSet<StudentDb> Students { get; set; }

        public DbSet<EnrollmentDb> Enrollments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("dbo");

            (new ClassConfig()).SetupEntity(modelBuilder);
            (new StudentConfig()).SetupEntity(modelBuilder);
            (new EnrollmentConfig()).SetupEntity(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }

    }
}
