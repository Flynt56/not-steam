using System.Threading.Tasks;
using NotSteam.Model.Identity;

namespace NotSteam.Core.Interfaces.Services
{
    public interface IUserService : IAppService
    {
        Task<AuthUser> GetByEmailAsync(string email);
    }
}
