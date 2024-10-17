using BulkyWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }

        public DbSet<Category> Categories { get; set; } // automatically create table thanks to FrameworkCore

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Horror", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Romance", DisplayOrder = 3 },
                new Category { Id = 4, Name = "Thriller", DisplayOrder = 4 },
                new Category { Id = 5, Name = "Comedy", DisplayOrder = 5 },
                new Category { Id = 6, Name = "RomCom", DisplayOrder = 6 },
                new Category { Id = 7, Name = "SciFi", DisplayOrder = 7 }
                );
        }
    }
}
