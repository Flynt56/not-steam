using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using NotSteam.Core.Interfaces.Repositories;
using NotSteam.Model.Models;

namespace NotSteam.Api.Core.Games.Commands.AddGame
{
    public class AddGameCommandHandler : IRequestHandler<AddGameCommand, AddGameDto>
    {
        private readonly IAsyncRepository<Game> _gameRepository;
        private readonly IMapper _mapper;

        public AddGameCommandHandler(IAsyncRepository<Game> gameRepository, IMapper mapper)
        {
            _gameRepository = gameRepository;
            _mapper = mapper;
        }

        public async Task<AddGameDto> Handle(AddGameCommand request, CancellationToken cancellationToken)
        {
            return _mapper.Map<AddGameDto>(
                await _gameRepository
                .AddAsync(_mapper.Map<Game>(request.AddGameDto)));
        }
    }
}
