using System.Threading.Tasks;
using NotSteam.Infrastructure.Identity;

namespace NotSteam.Infrastructure.Interfaces.Services
{
    public interface IAuthUserService
    {
        Task<AuthUser> GetByEmailAsync(string email);
    }
}
