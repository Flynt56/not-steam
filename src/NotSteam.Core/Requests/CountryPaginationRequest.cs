using System.Linq;
using NotSteam.Api.Responses;
using NotSteam.Shared.Pagination;

namespace NotSteam.Api.Requests
{
    public class CountryPaginationRequest : AbstractPagingRequest<CountryResponse>
    {
        private const string ValidOrderByValues = "name";
        public string Name { get; set; }

        public string OrderBy { get; set; }

        public override IQueryable<CountryResponse> GetFilteredQuery(IQueryable<CountryResponse> query)
        {
            if (!string.IsNullOrWhiteSpace(Name))
            {
                query = query.Where(i => i.Name.Contains(Name));
            }

            return query;
        }

        public override IQueryable<CountryResponse> SetUpSorting(IQueryable<CountryResponse> query)
        {
            SortInformation sortInformation = ParseOrderBy(OrderBy, ValidOrderByValues);

            if (sortInformation != null)
            {
                switch (sortInformation.PropertyName)
                {
                    case "name":
                        query = ApplyOrdering(query, dtc => dtc.Name, sortInformation.SortDirection);
                        break;
                }
            }

            return query;
        }
    }
}
