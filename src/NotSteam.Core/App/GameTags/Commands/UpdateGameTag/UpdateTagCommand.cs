using MediatR;

namespace NotSteam.Core.App.Tags.Commands.UpdateTag
{
    public class UpdateTagCommand : IRequest<UpdateTagDto>
    {
        public int Id { get; set; }

        public UpdateTagDto UpdateTagDto { get; set; }
    }
}
