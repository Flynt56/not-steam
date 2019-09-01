using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using NotSteam.Core.Interfaces.Repositories;
using NotSteam.Model.Models;

namespace NotSteam.Core.App.Companies.Queries.GetCompanyEditForm
{
    public class GetCompanyEditFormRequestHandler : IRequestHandler<GetCompanyEditFormRequest, GetCompanyEditFormResponse>
    {
        private readonly IAsyncRepository<Company> _companyRepository;
        private readonly IMapper _mapper;

        public GetCompanyEditFormRequestHandler(IAsyncRepository<Company> companyRepository, IMapper mapper)
        {
            _companyRepository = companyRepository;
            _mapper = mapper;
        }

        public async Task<GetCompanyEditFormResponse> Handle(GetCompanyEditFormRequest request, CancellationToken cancellationToken)
        {
            var company = await _companyRepository.GetAll()
                .Where(x => x.Id == request.Id)
                .ProjectTo<CompanyEditFormDto>(_mapper.ConfigurationProvider)
                .FirstAsync();

            return new GetCompanyEditFormResponse
            {
                Company = company
            };
        }
    }
}
