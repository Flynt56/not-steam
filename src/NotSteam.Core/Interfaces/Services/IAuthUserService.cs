using System.Threading.Tasks;
using NotSteam.Model.Identity;

namespace NotSteam.Core.Interfaces.Services
{
    public interface IAuthUserService
    {
        Task<AuthUser> GetByEmailAsync(string email);
    }
}
