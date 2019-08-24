using MediatR;

namespace NotSteam.Core.App.Auth.Login.Command
{
    public class LoginRequest : IRequest<LoginResponse>
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
