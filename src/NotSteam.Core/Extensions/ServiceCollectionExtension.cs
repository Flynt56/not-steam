using Microsoft.Extensions.DependencyInjection;
using NotSteam.Core.Services;
using NotSteam.Core.Services.Contracts;

namespace NotSteam.Core.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddNotSteamServices(this IServiceCollection services)
        {
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IGameService, GameService>();
            services.AddTransient<ICompanyService, CompanyService>();
            services.AddTransient<IReviewService, ReviewService>();
            services.AddTransient<ILibraryService, LibraryService>();
            services.AddTransient<ITagService, TagService>();
            services.AddTransient<IGameTagService, GameTagService>();
            services.AddTransient<IPurchaseService, PurchaseService>();
        }
    }
}
