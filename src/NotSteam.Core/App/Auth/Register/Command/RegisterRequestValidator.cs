using FluentValidation;

namespace NotSteam.Core.App.Auth.Register.Command
{
    class RegisterRequestValidator : AbstractValidator<RegisterRequest>
    {
        public RegisterRequestValidator()
        {
            RuleFor(e => e.Email).NotEmpty().EmailAddress();

            RuleFor(e => e.Password).NotEmpty().Length(6, 128);
        }
    }
}
