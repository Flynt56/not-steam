using System.Linq;
using NotSteam.Shared.Pagination;

namespace NotSteam.Core.Requests
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

            if (!string.IsNullOrWhiteSpace(Nickname))
            {
                query = query.Where(i => i.Nick.Contains(Nickname));
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
