using Microsoft.AspNetCore.Identity;
using NotSteam.Infrastructure.Identity.Models;
using System.Threading.Tasks;

namespace NotSteam.Infrastructure.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedAsync(UserManager<ApplicationUser> userManager)
        {
            var defaultUser = new ApplicationUser { UserName = "TestUser", Email = "TestUser@test.com" };
            await userManager.CreateAsync(defaultUser, "Pass123@@");
        }
    }
}
