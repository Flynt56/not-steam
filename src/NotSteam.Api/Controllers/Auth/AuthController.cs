using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NotSteam.Api.Core.Auth.Login.Command;
using NotSteam.Api.Core.Auth.Register.Command;

namespace NotSteam.Core.Controllers.Auth
{
    public class AuthController : AppController
    {
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            return ApiOk(await Mediator.Send(request));
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterRequest request)
        {
            return ApiOk(await Mediator.Send(request));
        }

        [Authorize]
        [HttpGet]
        public IActionResult Protected()
        {
            return ApiOk("Protected area");
        }
    }
}
