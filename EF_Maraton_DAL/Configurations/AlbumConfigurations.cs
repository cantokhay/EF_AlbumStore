using EF_Maraton_DAL.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_Maraton_DAL.Configurations
{
    internal class AlbumConfigurations : IEntityTypeConfiguration<Album>
    {
        public void Configure(EntityTypeBuilder<Album> builder)
        {
            builder.HasData
                (
                    new Album { Id = 1, Name = "Album 1", PublishDate = new DateTime(2020, 1, 1), Price = 100, DiscountRate = 10, IsActivelySold = true, ArtistId = 1 },
                    new Album { Id = 2, Name = "Album 2", PublishDate = new DateTime(2021, 2, 1), Price = 100, DiscountRate = 12, IsActivelySold = true, ArtistId = 1 },
                    new Album { Id = 3, Name = "Album 3", PublishDate = new DateTime(1992, 3, 1), Price = 120, DiscountRate = 0, IsActivelySold = false, ArtistId = 1 },
                    new Album { Id = 4, Name = "Album 4", PublishDate = new DateTime(2023, 4, 1), Price = 30, DiscountRate = 15, IsActivelySold = true, ArtistId = 2 },
                    new Album { Id = 5, Name = "Album 5", PublishDate = new DateTime(2023, 5, 1), Price = 40, DiscountRate = 5, IsActivelySold = true, ArtistId = 2 },
                    new Album { Id = 6, Name = "Album 6", PublishDate = new DateTime(2023, 6, 1), Price = 60, DiscountRate = 5, IsActivelySold = true, ArtistId = 2 },
                    new Album { Id = 7, Name = "Album 7", PublishDate = new DateTime(2022, 7, 1), Price = 120, DiscountRate = 7, IsActivelySold = true, ArtistId = 3 },
                    new Album { Id = 8, Name = "Album 8", PublishDate = new DateTime(2019, 8, 1), Price = 125, DiscountRate = 8, IsActivelySold = true, ArtistId = 3 },
                    new Album { Id = 9, Name = "Album 9", PublishDate = new DateTime(2019, 9, 1), Price = 120, DiscountRate = 9, IsActivelySold = true, ArtistId = 3 },
                    new Album { Id = 10, Name = "Album 10", PublishDate = new DateTime(1983, 10, 1), Price = 10, DiscountRate = 0, IsActivelySold = false, ArtistId = 4 },
                    new Album { Id = 11, Name = "Album 11", PublishDate = new DateTime(2022, 11, 1), Price = 110, DiscountRate = 0, IsActivelySold = true, ArtistId = 4 },
                    new Album { Id = 12, Name = "Album 12", PublishDate = new DateTime(2022, 12, 1), Price = 121, DiscountRate = 10, IsActivelySold = true, ArtistId = 4 },
                    new Album { Id = 13, Name = "Album 13", PublishDate = new DateTime(2023, 1, 1), Price = 99, DiscountRate = 18, IsActivelySold = true, ArtistId = 5 },
                    new Album { Id = 14, Name = "Album 14", PublishDate = new DateTime(2023, 2, 1), Price = 97, DiscountRate = 3, IsActivelySold = true, ArtistId = 5 },
                    new Album { Id = 15, Name = "Album 15", PublishDate = new DateTime(2023, 3, 1), Price = 150, DiscountRate = 0, IsActivelySold = false, ArtistId = 5 }
                );

            builder.HasOne(a => a.Artist)
                    .WithMany(a => a.Albums)
                    .HasForeignKey(a => a.ArtistId)
                    .OnDelete(DeleteBehavior.NoAction);
            builder.Property(a => a.Name)
                    .HasMaxLength(128);
            builder.Property(a => a.PublishDate)
                    .HasColumnType("date")
                    .IsRequired();
            builder.Property(a => a.Price)
                    .HasColumnType("decimal(18,2)")
                    .IsRequired();
            builder.Property(a => a.DiscountRate)
                    .HasColumnType("decimal(18,2)")
                    .IsRequired();
            builder.Property(a => a.IsActivelySold)
                    .IsRequired();
        }
    }
}
