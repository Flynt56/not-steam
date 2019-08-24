using System.Linq;
using NotSteam.Shared.Pagination;

namespace NotSteam.Core.Requests
{
    public class ReviewPaginationRequest : AbstractPagingRequest<ReviewsList>
    {
        private const string ValidOrderByValues = "user,game";

        public string User { get; set; }
        public string Game { get; set; }

        public string OrderBy { get; set; }

        public override IQueryable<ReviewsList> GetFilteredQuery(IQueryable<ReviewsList> query)
        {
            if (!string.IsNullOrWhiteSpace(User))
            {
                query = query.Where(i => i.User.Contains(User));
            }

            if (!string.IsNullOrWhiteSpace(Game))
            {
                query = query.Where(i => i.Game.Contains(Game));
            }

            return query;
        }

        public override IQueryable<ReviewsList> SetUpSorting(IQueryable<ReviewsList> query)
        {
            var sortInformation = ParseOrderBy(OrderBy, ValidOrderByValues);

            if (sortInformation != null)
            {
                switch (sortInformation.PropertyName)
                {
                    case "user":
                        query = ApplyOrdering(query, dtc => dtc.User, sortInformation.SortDirection);
                        break;
                    case "game":
                        query = ApplyOrdering(query, dtc => dtc.Game, sortInformation.SortDirection);
                        break;
                }
            }

            return query;
        }
    }
}
