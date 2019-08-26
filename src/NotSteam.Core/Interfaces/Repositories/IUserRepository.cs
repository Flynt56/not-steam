using System.Threading.Tasks;
using NotSteam.Model.Interfaces.Entities;

namespace NotSteam.Core.Interfaces.Repositories
{
    public interface IUserRepository
    {
        Task<IUser> GetByEmailAsync(string email);
    }
}
