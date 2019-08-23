using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using NotSteam.Core.Interfaces.Repositories;
using NotSteam.Core.Specifications;
using NotSteam.Model.Models;

namespace NotSteam.Core.App.Games.Queries.GetPaginatedGamesList
{
    public class GetPaginatedGamesListQueryHandler : IRequestHandler<GetPaginatedGamesListQuery, PaginatedGameListModel>
    {
        private readonly IAsyncRepository<Game> _gameRepository;
        private readonly IMapper _mapper;

        public GetPaginatedGamesListQueryHandler(IAsyncRepository<Game> gameRepository, IMapper mapper)
        {
            _gameRepository = gameRepository;
            _mapper = mapper;
        }

        public async Task<PaginatedGameListModel> Handle(GetPaginatedGamesListQuery request, CancellationToken cancellationToken)
        {
            return _mapper.Map<PaginatedGameListModel>(await _gameRepository.ListAsync(new PaginatedGamesListSpecification(request.Skip, request.Take, null)));
        }
    }
}
