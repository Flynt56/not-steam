using System.Threading.Tasks;
using NotSteam.Model.Identity;

namespace NotSteam.Core.Interfaces.Repositories
{
    public interface IAuthUserRepository
    {
        Task<AuthUser> GetByEmailAsync(string email);
    }
}
