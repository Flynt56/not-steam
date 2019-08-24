using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using NotSteam.Core.Exceptions;
using NotSteam.Core.Interfaces.Repositories;
using NotSteam.Model.Models;

namespace NotSteam.Core.App.Games.Commands.DeleteGame
{
    public class DeleteGameCommandHandler : IRequestHandler<DeleteGameCommand>
    {
        private readonly IAsyncRepository<Game> _gameRepository;
        private readonly IMapper _mapper;

        public DeleteGameCommandHandler(IAsyncRepository<Game> gameRepository, IMapper mapper)
        {
            _gameRepository = gameRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(DeleteGameCommand request, CancellationToken cancellationToken)
        {
            var entity = await _gameRepository
                .GetByIdAsync(request.Id);

            if (entity == null)
            {
                throw new NotFoundException(nameof(Game), request.Id);
            }

            await _gameRepository
                .DeleteAsync(entity);

            return Unit.Value;
        }
    }
}
