using Microsoft.Extensions.DependencyInjection;
using NotSteam.Core.Interfaces.Services;
using NotSteam.Core.Services;

namespace NotSteam.Core.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddNotSteamServices(this IServiceCollection services)
        {
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IUserService, UserService>();
        }
    }
}
