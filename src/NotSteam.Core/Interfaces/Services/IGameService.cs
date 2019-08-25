using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using NotSteam.Core.App.Games.Queries.GetPaginatedGamesList;
using NotSteam.Shared.Pagination;

namespace NotSteam.Core.Interfaces.Services
{
    public interface IGameService
    {
        Task<PagedResult<GamesPageEntryDto>> GetPageAsync(GetGamesPageRequest request);
    }
}
