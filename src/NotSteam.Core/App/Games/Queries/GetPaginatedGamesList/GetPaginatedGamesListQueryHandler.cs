using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using NotSteam.Core.Interfaces.Repositories;
using NotSteam.Shared.Extensions;
using NotSteam.Shared.Pagination;

namespace NotSteam.Core.App.Games.Queries.GetPaginatedGamesList
{
    public class GetPaginatedGamesListQueryHandler : IRequestHandler<GetPaginatedGamesListQuery, PagedResult<GamesListEntryDto>>
    {
        private readonly IGameRepository _gameRepository;
        private readonly IMapper _mapper;

        public GetPaginatedGamesListQueryHandler(IGameRepository gameRepository, IMapper mapper)
        {
            _gameRepository = gameRepository;
            _mapper = mapper;
        }

        public async Task<PagedResult<GamesListEntryDto>> Handle(GetPaginatedGamesListQuery request, CancellationToken cancellationToken)
        {
            return await _gameRepository.GetAll()
                .Include(a => a.GameTags)
                .ProjectTo<GamesListEntryDto>(_mapper.ConfigurationProvider)
                .ToPagedResultAsync(request);
        }
    }
}
