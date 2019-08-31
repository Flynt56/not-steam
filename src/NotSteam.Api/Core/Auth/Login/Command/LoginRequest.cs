﻿using MediatR;

namespace NotSteam.Api.Core.Auth.Login.Command
{
    public class LoginRequest : IRequest<LoginResponse>
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
