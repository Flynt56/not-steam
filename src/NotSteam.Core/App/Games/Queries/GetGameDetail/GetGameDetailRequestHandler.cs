using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using NotSteam.Core.Interfaces.Repositories;
using NotSteam.Model.Models;

namespace NotSteam.Core.App.Games.Queries.GetGameDetail
{
    public class GetGameDetailRequestHandler : IRequestHandler<GetGameDetailRequest, GetGameDetailResponseDto>
    {
        private readonly IAsyncRepository<Game> _gameRepository;
        private readonly IMapper _mapper;

        public GetGameDetailRequestHandler(IAsyncRepository<Game> gameRepository, IMapper mapper)
        {
            _gameRepository = gameRepository;
            _mapper = mapper;
        }

        public async Task<GetGameDetailResponseDto> Handle(GetGameDetailRequest request, CancellationToken cancellationToken)
        {
            return await _gameRepository.GetAll()
                .Where(a => a.Id == request.Id)
                .Include(a => a.Company)
                .Include(a => a.Reviews)
                .ProjectTo<GetGameDetailResponseDto>(_mapper.ConfigurationProvider)
                .FirstAsync();
        }
    }
}
