using MediatR;
using NotSteam.Model.Models;
using System.Collections.Generic;

namespace NotSteam.Core.App.Games.Queries.GetPaginatedGamesList
{
    public class GetPaginatedGamesListQuery : IRequest<PaginatedGameListModel>
    {
        // TODO (@IBenko): Page# and Page size instead of skip and take. That's how the frontend deals with paging.
        public int Skip { get; set; }
        public int Take { get; set; } = 10;

        public GetPaginatedGamesListQuery(int page, int pageSize)
        {
            Skip = (page - 1) * pageSize;
            Take = pageSize;
        }
    }
}
