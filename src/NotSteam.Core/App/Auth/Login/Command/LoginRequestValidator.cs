using FluentValidation;

namespace NotSteam.Core.App.Auth.Login.Command
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
