using Microsoft.EntityFrameworkCore;
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

    }
}
