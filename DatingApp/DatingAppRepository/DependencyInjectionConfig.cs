using DatingAppRepository.DatingAppRepository;
using DatingAppRepository.IDatingAppRepository;
using Microsoft.Extensions.DependencyInjection;

namespace DatingAppRepository
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection AddDatingAppRepository(this IServiceCollection services)
        {
            services.AddScoped<IAuthenticationRepository, AuthenticationRepository>();
            return services;
        }
    }
}
