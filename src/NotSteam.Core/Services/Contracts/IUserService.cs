using System.Threading.Tasks;
using NotSteam.Core.Requests;
using NotSteam.Core.ViewModels;
using NotSteam.Model.Models;
using NotSteam.Shared.Pagination;

namespace NotSteam.Core.Services.Contracts
{
    public interface IUserService
    {
        Task<PagedResult<UsersList>> GetPageAsync(UserPaginationRequest request);
        Task<UserDetails> GetByIdAsync(int id);

        Task<int> DeleteByIdAsync(int id);

        Task<int> AddAsync(User user);
        Task<int> EditAsync(int id, User user);

        Task<bool> DoesExist(int id);
    }
}
