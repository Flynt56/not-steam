using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using NotSteam.Core.Exceptions;
using NotSteam.Core.Interfaces.Repositories;
using NotSteam.Model.Models;

namespace NotSteam.Api.Core.Companies.Commands.DeleteCompany
{
    public class DeleteCompanyCommandHandler : IRequestHandler<DeleteCompanyCommand>
    {
        private readonly IAsyncRepository<Company> _companyRepository;
        private readonly IMapper _mapper;

        public DeleteCompanyCommandHandler(IAsyncRepository<Company> companyRepository, IMapper mapper)
        {
            _companyRepository = companyRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(DeleteCompanyCommand request, CancellationToken cancellationToken)
        {
            var entity = await _companyRepository
                .GetByIdAsync(request.Id);

            if (entity == null)
            {
                throw new NotFoundException(nameof(Company), request.Id);
            }

            await _companyRepository
                .DeleteAsync(entity);

            return Unit.Value;
        }
    }
}
