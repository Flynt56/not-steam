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
        Task<GameTagDetails> GetByIdAsync(int gameId, int tagId);

        Task<int> DeleteByIdAsync(int gameId, int tagId);

        Task<int> AddAsync(GameTag gameTag);
        Task<int> EditAsync(int gameId, int tagId, GameTag gameTag);

        Task<bool> DoesExist(int gameId, int tagId);
    }
}
