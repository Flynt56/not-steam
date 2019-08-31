using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using NotSteam.Core.Interfaces.Repositories;
using NotSteam.Model.Entities;
using NotSteam.Shared.Extensions;
using NotSteam.Shared.Pagination;

namespace NotSteam.Api.Core.Tags.Queries.GetPaginatedTagsList
{
    public class GetPaginatedTagsListQueryHandler : IRequestHandler<GetPaginatedTagsListQuery, PagedResult<TagsListEntryDto>>
    {
        private readonly IAsyncRepository<Tag> _tagRepository;
        private readonly IMapper _mapper;

        public GetPaginatedTagsListQueryHandler(IAsyncRepository<Tag> tagRepository, IMapper mapper)
        {
            _tagRepository = tagRepository;
            _mapper = mapper;
        }

        public async Task<PagedResult<TagsListEntryDto>> Handle(GetPaginatedTagsListQuery request, CancellationToken cancellationToken)
        {
            return await _tagRepository.GetAll()
                .Include(a => a.GameTags)
                .ProjectTo<TagsListEntryDto>(_mapper.ConfigurationProvider)
                .ToPagedResultAsync(request);
        }
    }
}
