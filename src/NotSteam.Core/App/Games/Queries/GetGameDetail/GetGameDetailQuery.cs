using MediatR;

namespace NotSteam.Core.App.Games.Queries.GetGameDetail
{
    public class GetGameDetailQuery : IRequest<GameDetailDto>
    {
        public int Id { get; set; }
    }
}
