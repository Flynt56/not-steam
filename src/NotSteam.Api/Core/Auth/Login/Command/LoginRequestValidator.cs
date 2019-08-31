using FluentValidation;

namespace NotSteam.Api.Core.Auth.Login.Command
{
    public class LoginRequestValidator : AbstractValidator<LoginRequest>
    {
        public LoginRequestValidator()
        {
            RuleFor(e => e.Email).NotEmpty().EmailAddress();

            RuleFor(e => e.Password).NotEmpty();
        }
    }
}
