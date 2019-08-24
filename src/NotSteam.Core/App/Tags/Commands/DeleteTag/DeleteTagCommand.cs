using MediatR;

namespace NotSteam.Core.App.Tags.Commands.DeleteTag
{
    public class DeleteTagCommand : IRequest
    {
        public int Id { get; set; }
    }
}
