using System.Linq;
using NotSteam.Core.ViewModels.Tags;
using NotSteam.Shared.Pagination;

namespace NotSteam.Core.Requests
{
    public class TagPaginationRequest : AbstractPagingRequest<TagsList>
    {
        private const string ValidOrderByValues = "name";

        public string Name { get; set; }

        public string OrderBy { get; set; }

        public override IQueryable<TagsList> GetFilteredQuery(IQueryable<TagsList> query)
        {
            if (!string.IsNullOrWhiteSpace(Name))
            {
                query = query.Where(i => i.Name.Contains(Name));
            }

            return query;
        }

        public override IQueryable<TagsList> SetUpSorting(IQueryable<TagsList> query)
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
