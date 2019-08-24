using FluentValidation;

namespace NotSteam.Core.App.Companies.Commands.DeleteCompany
{
    class DeleteCompanyCommandValidator : AbstractValidator<DeleteCompanyCommand>
    {
        public DeleteCompanyCommandValidator()
        {
            RuleFor(e => e.Id).NotEmpty();
        }
    }
}
