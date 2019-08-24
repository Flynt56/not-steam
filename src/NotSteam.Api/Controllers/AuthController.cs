using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using NotSteam.Infrastructure.DB;

namespace NotSteam.Api.Controllers
{
    [Authorize]
    public abstract class AuthController : BaseController
    {
    }
}
