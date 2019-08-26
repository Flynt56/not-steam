using System.Threading.Tasks;
using NotSteam.Model.Identity;

namespace NotSteam.Core.Interfaces.Repositories
{
    public interface IUserRepository
    {
        Task<AuthUser> GetByEmailAsync(string email);
    }
}
