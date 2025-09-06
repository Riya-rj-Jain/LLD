using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Services.ParkingLot.API.Data;
using Services.ParkingLot.API.Data.Repositories;
using Services.ParkingLot.API.Interfaces;
using Services.ParkingLot.API.Services;

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

            services.AddScoped<IFloorInterface, FloorRepository>();
            services.AddScoped<FloorService>(); 

            return services;
        }
    }
}
