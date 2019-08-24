using System.Linq;
using NotSteam.Shared.Pagination;

namespace NotSteam.Core.Requests
{
    public class LibraryPaginationRequest : AbstractPagingRequest<LibrariesList>
    {
        private const string ValidOrderByValues = "user,game";

        public string User { get; set; }
        public string Game { get; set; }

        public string OrderBy { get; set; }

        public override IQueryable<LibrariesList> GetFilteredQuery(IQueryable<LibrariesList> query)
        {
            if (!string.IsNullOrWhiteSpace(User))
            {
                query = query.Where(i => i.OwnerUsername.Contains(User));
            }

            if (!string.IsNullOrWhiteSpace(Game))
            {
                query = query.Where(i => i.GameTitle.Contains(Game));
            }

            return query;
        }

        public override IQueryable<LibrariesList> SetUpSorting(IQueryable<LibrariesList> query)
        {
            var sortInformation = ParseOrderBy(OrderBy, ValidOrderByValues);

            if (sortInformation != null)
            {
                switch (sortInformation.PropertyName)
                {
                    case "user":
                        query = ApplyOrdering(query, dtc => dtc.OwnerUsername, sortInformation.SortDirection);
                        break;

                    case "game":
                        query = ApplyOrdering(query, dtc => dtc.GameTitle, sortInformation.SortDirection);
                        break;
                }
            }

            return query;
        }
    }
}
