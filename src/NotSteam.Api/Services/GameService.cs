using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using NotSteam.Core.App.Games.Queries.GetPaginatedGamesList;
using NotSteam.Core.Interfaces.Repositories;
using NotSteam.Core.Interfaces.Services;
using NotSteam.Shared.Pagination;
using NotSteam.Shared.Extensions;

namespace NotSteam.Api.Services
{
    public class GameService : IGameService
    {
        private readonly IGameRepository GameRepository;
        private readonly IMapper Mapper;

        public GameService(IGameRepository gameRepository, IMapper mapper)
        {
            GameRepository = gameRepository;
            Mapper = mapper;
        }

        public async Task<PagedResult<GamesPageEntryDto>> GetPageAsync(GetGamesPageRequest request)
        {
            return await GameRepository
                        .GetAll()
                        .Include(a => a.GameTags)
                        .ProjectTo<GamesPageEntryDto>(Mapper.ConfigurationProvider)
                        .ToPagedResultAsync(request);
        }
    }
}
