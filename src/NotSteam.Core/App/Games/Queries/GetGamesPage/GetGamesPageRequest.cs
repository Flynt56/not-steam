using System.Linq;
using NotSteam.Shared.Pagination;

namespace NotSteam.Core.App.Games.Queries.GetPaginatedGamesList
{
    public class GetGamesPageRequest : AbstractPagingRequest<GamesPageEntryDto>
    {
        private const string ValidOrderByValues = "title";

        public string Title { get; set; }

        public string OrderBy { get; set; }

        public override IQueryable<GamesPageEntryDto> GetFilteredQuery(IQueryable<GamesPageEntryDto> query)
        {
            if (!string.IsNullOrWhiteSpace(Title))
            {
                query = query.Where(i => i.Title.Contains(Title));
            }

            return query;
        }

        public override IQueryable<GamesPageEntryDto> SetUpSorting(IQueryable<GamesPageEntryDto> query)
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
