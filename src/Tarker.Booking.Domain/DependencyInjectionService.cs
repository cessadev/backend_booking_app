using Microsoft.Extensions.DependencyInjection;

namespace Tarker.Booking.Domain
{
    public static class DependencyInjectionService
    {
        public static IServiceCollection AddDomain(this IServiceCollection services)
        {
            return services;
        }
    }
}
