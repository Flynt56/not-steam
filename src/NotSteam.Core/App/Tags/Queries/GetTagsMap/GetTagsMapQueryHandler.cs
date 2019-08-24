using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using NotSteam.Core.Interfaces.Repositories;
using NotSteam.Model.Models;

namespace NotSteam.Core.App.Tags.Queries.GetTagsMap
{
    public class GetTagsMapQueryHandler : IRequestHandler<GetTagsMapQuery, IEnumerable<TagsMapEntryDto>>
    {
        private readonly IAsyncRepository<Tag> _tagRepository;
        private readonly IMapper _mapper;

        public GetTagsMapQueryHandler(IAsyncRepository<Tag> tagRepository, IMapper mapper)
        {
            _tagRepository = tagRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<TagsMapEntryDto>> Handle(GetTagsMapQuery request, CancellationToken cancellationToken)
        {
            return await _tagRepository.GetAll()
                .ProjectTo<TagsMapEntryDto>(_mapper.ConfigurationProvider)
                .ToListAsync();
        }
    }
}
