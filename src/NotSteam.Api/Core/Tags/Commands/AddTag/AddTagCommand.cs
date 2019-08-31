using MediatR;

namespace NotSteam.Api.Core.Tags.Commands.AddTag
{
    public class AddTagCommand : IRequest<AddTagDto>
    {
        public AddTagDto AddTagDto { get; set; }
    }
}
