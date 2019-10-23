using InfoWebAPI.Application.Auth.Jwt;
using InfoWebAPI.Application.Common.Behaviours;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Scrutor;
using System.Reflection;

namespace InfoWebAPI.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddCoreApplication(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(RequestValidationBehavior<,>));

            services.Scan(scan => scan
                    .FromAssemblyOf<JwtFactory>()
                    .AddClasses()
                    .UsingRegistrationStrategy(RegistrationStrategy.Skip)
                    .AsMatchingInterface()
                    .WithScopedLifetime());

            return services;
        }
    }
}