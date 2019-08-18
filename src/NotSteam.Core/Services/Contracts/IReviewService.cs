using System.Threading.Tasks;
using NotSteam.Core.Requests;
using NotSteam.Core.ViewModels.Reviews;
using NotSteam.Model.Models;
using NotSteam.Shared.Pagination;

namespace NotSteam.Core.Services.Contracts
{
    public interface IReviewService
    {
        Task<PagedResult<ReviewsList>> GetPageAsync(ReviewPaginationRequest request);
        Task<ReviewDetails> GetByIdAsync(int userId, int gameId);

        Task<int> DeleteByIdAsync(int userId, int gameId);

        Task<int> AddAsync(Review review);
        Task<int> EditAsync(int userId, int gameId, Review review);

        Task<bool> DoesExist(int userId, int gameId);
    }
}
