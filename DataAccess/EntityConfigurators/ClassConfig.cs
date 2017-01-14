using DataAccess.Models;
using System.Data.Entity;

namespace DataAccess.EntityConfigurators
{
    public class ClassConfig : IEntityConfig
    {
        public void SetupEntity(DbModelBuilder modelBuilder)
        {
            var entity = modelBuilder.Entity<ClassDb>();

            entity.ToTable("Class");

            entity.HasKey(k => k.Id);

            entity.Property(r => r.Title)
                .HasMaxLength(100)
                .IsRequired();

            entity.Property(p => p.IsActive).IsRequired();
            entity.Property(p => p.AddedDate)
                .HasColumnType("datetime")
                .IsRequired();

            entity.HasOptional(o => o.Enrollments);

        }
    }
}
