using ATA.Application.Common.Context;
using ATA.Application.Interface;
using ATA.Application.Services;

using Microsoft.Extensions.DependencyInjection;

namespace ATA.Application.Config
{
    public static class Bootstrap
    {
        public static IServiceCollection AddApplicationService(this IServiceCollection services)
        {
            services.AddMediatR(c =>
            {
                c.RegisterServicesFromAssembly(typeof(ApplicationEntryPoint).Assembly);
            });

            services.AddTransient<ICurrentUserContext, CurrentUserContext>();
            services.AddTransient<IUserContextService, UserContextService>();
            services.AddTransient<ITenantContext, TenantContext>();

            return services;
        }
    }
}
