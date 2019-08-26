namespace NotSteam.Api.Identity.Auth.Login.Command
{
    public class LoginResponse
    {
        public string Token { get; set; }
        public AuthUserResponse User { get; set; }
    }
}
