namespace NotSteam.Core.App.Auth.Register.Command
{
    public class RegisterResponse
    {
        public string Token { get; set; }
        public AuthUserResponse User { get; set; }
    }
}
