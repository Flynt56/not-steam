using MediatR;

namespace NotSteam.Core.App.Auth.Register.Command
{
    public class RegisterRequest : IRequest<RegisterResponse>
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
