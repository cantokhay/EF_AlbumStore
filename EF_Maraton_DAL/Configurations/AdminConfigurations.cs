using EF_Maraton_DAL.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_Maraton_DAL.Configurations
{
    internal class AdminConfigurations : IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder)
        {
            builder.HasData
                (
                    new Admin { Id = 1, Name = "CanTokhay", Password = "CAntokhay!!123456" },
                    new Admin { Id = 2, Name = "Admin2", Password = "CAntokhay!!123456" }
                );
            builder.Property(a => a.Name)
                    .HasColumnName("UserName")
                    .HasMaxLength(64)
                    .IsRequired();
            builder.Property(a => a.Password)
                    .HasMaxLength(64)
                    .IsRequired();
        }
    }
}
