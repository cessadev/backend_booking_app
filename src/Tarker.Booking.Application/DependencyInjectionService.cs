using Microsoft.Extensions.DependencyInjection;

namespace Tarker.Booking.Application
{
    public static class DependencyInjectionService
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            return services;
        }
    }
}
