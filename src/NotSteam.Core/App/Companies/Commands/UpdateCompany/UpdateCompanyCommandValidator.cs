using System;
using FluentValidation;

namespace NotSteam.Core.App.Companies.Commands.UpdateCompany
{
    public class UpdateCompanyCommandValidator : AbstractValidator<UpdateCompanyCommand>
    {
        public UpdateCompanyCommandValidator()
        {
            RuleFor(x => x.Id).NotEmpty();
            RuleFor(x => x.Company.Id).NotEmpty();
            RuleFor(x => x.Id).Equal(x => x.Company.Id);

            RuleFor(x => x.Company.Name).NotEmpty().MaximumLength(64);
            RuleFor(x => x.Company.Description).MaximumLength(1500);

            RuleFor(x => x.Company.HomepageUri).Must(x => Uri.IsWellFormedUriString(x, UriKind.RelativeOrAbsolute));
            RuleFor(x => x.Company.LogoImageUri).Must(x => Uri.IsWellFormedUriString(x, UriKind.RelativeOrAbsolute));
        }
    }
}
