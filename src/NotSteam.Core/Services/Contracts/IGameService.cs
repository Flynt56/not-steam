using System.Threading.Tasks;
using NotSteam.Core.Requests;
using NotSteam.Core.ViewModels.Games;
using NotSteam.Model.Models;
using NotSteam.Shared.Pagination;

namespace NotSteam.Core.Services.Contracts
{
    public interface IGameService
    {
        Task<PagedResult<GamesList>> GetPageAsync(GamePaginationRequest request);
        Task<GameDetails> GetByIdAsync(int id);

        Task<int> DeleteByIdAsync(int id);

        Task<int> AddAsync(Game user);
        Task<int> EditAsync(int id, Game user);

        Task<bool> DoesExist(int id);
    }
}
