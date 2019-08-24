using System.Net;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using NotSteam.Infrastructure.DB;

namespace NotSteam.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class BaseController : ControllerBase
    {
        private NotSteamContext _context;
        private IMapper _mapper;
        private IMediator _mediator;

        protected NotSteamContext Context => _context ?? (_context = HttpContext.RequestServices.GetRequiredService<NotSteamContext>());
        protected IMapper Mapper => _mapper ?? (_mapper = HttpContext.RequestServices.GetRequiredService<IMapper>());
        protected IMediator Mediator => _mediator ?? (_mediator = HttpContext.RequestServices.GetRequiredService<IMediator>());

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
            return Ok(ApiResponse.ApiResponse.Ok(code, data));
        }
    }
}
