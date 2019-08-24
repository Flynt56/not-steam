using Microsoft.Extensions.DependencyInjection;

namespace NotSteam.Core.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddNotSteamServices(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IGameService, GameService>();
            services.AddScoped<ICompanyService, CompanyService>();
            services.AddScoped<IReviewService, ReviewService>();
            services.AddScoped<ILibraryService, LibraryService>();
            services.AddScoped<ITagService, TagService>();
            services.AddScoped<IGameTagService, GameTagService>();
            services.AddScoped<IPurchaseService, PurchaseService>();
        }
    }
}
