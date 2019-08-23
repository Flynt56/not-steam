using System.Collections.Generic;
using System.Threading.Tasks;
using NotSteam.Core.Requests;
using NotSteam.Core.ViewModels.Users;
using NotSteam.Model.Models;
using NotSteam.Shared.Pagination;

namespace NotSteam.Core.Interfaces.Services
{
    public interface IUserService
    {
        Task<PagedResult<UsersList>> GetPageAsync(UserPaginationRequest request);
        Task<UserDetails> GetByIdAsync(int id);

        Task<IEnumerable<UsersDropdown>> GetDropdown();

        Task<int> DeleteByIdAsync(int id);

        Task<int> AddAsync(User user);
        Task<int> EditAsync(int id, User user);

        Task<bool> DoesExist(int id);
    }
}
