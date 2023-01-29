using Microsoft.EntityFrameworkCore;
using WebApi_InMemoryDb.Model;

namespace WebApi_InMemoryDb.Data
{
    public class FilmDbContext : DbContext
    {
        public FilmDbContext(DbContextOptions<FilmDbContext> options) : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>();
            modelBuilder.Seed();
        }
    }

    
}
