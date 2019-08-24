using MediatR;

namespace NotSteam.Core.App.GameTags.Queries.GetGameTagDetail
{
    public class GetGameTagDetailQuery : IRequest<GameTagDetailDto>
    {
        public int GameId { get; set; }
        public int TagId { get; set; }
    }
}
