using MediatR;

namespace NotSteam.Api.Core.Tags.Commands.DeleteTag
{
    public class DeleteTagCommand : IRequest
    {
        public int Id { get; set; }
    }
}
