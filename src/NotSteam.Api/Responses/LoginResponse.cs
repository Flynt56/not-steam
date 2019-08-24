namespace NotSteam.Api.Responses
{
    public class LoginResponse : AppResponse
    {
        public string Token { get; set; }
        public AuthUserResponse User { get; set; }
    }
}
