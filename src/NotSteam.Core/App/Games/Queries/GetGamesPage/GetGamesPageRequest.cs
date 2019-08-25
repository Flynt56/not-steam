using System.Linq;
using MediatR;
using NotSteam.Shared.Pagination;

namespace NotSteam.Core.App.Games.Queries.GetGamesPage
{
    public class GetGamesPageRequest : AbstractPagingRequest<GetGamesPageEntryResponseDto>, IRequest<PagedResult<GetGamesPageEntryResponseDto>>
    {
        private const string ValidOrderByValues = "title";

        public string Title { get; set; }

        public string OrderBy { get; set; }

        public override IQueryable<GetGamesPageEntryResponseDto> GetFilteredQuery(IQueryable<GetGamesPageEntryResponseDto> query)
        {
            if (!string.IsNullOrWhiteSpace(Title))
            {
                query = query.Where(i => i.Title.Contains(Title));
            }

            return query;
        }

        public override IQueryable<GetGamesPageEntryResponseDto> SetUpSorting(IQueryable<GetGamesPageEntryResponseDto> query)
        {
            var sortInformation = ParseOrderBy(OrderBy, ValidOrderByValues);

            if (sortInformation != null)
            {
                switch (sortInformation.PropertyName)
                {
                    case "title":
                        query = ApplyOrdering(query, dtc => dtc.Title, sortInformation.SortDirection);
                        break;
                }
            }

            return query;
        }
    }
}
