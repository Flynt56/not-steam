using MediatR;

namespace NotSteam.Api.Identity.Auth.Register.Command
{
    public class RegisterRequest : IRequest<RegisterResponse>
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
