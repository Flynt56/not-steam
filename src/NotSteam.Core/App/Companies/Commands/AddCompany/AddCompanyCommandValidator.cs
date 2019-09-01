using System;
using FluentValidation;

namespace NotSteam.Core.App.Companies.Commands.AddCompany
{
    public class AddCompanyCommandValidator : AbstractValidator<AddCompanyCommand>
    {
        public AddCompanyCommandValidator()
        {
            RuleFor(x => x.Company.Name).NotEmpty().MaximumLength(64);
            RuleFor(x => x.Company.Description).MaximumLength(1500);

            RuleFor(x => x.Company.HomepageUri)
                .Must(x => Uri.IsWellFormedUriString(x, UriKind.RelativeOrAbsolute))
                .When(x => !string.IsNullOrWhiteSpace(x.Company.HomepageUri))
                .WithMessage("Neispravno formatiran URL!");

            RuleFor(x => x.Company.LogoImageUri)
                .Must(x => Uri.IsWellFormedUriString(x, UriKind.RelativeOrAbsolute))
                .When(x => !string.IsNullOrWhiteSpace(x.Company.LogoImageUri))
                .WithMessage("Neispravno formatiran URL!");
        }
    }
}
