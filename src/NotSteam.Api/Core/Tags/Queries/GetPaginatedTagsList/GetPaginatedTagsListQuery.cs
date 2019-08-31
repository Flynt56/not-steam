using System.Linq;
using MediatR;
using NotSteam.Shared.Pagination;

namespace NotSteam.Api.Core.Tags.Queries.GetPaginatedTagsList
{
    public class GetPaginatedTagsListQuery : AbstractPagingRequest<TagsListEntryDto>, IRequest<PagedResult<TagsListEntryDto>>
    {
        private const string ValidOrderByValues = "name";

        public string Name { get; set; }

        public string OrderBy { get; set; }

        public override IQueryable<TagsListEntryDto> GetFilteredQuery(IQueryable<TagsListEntryDto> query)
        {
            if (!string.IsNullOrWhiteSpace(Name))
            {
                query = query.Where(i => i.Name.Contains(Name));
            }

            return query;
        }

        public override IQueryable<TagsListEntryDto> SetUpSorting(IQueryable<TagsListEntryDto> query)
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
