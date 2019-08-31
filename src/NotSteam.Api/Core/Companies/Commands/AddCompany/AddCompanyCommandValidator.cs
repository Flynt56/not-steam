using FluentValidation;

namespace NotSteam.Api.Core.Companies.Commands.AddCompany
{
    public class AddCompanyCommandValidator : AbstractValidator<AddCompanyCommand>
    {
        public AddCompanyCommandValidator()
        {
        }
    }
}
