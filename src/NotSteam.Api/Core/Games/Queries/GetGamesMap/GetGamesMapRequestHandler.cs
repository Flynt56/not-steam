using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using NotSteam.Core.Interfaces.Repositories;
using NotSteam.Model.Models;

namespace NotSteam.Api.Core.Games.Queries.GetGamesMap
{
    public class GetGamesMapRequestHandler : IRequestHandler<GetGamesMapRequest, IEnumerable<GamesMapEntryDto>>
    {
        private readonly IAsyncRepository<Game> _gameRepository;
        private readonly IMapper _mapper;

        public GetGamesMapRequestHandler(IAsyncRepository<Game> gameRepository, IMapper mapper)
        {
            _gameRepository = gameRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<GamesMapEntryDto>> Handle(GetGamesMapRequest request, CancellationToken cancellationToken)
        {
            return await _gameRepository.GetAll()
                .ProjectTo<GamesMapEntryDto>(_mapper.ConfigurationProvider)
                .ToListAsync();
        }
    }
}
