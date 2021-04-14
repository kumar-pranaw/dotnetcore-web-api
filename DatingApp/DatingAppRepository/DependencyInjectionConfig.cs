using Microsoft.Extensions.DependencyInjection;

namespace DatingAppRepository
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection AddDatingAppRepository(this IServiceCollection services)
        {
            return services;
        }
    }
}
