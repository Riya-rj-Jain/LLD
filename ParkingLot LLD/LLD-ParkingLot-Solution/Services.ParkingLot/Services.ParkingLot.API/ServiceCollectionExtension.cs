using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Services.ParkingLot.API.Data;


namespace Services.ParkingLot.API
{
    public static class ServiceExtensionCollection
    {
        public static IServiceCollection UserAssistServices(this IServiceCollection services, IConfiguration configuration)
        {
            if (configuration == null)
            {
                throw new ArgumentNullException(nameof(configuration));
            }

            var customDbConnectionString = configuration.GetConnectionString("Mysql");

            services.AddDbContext<ParkingLotDbContext>(options =>
            {
                options.UseMySql(
                    customDbConnectionString,
                    ServerVersion.AutoDetect(customDbConnectionString),
                    mysqlOptions =>
                    {
                        mysqlOptions.EnableRetryOnFailure(
                            int.Parse(configuration["DbConnRetryCounts"] ?? "3"));
                       
                    });

            });

            return services;
        }
    }
}