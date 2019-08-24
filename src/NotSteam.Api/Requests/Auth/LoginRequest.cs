using System.ComponentModel.DataAnnotations;

namespace NotSteam.Api.Requests.Auth
{
    public class LoginRequest : AppRequest
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
