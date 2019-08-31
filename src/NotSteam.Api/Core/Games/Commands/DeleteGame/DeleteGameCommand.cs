using MediatR;

namespace NotSteam.Api.Core.Games.Commands.DeleteGame
{
    public class DeleteGameCommand : IRequest
    {
        public int Id { get; set; }
    }
}
