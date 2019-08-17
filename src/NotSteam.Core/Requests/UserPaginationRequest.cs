using System.Linq;
using NotSteam.Api.Responses;
using NotSteam.Shared.Pagination;

namespace NotSteam.Api.Requests
{
    public class UserPaginationRequest : AbstractPagingRequest<UserPaginationResponse>
    {
        private const string ValidOrderByValues = "username,nickname";

        public string Username { get; set; }
        public string Nickname { get; set; }

        public string OrderBy { get; set; }

        public override IQueryable<UserPaginationResponse> GetFilteredQuery(IQueryable<UserPaginationResponse> query)
        {
            if (!string.IsNullOrWhiteSpace(Username))
            {
                query = query.Where(i => i.Username.Contains(Username));
            }

            return query;
        }

        public override IQueryable<UserPaginationResponse> SetUpSorting(IQueryable<UserPaginationResponse> query)
        {
            var sortInformation = ParseOrderBy(OrderBy, ValidOrderByValues);

            if (sortInformation != null)
            {
                switch (sortInformation.PropertyName)
                {
                    case "name":
                        query = ApplyOrdering(query, dtc => dtc.Username, sortInformation.SortDirection);
                        break;
                }
            }

            return query;
        }
    }
}
