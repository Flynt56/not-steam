using System.Linq;
using MediatR;
using NotSteam.Shared.Pagination;

namespace NotSteam.Core.App.GameTags.Queries.GetPaginatedGameTagsList
{
    public class GetPaginatedGameTagsListQuery : AbstractPagingRequest<GameTagsListEntryDto>, IRequest<PagedResult<GameTagsListEntryDto>>
    {
        private const string ValidOrderByValues = "game,tag";

        public string Game { get; set; }
        public string Tag { get; set; }

        public string OrderBy { get; set; }

        public override IQueryable<GameTagsListEntryDto> GetFilteredQuery(IQueryable<GameTagsListEntryDto> query)
        {
            if (!string.IsNullOrWhiteSpace(Game))
            {
                query = query.Where(i => i.GameTitle.Contains(Game));
            }

            if (!string.IsNullOrWhiteSpace(Tag))
            {
                query = query.Where(i => i.TagName.Contains(Tag));
            }

            return query;
        }

        public override IQueryable<GameTagsListEntryDto> SetUpSorting(IQueryable<GameTagsListEntryDto> query)
        {
            var sortInformation = ParseOrderBy(OrderBy, ValidOrderByValues);

            if (sortInformation != null)
            {
                switch (sortInformation.PropertyName)
                {
                    case "game":
                        query = ApplyOrdering(query, dtc => dtc.GameTitle, sortInformation.SortDirection);
                        break;

                    case "tag":
                        query = ApplyOrdering(query, dtc => dtc.TagName, sortInformation.SortDirection);
                        break;
                }
            }

            return query;
        }
    }
}
