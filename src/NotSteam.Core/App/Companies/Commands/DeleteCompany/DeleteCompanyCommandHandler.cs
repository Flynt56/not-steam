using System.Threading;
using System.Threading.Tasks;
using MediatR;
using NotSteam.Core.Exceptions;
using NotSteam.Core.Interfaces.Repositories;
using NotSteam.Model.Models;

namespace NotSteam.Core.App.Companies.Commands.DeleteCompany
{
    public class DeleteCompanyCommandHandler : IRequestHandler<DeleteCompanyCommand>
    {
        private readonly IAsyncRepository<Company> _companyRepository;

        public DeleteCompanyCommandHandler(IAsyncRepository<Company> companyRepository)
        {
            _companyRepository = companyRepository;
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
