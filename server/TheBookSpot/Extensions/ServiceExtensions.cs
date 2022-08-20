using Microsoft.EntityFrameworkCore;
using TheBookSpotData;
using TheBookSpotData.Services.AuthorSevices;
using TheBookSpotData.Services.BookServices;

namespace TheBookSpot.Extensions
{
    public static class ServiceExtensions
    {

        public static void ConfigureSqlServerContext(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<TheBookSpotContext>(
                opt => opt.UseSqlServer(config.GetConnectionString("BookSpotConnection"))
                .EnableSensitiveDataLogging()
                .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking));
        }

        public static void ConfigureRepositories(this IServiceCollection services)
        {
            services.AddScoped<IBookService, BookService>();
            services.AddScoped<IAuthorService, AuthorService>();
        }

    }
}
