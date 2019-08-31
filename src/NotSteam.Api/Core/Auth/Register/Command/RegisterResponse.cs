using NotSteam.Api.Core.Auth;

namespace NotSteam.Api.Core.Auth.Register.Command
{
    public class RegisterResponse
    {
        public string Token { get; set; }
        public AuthUserResponse User { get; set; }
    }
}
