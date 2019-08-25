using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NotSteam.Core.Interfaces.DB;
using NotSteam.Core.Interfaces.Services;
using NotSteam.Model.Models;

namespace NotSteam.Api.Services
{
    public class UserService : IUserService
    {
        private readonly INotSteamContext _context;

        public UserService(INotSteamContext context)
        {
            _context = context;
        }

        public async Task<AuthUser> GetByEmailAsync(string email)
        {
            return await _context.Users
                .Where(u => u.Email == email)
                .Select(u => new AuthUser
                {
                    Id = u.Id,
                    Email = u.Email
                }).FirstAsync();
        }
    }
}
