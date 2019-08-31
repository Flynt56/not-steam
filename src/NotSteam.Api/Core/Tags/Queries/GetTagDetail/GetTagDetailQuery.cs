using MediatR;

namespace NotSteam.Api.Core.Tags.Queries.GetTagDetail
{
    public class GetTagDetailQuery : IRequest<TagDetailDto>
    {
        public int Id { get; set; }
    }
}
