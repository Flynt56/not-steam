using MediatR;

namespace NotSteam.Core.App.Games.Queries.GetPaginatedGamesList
{
    public class GetPaginatedGamesListQuery : IRequest<GamePaginationRequest>
    {
    }
}
