﻿using System.Net;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace NotSteam.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class BaseController : ControllerBase
    {
        private IMediator _mediator;

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
