using FluentValidation;

namespace NotSteam.Api.Identity.Auth.Register.Command
{
    public class RegisterRequestValidator : AbstractValidator<RegisterRequest>
    {
        public RegisterRequestValidator()
        {
            RuleFor(e => e.Email).NotEmpty().EmailAddress();

            RuleFor(e => e.Password).NotEmpty().Length(6, 128);
        }
    }
}
