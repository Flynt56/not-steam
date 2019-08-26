using MediatR;

namespace NotSteam.Api.Identity.Auth.Login.Command
{
    public class LoginRequest : IRequest<LoginResponse>
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
