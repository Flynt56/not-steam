using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using NotSteam.Core.App.Tags.Queries.GetPaginatedTagsList;
using NotSteam.Core.Interfaces.DB;
using NotSteam.Shared.Extensions;
using NotSteam.Shared.Pagination;

namespace NotSteam.Core.App.GameTags.Queries.GetPaginatedGameTagsList
{
    public class GetPaginatedTagsListQueryHandler : IRequestHandler<GetPaginatedTagsListQuery, PagedResult<TagsListEntryDto>>
    {
        private readonly INotSteamContext _context;
        private readonly IMapper _mapper;

        public GetPaginatedTagsListQueryHandler(INotSteamContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<PagedResult<TagsListEntryDto>> Handle(GetPaginatedTagsListQuery request, CancellationToken cancellationToken)
        {
            return await _context
                .GameTags
                .Include(a => a.Tag)
                .Include(a => a.Game)
                .ProjectTo<TagsListEntryDto>(_mapper.ConfigurationProvider)
                .ToPagedResultAsync(request);
        }
    }
}
