using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using NotSteam.Core.Interfaces.Repositories;
using NotSteam.Model.Models;
using NotSteam.Shared.Extensions;
using NotSteam.Shared.Pagination;

namespace NotSteam.Api.Core.Companies.Queries.GetPaginatedCompaniesList
{
    public class GetPaginatedCompaniesListQueryHandler : IRequestHandler<GetPaginatedCompaniesListQuery, PagedResult<CompaniesListEntryDto>>
    {
        private readonly IAsyncRepository<Company> _companyRepository;
        private readonly IMapper _mapper;

        public GetPaginatedCompaniesListQueryHandler(IAsyncRepository<Company> companyRepository, IMapper mapper)
        {
            _companyRepository = companyRepository;
            _mapper = mapper;
        }

        public async Task<PagedResult<CompaniesListEntryDto>> Handle(GetPaginatedCompaniesListQuery request, CancellationToken cancellationToken)
        {
            return await _companyRepository.GetAll()
                .ProjectTo<CompaniesListEntryDto>(_mapper.ConfigurationProvider)
                .ToPagedResultAsync(request);
        }
    }
}
