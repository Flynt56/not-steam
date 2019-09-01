using System;
using FluentValidation;

namespace NotSteam.Core.App.Auth.Register.Command
{
    public class RegisterRequestValidator : AbstractValidator<RegisterRequest>
    {
        public RegisterRequestValidator()
        {
            RuleFor(e => e.Email).NotEmpty().EmailAddress();

            RuleFor(e => e.Password).NotEmpty().Matches(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[#$^+=!*()@%&]).{6,}$");

            RuleFor(e => e.DateOfBirth).NotEmpty().InclusiveBetween(DateTime.SpecifyKind(new DateTime(1970, 1, 1), DateTimeKind.Utc), DateTime.UtcNow);
            RuleFor(e => e.Nickname).MaximumLength(32);
            RuleFor(e => e.ProfileImageUri).Must(e => Uri.IsWellFormedUriString(e, UriKind.RelativeOrAbsolute)).When(x => !string.IsNullOrWhiteSpace(x.ProfileImageUri)).WithMessage("Neispravno formatiran URL!");
        }
    }
}
