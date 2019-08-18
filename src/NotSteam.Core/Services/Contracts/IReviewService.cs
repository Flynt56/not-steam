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
        Task<ReviewDetails> GetByIdAsync(int id);

        Task<int> DeleteByIdAsync(int id);

        Task<int> AddAsync(Review user);
        Task<int> EditAsync(int id, Review user);

        Task<bool> DoesExist(int id);
    }
}
