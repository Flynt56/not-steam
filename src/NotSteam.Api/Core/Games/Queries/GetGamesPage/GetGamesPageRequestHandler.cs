using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using NotSteam.Core.Interfaces.Repositories;
using NotSteam.Shared.Extensions;
using NotSteam.Shared.Pagination;

namespace NotSteam.Api.Core.Games.Queries.GetGamesPage
{
    public class GetGamesPageRequestHandler : IRequestHandler<GetGamesPageRequest, PagedResult<GetGamesPageEntryResponseDto>>
    {
        private readonly IGameRepository _gameRepository;
        private readonly IMapper _mapper;

        public GetGamesPageRequestHandler(IGameRepository gameRepository, IMapper mapper)
        {
            _gameRepository = gameRepository;
            _mapper = mapper;
        }

        public async Task<PagedResult<GetGamesPageEntryResponseDto>> Handle(GetGamesPageRequest request, CancellationToken cancellationToken)
        {
            return await _gameRepository.GetAll()
                .Include(a => a.GameTags)
                .ProjectTo<GetGamesPageEntryResponseDto>(_mapper.ConfigurationProvider)
                .ToPagedResultAsync(request);
        }
    }
}
