using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using NotSteam.Core.Interfaces.Repositories;
using NotSteam.Model.Models;

namespace NotSteam.Core.App.Games.Queries.GetGameEditForm
{
    public class GetGameEditFormRequestHandler : IRequestHandler<GetGameEditFormRequest, GetGameEditFormResponse>
    {
        private readonly IAsyncRepository<Game> _gameRepository;
        private readonly IAsyncRepository<Company> _companyRepository;
        private readonly IMapper _mapper;

        public GetGameEditFormRequestHandler(IAsyncRepository<Game> gameRepository, IAsyncRepository<Company> companyRepository, IMapper mapper)
        {
            _gameRepository = gameRepository;
            _companyRepository = companyRepository;
            _mapper = mapper;
        }

        public async Task<GetGameEditFormResponse> Handle(GetGameEditFormRequest request, CancellationToken cancellationToken)
        {
            var companies = await _companyRepository.GetAll()
                .ProjectTo<CompanyListEntryDto>(_mapper.ConfigurationProvider)
                .ToListAsync();

            var game = await _gameRepository.GetAll()
                .Where(x => x.Id == request.Id)
                .ProjectTo<GameEditFormDto>(_mapper.ConfigurationProvider)
                .FirstAsync();

            return new GetGameEditFormResponse
            {
                Game = game,
                Companies = companies
            };
        }
    }
}
