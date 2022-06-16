using DnD.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class IServiceCollectionExtention
    {
        public static IServiceCollection AddApplicationDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            return services.AddDbContext<ApplicationDbContext>(options => {
                options.EnableDetailedErrors();
                options.UseSqlite(configuration.GetConnectionString("SqliteConnectionString"));
            });
        }
    }
}
