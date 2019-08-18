using System.Linq;
using NotSteam.Core.ViewModels;
using NotSteam.Shared.Pagination;

namespace NotSteam.Core.Requests
{
    public class CompanyPaginationRequest : AbstractPagingRequest<CompaniesList>
    {
        private const string ValidOrderByValues = "name";

        public string Name { get; set; }

        public string OrderBy { get; set; }

        public override IQueryable<CompaniesList> GetFilteredQuery(IQueryable<CompaniesList> query)
        {
            if (!string.IsNullOrWhiteSpace(Name))
            {
                query = query.Where(i => i.Name.Contains(Name));
            }

            return query;
        }

        public override IQueryable<CompaniesList> SetUpSorting(IQueryable<CompaniesList> query)
        {
            var sortInformation = ParseOrderBy(OrderBy, ValidOrderByValues);

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
