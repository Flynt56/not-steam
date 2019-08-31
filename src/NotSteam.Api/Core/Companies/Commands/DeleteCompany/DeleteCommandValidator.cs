using FluentValidation;

namespace NotSteam.Api.Core.Companies.Commands.DeleteCompany
{
    class DeleteCompanyCommandValidator : AbstractValidator<DeleteCompanyCommand>
    {
        public DeleteCompanyCommandValidator()
        {
            RuleFor(e => e.Id).NotEmpty();
        }
    }
}
