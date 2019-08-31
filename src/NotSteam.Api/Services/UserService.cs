using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NotSteam.Core.Interfaces.Services;
using NotSteam.Infrastructure.Data;
using NotSteam.Model.Identity.Models;

namespace NotSteam.Api.Services
{
    public class UserService : IUserService
    {
        private readonly NotSteamContext Context;

        public UserService(NotSteamContext context)
        {
            Context = context;
        }

        public async Task<ApplicationUser> GetByEmailAsync(string email)
        {
            return await Context.Users
                .Where(u => u.Email == email)
                .Select(u => new ApplicationUser
                {
                    Id = u.Id,
                    Email = u.Email
                })
                .FirstAsync();
        }
    }
}
