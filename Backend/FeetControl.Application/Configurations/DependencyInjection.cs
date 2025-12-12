using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FeetControl.Infrastructure.Configurations
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            //services.AddDbContext<FeetControlDbContext>(options =>
            //    options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            // Repositórios
            // services.AddScoped<IVehicleRepository, VehicleRepository>();
            // services.AddScoped<IDriverRepository, DriverRepository>();
            // etc.

            return services;
        }
    }
}
