using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NotSteam.Core.Interfaces.Repositories;
using NotSteam.Infrastructure.DB;
using NotSteam.Model.Identity;

namespace NotSteam.Infrastructure.Repositories
{
    public class AuthUserRepository : IAuthUserRepository
    {
        private readonly NotSteamContext Context;

        public AuthUserRepository(NotSteamContext context)
        {
            Context = context;
        }

        public async Task<AuthUser> GetByEmailAsync(string email)
        {
            return await Context.Users
                .Where(u => u.Email == email)
                .FirstAsync();
        }
    }
}
