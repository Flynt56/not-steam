using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NotSteam.Core.App.Auth.Login.Command;
using NotSteam.Core.App.Auth.Register.Command;

namespace NotSteam.Api.Controllers.Auth
{
    public class AuthController : AppController
    {
        [HttpPost]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            return ApiOk(await Mediator.Send(request));
        }

        [HttpPost]
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
