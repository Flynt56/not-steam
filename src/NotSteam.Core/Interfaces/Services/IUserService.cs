using System.Threading.Tasks;
using NotSteam.Model.Interfaces.Entities;

namespace NotSteam.Core.Interfaces.Services
{
    public interface IUserService : IAppService
    {
        Task<IUser> GetByEmailAsync(string email);
    }
}
