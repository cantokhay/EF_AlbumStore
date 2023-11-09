using EF_Maraton_DAL.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_Maraton_DAL.Configurations
{
    internal class ArtistConfigurations : IEntityTypeConfiguration<Artist>
    {
        public void Configure(EntityTypeBuilder<Artist> builder)
        {
            builder.HasData
                (
                    new Artist { Id = 1, Name = "Artist 1" },
                    new Artist { Id = 2, Name = "Artist 2" },
                    new Artist { Id = 3, Name = "Artist 3" },
                    new Artist { Id = 4, Name = "Artist 4" },
                    new Artist { Id = 5, Name = "Artist 5" }
                );
            builder.HasMany(a => a.Albums)
                    .WithOne(a => a.Artist)
                    .HasForeignKey(a => a.ArtistId)
                    .OnDelete(DeleteBehavior.Cascade);
            builder.Property(a => a.Name)
                    .HasMaxLength(64)
                    .IsRequired();
        }
    }
}
