using Microsoft.EntityFrameworkCore;
using TheBookSpotData.Seed;
using TheBookSpotDomain.Entities;

namespace TheBookSpotData
{
    public class TheBookSpotContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

        public TheBookSpotContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var authors = AuthorSeeder.Seed();
            modelBuilder.Entity<Author>().HasData(authors);
            modelBuilder.Entity<Book>().HasData(BookSeeder.Seed(authors));

        }

    }
}
