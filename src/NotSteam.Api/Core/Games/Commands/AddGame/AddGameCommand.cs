using MediatR;

namespace NotSteam.Api.Core.Games.Commands.AddGame
{
    public class AddGameCommand : IRequest<AddGameDto>
    {
        public AddGameDto AddGameDto { get; set; }
    }
}
