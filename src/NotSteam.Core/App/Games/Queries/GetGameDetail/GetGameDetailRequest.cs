using MediatR;

namespace NotSteam.Core.App.Games.Queries.GetGameDetail
{
    public class GetGameDetailRequest : IRequest<GetGameDetailResponseDto>
    {
        public int Id { get; private set; }
    }
}
