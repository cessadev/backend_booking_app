using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Tarker.Booking.Application.DataBase;
using Tarker.Booking.Persistence.DataBase;

namespace Tarker.Booking.Persistence
{
    public static class DependencyInjectionService
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DataBaseService>(options =>
            options.UseSqlServer(configuration["SQLConnectionString"]));

            services.AddScoped<IDataBaseService, DataBaseService>();

            return services;
        }
    }
}
