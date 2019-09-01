using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using NotSteam.Core.Interfaces.Repositories;
using NotSteam.Model.Models;

namespace NotSteam.Core.App.Tags.Queries.GetTagEditForm
{
    public class GetTagDetailQueryHandler : IRequestHandler<GetTagEditFormRequest, GetTagEditFormResponse>
    {
        private readonly IAsyncRepository<Tag> _tagRepository;
        private readonly IMapper _mapper;

        public GetTagDetailQueryHandler(IAsyncRepository<Tag> tagRepository, IMapper mapper)
        {
            _tagRepository = tagRepository;
            _mapper = mapper;
        }

        public async Task<GetTagEditFormResponse> Handle(GetTagEditFormRequest request, CancellationToken cancellationToken)
        {
            return new GetTagEditFormResponse
            {
                Tag = await _tagRepository.GetAll()
                .Where(a => a.Id == request.Id)
                .ProjectTo<TagEditFormDto>(_mapper.ConfigurationProvider)
                .FirstAsync()
            };
        }
    }
}
