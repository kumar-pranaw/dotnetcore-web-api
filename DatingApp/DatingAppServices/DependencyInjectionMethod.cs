using DatingAppServices.DatingAppServices;
using DatingAppServices.IDatingAppServices;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace DatingAppServices
{
    public static class DependencyInjectionMethod
    {
        public static IServiceCollection AddDatingAppServices(this IServiceCollection services)
        {
            services.AddScoped<IAuthService, AuthService>();
            return services;
        }

    }
}
