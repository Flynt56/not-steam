using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using NotSteam.Core.Interfaces.Repositories;
using NotSteam.Model.Models;

namespace NotSteam.Api.Core.Tags.Queries.GetTagDetail
{
    public class GetTagDetailQueryHandler : IRequestHandler<GetTagDetailQuery, TagDetailDto>
    {
        private readonly IAsyncRepository<Tag> _tagRepository;
        private readonly IMapper _mapper;

        public GetTagDetailQueryHandler(IAsyncRepository<Tag> tagRepository, IMapper mapper)
        {
            _tagRepository = tagRepository;
            _mapper = mapper;
        }

        public async Task<TagDetailDto> Handle(GetTagDetailQuery request, CancellationToken cancellationToken)
        {
            return await _tagRepository.GetAll()
                .Where(a => a.Id == request.Id)
                .Include(a => a.GameTags)
                .ProjectTo<TagDetailDto>(_mapper.ConfigurationProvider)
                .FirstAsync();
        }
    }
}
