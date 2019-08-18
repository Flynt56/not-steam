using System.Threading.Tasks;
using NotSteam.Core.Requests;
using NotSteam.Core.ViewModels.Purchases;
using NotSteam.Model.Models;
using NotSteam.Shared.Pagination;

namespace NotSteam.Core.Services.Contracts
{
    public interface IPurchaseService
    {
        Task<PagedResult<PurchasesList>> GetPageAsync(PurchasePaginationRequest request);
        Task<PurchaseDetails> GetByIdAsync(int userId, int gameId);

        Task<int> DeleteByIdAsync(int userId, int gameId);

        Task<int> AddAsync(Purchase purchase);
        Task<int> EditAsync(int userId, int gameId, Purchase purchase);

        Task<bool> DoesExist(int userId, int gameId);
    }
}
