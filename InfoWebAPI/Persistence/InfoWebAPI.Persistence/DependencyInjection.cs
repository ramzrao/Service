using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Scrutor;

namespace InfoWebAPI.Persistence
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<InfoWebDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("InfoWebDb")));

            services.Scan(scan => scan
                    .FromAssemblyOf<UserRepository>()
                    .AddClasses()
                    .UsingRegistrationStrategy(RegistrationStrategy.Skip)
                    .AsMatchingInterface()
                    .WithScopedLifetime());

            return services;
        }
    }
}