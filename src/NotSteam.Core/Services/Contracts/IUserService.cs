using System.Threading.Tasks;
using NotSteam.Api.Requests;
using NotSteam.Api.Responses;
using NotSteam.Shared.Pagination;

namespace NotSteam.Api.Services.Contracts
{
    public interface IUserService
    {
        Task<PagedResult<UserPaginationResponse>> GetPageAsync(UserPaginationRequest request);
        Task<UserPaginationResponse> GetByIdAsync(long id);

        Task<int> DeleteByIdAsync(long id);
    }
}
