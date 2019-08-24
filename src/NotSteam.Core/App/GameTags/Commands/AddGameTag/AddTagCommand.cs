using MediatR;

namespace NotSteam.Core.App.Tags.Commands.AddTag
{
    public class AddTagCommand : IRequest<AddTagDto>
    {
        public AddTagDto AddTagDto { get; set; }
    }
}
