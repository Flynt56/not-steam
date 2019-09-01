using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using NotSteam.Core.Interfaces.Repositories;
using NotSteam.Model.Models;

namespace NotSteam.Core.App.Games.Queries.GetGameAddForm
{
    public class GetGameAddFormRequestHandler : IRequestHandler<GetGameAddFormRequest, GetGameAddFormResponse>
    {
        private readonly IAsyncRepository<Company> _companyRepository;
        private readonly IMapper _mapper;

        public GetGameAddFormRequestHandler(IAsyncRepository<Company> companyRepository, IMapper mapper)
        {
            _companyRepository = companyRepository;
            _mapper = mapper;
        }

        public async Task<GetGameAddFormResponse> Handle(GetGameAddFormRequest request, CancellationToken cancellationToken)
        {
            var companies = await _companyRepository.GetAll()
                .ProjectTo<CompanyListEntryDto>(_mapper.ConfigurationProvider)
                .ToListAsync();

            return new GetGameAddFormResponse
            {
                Companies = companies
            };
        }
    }
}
