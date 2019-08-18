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
        Task<PurchaseDetails> GetByIdAsync(int id);

        Task<int> DeleteByIdAsync(int id);

        Task<int> AddAsync(Purchase user);
        Task<int> EditAsync(int id, Purchase user);

        Task<bool> DoesExist(int id);
    }
}
