using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityConfigurators
{
    public class StudentConfig : IEntityConfig
    {
        public void SetupEntity(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentDb>().ToTable("Student");

            var entity = modelBuilder.Entity<StudentDb>();

            entity.HasKey(k => k.Id);
            entity.Property(p => p.Name)
                .HasMaxLength(50)
                .IsRequired();
            entity.Property(p => p.UniqueId).IsRequired();
            entity.Property(p => p.IsActive).IsRequired();

            entity.HasOptional(o => o.Enrollments);
            
        }
    }
}
