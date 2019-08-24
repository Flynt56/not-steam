using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using NotSteam.Core.Interfaces.Repositories;
using NotSteam.Model.Models;

namespace NotSteam.Core.App.Companies.Commands.AddCompany
{
    public class AddCompanyCommandHandler : IRequestHandler<AddCompanyCommand, AddCompanyDto>
    {
        private readonly IAsyncRepository<Company> _companyRepository;
        private readonly IMapper _mapper;

        public AddCompanyCommandHandler(IAsyncRepository<Company> companyRepository, IMapper mapper)
        {
            _companyRepository = companyRepository;
            _mapper = mapper;
        }

        public async Task<AddCompanyDto> Handle(AddCompanyCommand request, CancellationToken cancellationToken)
        {
            return _mapper.Map<AddCompanyDto>(
                await _companyRepository
                .AddAsync(_mapper.Map<Company>(request.AddCompanyDto)));
        }
    }
}
