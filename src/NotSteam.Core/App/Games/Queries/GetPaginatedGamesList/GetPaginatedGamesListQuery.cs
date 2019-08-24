using System.Linq;
using MediatR;
using NotSteam.Shared.Pagination;

namespace NotSteam.Core.App.Games.Queries.GetPaginatedGamesList
{
    public class GetPaginatedGamesListQuery : AbstractPagingRequest<GamesListEntryDto>, IRequest<PagedResult<GamesListEntryDto>>
    {
        private const string ValidOrderByValues = "title";

        public string Title { get; set; }

        public string OrderBy { get; set; }

        public override IQueryable<GamesListEntryDto> GetFilteredQuery(IQueryable<GamesListEntryDto> query)
        {
            if (!string.IsNullOrWhiteSpace(Title))
            {
                query = query.Where(i => i.Title.Contains(Title));
            }

            return query;
        }

        public override IQueryable<GamesListEntryDto> SetUpSorting(IQueryable<GamesListEntryDto> query)
        {
            var sortInformation = ParseOrderBy(OrderBy, ValidOrderByValues);

            if (sortInformation != null)
            {
                switch (sortInformation.PropertyName)
                {
                    case "title":
                        query = ApplyOrdering(query, dtc => dtc.Title, sortInformation.SortDirection);
                        break;
                }
            }

            return query;
        }
    }
}
