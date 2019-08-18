using System.Linq;
using NotSteam.Core.ViewModels;
using NotSteam.Shared.Pagination;

namespace NotSteam.Api.Requests
{
    public class UserPaginationRequest : AbstractPagingRequest<UsersList>
    {
        private const string ValidOrderByValues = "username,nickname";

        public string Username { get; set; }
        public string Nickname { get; set; }

        public string OrderBy { get; set; }

        public override IQueryable<UsersList> GetFilteredQuery(IQueryable<UsersList> query)
        {
            if (!string.IsNullOrWhiteSpace(Username))
            {
                query = query.Where(i => i.Name.Contains(Username));
            }

            return query;
        }

        public override IQueryable<UsersList> SetUpSorting(IQueryable<UsersList> query)
        {
            var sortInformation = ParseOrderBy(OrderBy, ValidOrderByValues);

            if (sortInformation != null)
            {
                switch (sortInformation.PropertyName)
                {
                    case "username":
                        query = ApplyOrdering(query, dtc => dtc.Name, sortInformation.SortDirection);
                        break;

                    case "nickname":
                        query = ApplyOrdering(query, dtc => dtc.Nick, sortInformation.SortDirection);
                        break;
                }
            }

            return query;
        }
    }
}
