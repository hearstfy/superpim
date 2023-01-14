using Microsoft.Extensions.DependencyInjection;
using SuperPIM.Application.Common.Interfaces.Services;
using SuperPIM.Application.Services;

namespace SuperPIM.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddAppServices(this IServiceCollection services)
        {

            services.AddTransient<ITenantService, TenantService>();
            services.AddTransient<IUserService, UserService>();

            return services;
        }
    }
}
