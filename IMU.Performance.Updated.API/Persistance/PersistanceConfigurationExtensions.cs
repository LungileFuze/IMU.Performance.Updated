using IMU.Performance.Updated.API.Applications.Contracts;
using Microsoft.EntityFrameworkCore;

namespace IMU.Performance.Updated.API.Persistance
{
    public static class PersistanceConfigurationExtensions
    {
        public static IServiceCollection ConfigurePersistance(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<IPerformanceDbContext, PerformanceDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("PerformanceConnection"));
            });
            return services;
        }
    }
}
