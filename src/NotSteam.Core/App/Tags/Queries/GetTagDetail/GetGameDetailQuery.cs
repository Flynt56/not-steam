using MediatR;

namespace NotSteam.Core.App.Tags.Queries.GetTagDetail
{
    public class GetTagDetailQuery : IRequest<TagDetailDto>
    {
        public int Id { get; set; }
    }
}
