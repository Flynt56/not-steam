using System.Threading.Tasks;
using NotSteam.Model.Identity.Models;

namespace NotSteam.Core.Interfaces.Services
{
    public interface IUserService : IAppService
    {
        Task<ApplicationUser> GetByEmailAsync(string email);
    }
}
