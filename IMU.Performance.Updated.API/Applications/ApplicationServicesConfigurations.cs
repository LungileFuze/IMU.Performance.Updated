using IMU.Performance.Updated.API.Applications.Contracts;
using System.Runtime.CompilerServices;

namespace IMU.Performance.Updated.API.Applications
{
    public static class ApplicationServicesConfigurations
    {
        public static void ConfigureApplicationServices(this IServiceCollection services)
        {
            services.AddTransient<IAgreement, AgreementService>();
        }
    }
}
