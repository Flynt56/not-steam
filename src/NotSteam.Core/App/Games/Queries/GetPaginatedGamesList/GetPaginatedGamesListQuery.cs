using MediatR;

namespace NotSteam.Core.App.Games.Queries.GetPaginatedGamesList
{
    public class GetPaginatedGamesListQuery : IRequest<PaginatedGameListModel>
    {
        public int Skip { get; set; }
        public int Take { get; set; } = 10;

        public GetPaginatedGamesListQuery(int skip, int take)
        {
            Skip = skip;
            Take = take;
        }
    }
}
