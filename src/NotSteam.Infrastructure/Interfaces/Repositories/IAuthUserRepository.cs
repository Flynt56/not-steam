using System.Threading.Tasks;
using NotSteam.Infrastructure.Identity;

namespace NotSteam.Infrastructure.Interfaces.Repositories
{
    public interface IAuthUserRepository
    {
        Task<AuthUser> GetByEmailAsync(string email);
    }
}
