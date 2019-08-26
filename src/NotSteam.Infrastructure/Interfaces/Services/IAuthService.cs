using System.Threading.Tasks;
using NotSteam.Core.Interfaces.Services;

namespace NotSteam.Infrastructure.Interfaces.Services
{
    public interface IAuthService : IAppService
    {
        Task<string> SignInAsync(string email, string password);
        Task<string> RegisterAsync(string email, string password);
    }
}
