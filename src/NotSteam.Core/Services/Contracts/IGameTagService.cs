using System.Threading.Tasks;
using NotSteam.Core.Requests;
using NotSteam.Core.ViewModels.GameTags;
using NotSteam.Model.Models;
using NotSteam.Shared.Pagination;

namespace NotSteam.Core.Services.Contracts
{
    public interface IGameTagService
    {
        Task<PagedResult<GameTagsList>> GetPageAsync(GameTagPaginationRequest request);
        Task<GameTagDetails> GetByIdAsync(int id);

        Task<int> DeleteByIdAsync(int id);

        Task<int> AddAsync(GameTag user);
        Task<int> EditAsync(int id, GameTag user);

        Task<bool> DoesExist(int id);
    }
}
