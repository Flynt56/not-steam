using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using NotSteam.Core.Interfaces.DB;

namespace NotSteam.Core.App.GameTags.Queries.GetGameTagDetail
{
    public class GetGameTagDetailQueryHandler : IRequestHandler<GetGameTagDetailQuery, GameTagDetailDto>
    {
        private readonly INotSteamContext _context;
        private readonly IMapper _mapper;

        public GetGameTagDetailQueryHandler(INotSteamContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<GameTagDetailDto> Handle(GetGameTagDetailQuery request, CancellationToken cancellationToken)
        {
            return await _context
                .GameTags
                .Where(a => a.GameId == request.GameId && a.TagId == request.TagId)
                .Include(a => a.Game)
                .Include(a => a.Tag)
                .ProjectTo<GameTagDetailDto>(_mapper.ConfigurationProvider)
                .FirstAsync();
        }
    }
}
