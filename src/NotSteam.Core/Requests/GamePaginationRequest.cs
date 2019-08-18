using System.Linq;
using NotSteam.Core.ViewModels.Games;
using NotSteam.Shared.Pagination;

namespace NotSteam.Core.Requests
{
    public class GamePaginationRequest : AbstractPagingRequest<GamesList>
    {
        private const string ValidOrderByValues = "title";

        public string Title { get; set; }

        public string OrderBy { get; set; }

        public override IQueryable<GamesList> GetFilteredQuery(IQueryable<GamesList> query)
        {
            if (!string.IsNullOrWhiteSpace(Title))
            {
                query = query.Where(i => i.Title.Contains(Title));
            }

            return query;
        }

        public override IQueryable<GamesList> SetUpSorting(IQueryable<GamesList> query)
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
