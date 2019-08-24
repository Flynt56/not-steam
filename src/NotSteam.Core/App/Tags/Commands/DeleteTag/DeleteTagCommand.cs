using MediatR;

namespace NotSteam.Core.App.Games.Commands.DeleteGame
{
    public class DeleteGameCommand : IRequest
    {
        public int Id { get; set; }
    }
}
