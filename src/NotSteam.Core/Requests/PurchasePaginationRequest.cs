using System.Linq;
using NotSteam.Shared.Pagination;

namespace NotSteam.Core.Requests
{
    public class PurchasePaginationRequest : AbstractPagingRequest<PurchasesList>
    {
        private const string ValidOrderByValues = "game,user";

        public string Game { get; set; }
        public string User { get; set; }

        public string OrderBy { get; set; }

        public override IQueryable<PurchasesList> GetFilteredQuery(IQueryable<PurchasesList> query)
        {
            if (!string.IsNullOrWhiteSpace(Game))
            {
                query = query.Where(i => i.Game.Contains(Game));
            }

            if (!string.IsNullOrWhiteSpace(User))
            {
                query = query.Where(i => i.User.Contains(User));
            }

            return query;
        }

        public override IQueryable<PurchasesList> SetUpSorting(IQueryable<PurchasesList> query)
        {
            var sortInformation = ParseOrderBy(OrderBy, ValidOrderByValues);

            if (sortInformation != null)
            {
                switch (sortInformation.PropertyName)
                {
                    case "game":
                        query = ApplyOrdering(query, dtc => dtc.Game, sortInformation.SortDirection);
                        break;

                    case "user":
                        query = ApplyOrdering(query, dtc => dtc.User, sortInformation.SortDirection);
                        break;
                }
            }

            return query;
        }
    }
}
