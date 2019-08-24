using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NotSteam.Api.Requests.Auth;
using NotSteam.Api.Responses;
using NotSteam.Core.Interfaces.Services;

namespace NotSteam.Api.Controllers.Auth
{
    public class AuthController : AppController
    {
        private readonly IAuthService AuthService;
        private readonly IUserService UserService;

        public AuthController(
            IAuthService authService,
            IUserService userService
            )
        {
            AuthService = authService;
            UserService = userService;
        }

        [HttpPost]
        public async Task<object> Login([FromBody] LoginRequest request)
        {
            string token = await AuthService.SignInAsync(request.Email, request.Password);

            if (string.IsNullOrEmpty(token))
            {
                throw new ApplicationException("INVALID_LOGIN_ATTEMPT");
            }

            return token;
        }

        [HttpPost]
        public async Task<RegisterResponse> Register([FromBody] RegisterRequest request)
        {
            string token = await AuthService.RegisterAsync(request.Email, request.Password);
            var user = await UserService.GetByEmailAsync(request.Email);

            if (string.IsNullOrEmpty(token))
            {
                throw new ApplicationException("UNKNOWN_ERROR");
            }

            return new RegisterResponse
            {
                User = new AuthUserResponse
                {
                    Id = 1,
                    Email = user.Email
                },
                Token = token
            };
        }

        [Authorize]
        [HttpGet]
        public object Protected()
        {
            return "Protected area";
        }
    }
}
