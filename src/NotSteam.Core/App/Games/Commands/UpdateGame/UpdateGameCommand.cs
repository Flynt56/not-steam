using MediatR;

namespace NotSteam.Core.App.Games.Commands.UpdateGame
{
    public class UpdateGameCommand : IRequest<UpdateGameDto>
    {
        public int Id { get; set; }

        public UpdateGameDto UpdateGameDto { get; set; }
    }
}
