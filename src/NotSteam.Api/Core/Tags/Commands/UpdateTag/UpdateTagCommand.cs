using MediatR;

namespace NotSteam.Api.Core.Tags.Commands.UpdateTag
{
    public class UpdateTagCommand : IRequest<UpdateTagDto>
    {
        public int Id { get; set; }

        public UpdateTagDto UpdateTagDto { get; set; }
    }
}
