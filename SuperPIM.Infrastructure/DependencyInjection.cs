using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using SuperPIM.Domain.Common.Interfaces.Persistance;
using SuperPIM.Infrastructure.Persistance.DbContexts;
using SuperPIM.Infrastructure.Persistance.Repositories;

namespace SuperPIM.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistance(this IServiceCollection services, IConfiguration configuration)
        {
            var serverVersion = new MariaDbServerVersion(ServerVersion.AutoDetect(configuration.GetConnectionString("MariaDB")));

            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseMySql(configuration.GetConnectionString("MariaDB"), serverVersion)
                .LogTo(Console.WriteLine, LogLevel.Information)
                .EnableSensitiveDataLogging()
                .EnableDetailedErrors();
            });

            services.AddTransient<ITenantRepository, TenantRepository>();
            services.AddTransient<IUserRepository, UserRepository>();

            return services;
        }
    }
}
