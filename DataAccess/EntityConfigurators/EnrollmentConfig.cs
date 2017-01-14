using DataAccess.Models;
using System;
using System.Data.Entity;

namespace DataAccess.EntityConfigurators
{
    public class EnrollmentConfig : IEntityConfig
    {
        const string UQ_Enrollment = "UQ_Enrollment";
        public void SetupEntity(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EnrollmentDb>().ToTable("Enrollment");

            var entity = modelBuilder.Entity<EnrollmentDb>();
            entity.HasKey(k => k.Id);
            entity.Property(p => p.AddedDate)
                .HasColumnType("datetime")
                .IsRequired();

            entity.Property(p => p.ClassId)
                .IsRequired()
                .HasUniqueIndexAnnotation(UQ_Enrollment, 0);

            entity.Property(p => p.StudentId)
                .IsRequired()
                .HasUniqueIndexAnnotation(UQ_Enrollment, 1);

            entity.HasRequired(t => t.Class);
            entity.HasRequired(t => t.Student);



        }
    }
}
