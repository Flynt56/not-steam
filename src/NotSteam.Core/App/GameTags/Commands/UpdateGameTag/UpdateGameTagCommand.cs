using MediatR;

namespace NotSteam.Core.App.GameTags.Commands.UpdateGameTag
{
    public class UpdateGameTagCommand : IRequest<UpdateGameTagDto>
    {
        public int GameId { get; set; }
        public int TagId { get; set; }

        public UpdateGameTagDto UpdateGameTagDto { get; set; }
    }
}
