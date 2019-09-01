using System.Threading.Tasks;
using NotSteam.Model.Identity;

namespace NotSteam.Core.Interfaces.Services
{
    public interface IAuthService : IAppService
    {
        Task<string> SignInAsync(string email, string password);
        Task<string> RegisterAsync(AuthUser user, string password);
    }
}
