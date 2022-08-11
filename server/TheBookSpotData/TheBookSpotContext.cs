using Microsoft.EntityFrameworkCore;
using TheBookSpotDomain;
using TheBookStoreDomain;

namespace TheBookSpotData
{
    internal class TheBookSpotContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

        public TheBookSpotContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
