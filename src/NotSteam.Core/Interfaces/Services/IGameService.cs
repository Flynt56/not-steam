using System.Collections.Generic;
using System.Threading.Tasks;
using NotSteam.Core.App.Games.Queries.GetGameDetail;
using NotSteam.Core.App.Games.Queries.GetPaginatedGamesList;
using NotSteam.Core.ViewModels.Games;
using NotSteam.Model.Models;
using NotSteam.Shared.Pagination;

namespace NotSteam.Core.Interfaces.Services
{
    public interface IGameService
    {
        Task<PagedResult<GamesList>> GetPageAsync(GetPaginatedGamesListQuery request);
        Task<GameDetails> GetByIdAsync(int id);

        Task<IEnumerable<GamesDropdown>> GetDropdown();

        Task<int> DeleteByIdAsync(int id);

        Task<int> AddAsync(Game user);
        Task<int> EditAsync(int id, Game user);

        Task<bool> DoesExist(int id);
    }
}
