using ATA.Application.Interface;
using ATA.Application.Models;
using ATA.Infrastructure.Persistance.Sql.DabaseContext;
using ATA.Infrastructure.Persistance.Sql.Repository;
using ATA.Infrastructure.Providers.NotificationService;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

using System.Net;
using System.Net.Mail;

namespace ATA.Infrastructure.Config
{
    public static class Bootstrap
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<SmtpSettings>(configuration.GetSection("SmtpSettings"));
            services.AddDbContext(configuration);
            services.AddFluentEmail();

            services.AddScoped(typeof(IGenericRepositoryBuilder<>), typeof(GenericRepositoryBuilder<>));
            services.AddScoped<IEmailService, EmailService>();

            return services;
        }

        private static IServiceCollection AddDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationContext>(o =>
            {
                o.UseSqlServer(
                    configuration.GetConnectionString("ApplicationContext"),
                    builder =>
                    {
                        builder.EnableRetryOnFailure(3);
                        builder.CommandTimeout(30);
                    });
            });

            return services;
        }

        private static void AddFluentEmail(this IServiceCollection services)
        {
            var serviceProvider = services.BuildServiceProvider();
            var smtpSettings = serviceProvider.GetRequiredService<IOptions<SmtpSettings>>().Value;

            var smtpClient = new SmtpClient
            {
                Host = smtpSettings.Host,
                Port = smtpSettings.Port,
                EnableSsl = smtpSettings.EnableSSL,
                UseDefaultCredentials = false,
                DeliveryMethod = (SmtpDeliveryMethod)Enum.Parse(typeof(SmtpDeliveryMethod), smtpSettings.DeliveryMethod),
                Credentials = new NetworkCredential(smtpSettings.From, smtpSettings.Password)
            };

            services
                .AddFluentEmail(smtpSettings.From, smtpSettings.DisplayName)
                .AddSmtpSender(smtpClient)
                .AddRazorRenderer();
        }
    }
}
