﻿using Microsoft.AspNetCore.Authorization;

namespace NotSteam.Api.Controllers
{
    [Authorize]
    public abstract class AuthController : AppController
    {
    }
}
