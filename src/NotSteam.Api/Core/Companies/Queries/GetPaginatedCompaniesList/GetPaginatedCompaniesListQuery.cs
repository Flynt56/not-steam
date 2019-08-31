using System.Linq;
using MediatR;
using NotSteam.Shared.Pagination;

namespace NotSteam.Api.Core.Companies.Queries.GetPaginatedCompaniesList
{
    public class GetPaginatedCompaniesListQuery : AbstractPagingRequest<CompaniesListEntryDto>, IRequest<PagedResult<CompaniesListEntryDto>>
    {
        private const string ValidOrderByValues = "name";

        public string Name { get; set; }

        public string OrderBy { get; set; }

        public override IQueryable<CompaniesListEntryDto> GetFilteredQuery(IQueryable<CompaniesListEntryDto> query)
        {
            if (!string.IsNullOrWhiteSpace(Name))
            {
                query = query.Where(i => i.Name.Contains(Name));
            }

            return query;
        }

        public override IQueryable<CompaniesListEntryDto> SetUpSorting(IQueryable<CompaniesListEntryDto> query)
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
