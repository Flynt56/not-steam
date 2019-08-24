using System.Threading.Tasks;
using NotSteam.Model.Models;

namespace NotSteam.Core.Interfaces.Services
{
    public interface IUserService : IAppService
    {
        Task<AuthUser> GetByEmailAsync(string email);
    }
}
