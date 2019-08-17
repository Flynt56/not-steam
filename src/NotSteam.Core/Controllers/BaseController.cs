using System.Net;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NotSteam.Infrastructure.DB;

namespace NotSteam.Core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class BaseController : ControllerBase
    {
        protected readonly NotSteamContext _context;
        protected readonly IMapper _mapper;

        public BaseController(NotSteamContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        protected IActionResult ApiOk()
        {
            return ApiOk(HttpStatusCode.OK, null);
        }

        protected IActionResult ApiOk(object data)
        {
            return ApiOk(HttpStatusCode.OK, data);
        }

        protected IActionResult ApiOk(HttpStatusCode code, object data)
        {
            return Ok(NotSteam.Api.ApiResponse.ApiResponse.Ok(code, data));

        }
    }
}
