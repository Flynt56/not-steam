using MediatR;
using System;

namespace NotSteam.Core.App.Games.Queries.GetPaginatedGamesList
{
    public class GetPaginatedGamesListQuery : IRequest<PaginatedGameListModel>
    {
        // TODO (@IBenko): Page# and Page size instead of skip and take. That's how the frontend deals with paging.
        public int Skip { get; set; }
        public int Take { get; set; } = 10;

        public GetPaginatedGamesListQuery(int page, int pageSize)
        {
            if (page < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(page), page, "Page number must be greater than 0!");
            }

            if(pageSize < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(pageSize), pageSize, "Page size must be greater than 0!");
            }

            Skip = (page - 1) * pageSize;
            Take = pageSize;
        }
    }
}
