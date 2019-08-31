using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using NotSteam.Core.Interfaces.Repositories;
using NotSteam.Model.Models;

namespace NotSteam.Api.Core.Companies.Queries.GetCompaniesMap
{
    public class GetCompaniesMapQueryHandler : IRequestHandler<GetCompaniesMapQuery, IEnumerable<CompaniesMapEntryDto>>
    {
        private readonly IAsyncRepository<Company> _companyRepository;
        private readonly IMapper _mapper;

        public GetCompaniesMapQueryHandler(IAsyncRepository<Company> companyRepository, IMapper mapper)
        {
            _companyRepository = companyRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CompaniesMapEntryDto>> Handle(GetCompaniesMapQuery request, CancellationToken cancellationToken)
        {
            return await _companyRepository.GetAll()
                .ProjectTo<CompaniesMapEntryDto>(_mapper.ConfigurationProvider)
                .ToListAsync();
        }
    }
}
