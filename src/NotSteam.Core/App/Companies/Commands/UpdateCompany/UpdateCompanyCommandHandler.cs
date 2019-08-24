using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using NotSteam.Core.Interfaces.Repositories;
using NotSteam.Model.Models;

namespace NotSteam.Core.App.Companies.Commands.UpdateCompany
{
    public class UpdateCompanyCommandHandler : IRequestHandler<UpdateCompanyCommand, UpdateCompanyDto>
    {
        private readonly IAsyncRepository<Company> _companyRepository;
        private readonly IMapper _mapper;

        public UpdateCompanyCommandHandler(IAsyncRepository<Company> companyRepository, IMapper mapper)
        {
            _companyRepository = companyRepository;
            _mapper = mapper;
        }

        public async Task<UpdateCompanyDto> Handle(UpdateCompanyCommand request, CancellationToken cancellationToken)
        {
            await _companyRepository
                .UpdateAsync(_mapper.Map<Company>(request.UpdateCompanyDto));

            return request.UpdateCompanyDto;
        }
    }
}
