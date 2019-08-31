using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using NotSteam.Core.Interfaces.Repositories;
using NotSteam.Model.Entities;

namespace NotSteam.Api.Core.Games.Commands.UpdateGame
{
    public class UpdateGameCommandHandler : IRequestHandler<UpdateGameCommand, UpdateGameDto>
    {
        private readonly IAsyncRepository<Game> _gameRepository;
        private readonly IMapper _mapper;

        public UpdateGameCommandHandler(IAsyncRepository<Game> gameRepository, IMapper mapper)
        {
            _gameRepository = gameRepository;
            _mapper = mapper;
        }

        public async Task<UpdateGameDto> Handle(UpdateGameCommand request, CancellationToken cancellationToken)
        {
            await _gameRepository
                .UpdateAsync(_mapper.Map<Game>(request.UpdateGameDto));

            return request.UpdateGameDto;
        }
    }
}
