using InfoWebAPI.InfoWebAX.Application;
using InfoWebAPI.InfoWebAX.Common.Behaviours;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Scrutor;
using System.Reflection;

namespace InfoWebAPI.InfoWebAX
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfoWebAXApplication(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(RequestValidationBehavior<,>));
            services.Scan(scan => scan
                    .FromAssemblyOf<InfoWebAXWrapper>()
                    .AddClasses()
                    .UsingRegistrationStrategy(RegistrationStrategy.Skip)
                    .AsMatchingInterface()
                    .WithScopedLifetime());

            return services;
        }
    }
}