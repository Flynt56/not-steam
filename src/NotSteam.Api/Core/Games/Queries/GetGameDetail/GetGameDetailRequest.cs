using MediatR;

namespace NotSteam.Api.Core.Games.Queries.GetGameDetail
{
    public class GetGameDetailRequest : IRequest<GetGameDetailResponseDto>
    {
        public int Id { get; set; }
    }
}
