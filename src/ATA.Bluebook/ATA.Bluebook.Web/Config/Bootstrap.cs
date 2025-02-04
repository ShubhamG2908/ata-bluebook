using Microsoft.AspNetCore.Authentication.Cookies;

namespace ATA.Web.Config
{
    public static class Bootstrap
    {
        public static IServiceCollection AddWebServices(this IServiceCollection services)
        {
            services.AddControllersWithViews()
                        .AddJsonOptions(options => options.JsonSerializerOptions.PropertyNamingPolicy = null);

            services.AddHttpContextAccessor();

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                       .AddCookie(options =>
                       {
                           options.LoginPath = "/Account/Login";
                           options.LogoutPath = "/Account/Logout";
                           options.AccessDeniedPath = "/Account/AccessDenied";
                           options.ExpireTimeSpan = TimeSpan.FromMinutes(30);
                           options.SlidingExpiration = true;
                           options.Cookie.HttpOnly = true;
                       });

            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(30);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });

            return services;
        }
    }
}
