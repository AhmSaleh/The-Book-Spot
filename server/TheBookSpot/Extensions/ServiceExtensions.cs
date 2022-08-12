using Microsoft.EntityFrameworkCore;
using TheBookSpotData;

namespace TheBookSpot.Extensions
{
    public static class ServiceExtensions
    {

        public static void ConfigureSqlServerContext(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<TheBookSpotContext>(
                opt => opt.UseSqlServer(config.GetConnectionString("PubConnection"))
                .EnableSensitiveDataLogging()
                .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking));
        }
    }
}
