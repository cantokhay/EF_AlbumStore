using EF_Maraton_DAL.Entites;
using Microsoft.EntityFrameworkCore;

namespace EF_Maraton_DAL.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Admin> Admins { get; set; }


        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=CAN-TOKHAY-MASA\SQLEXPRESS;Database=MusicStoreDB;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder builder)
            => builder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }
}
