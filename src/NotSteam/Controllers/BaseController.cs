using Microsoft.AspNetCore.Mvc;

namespace NotSteam.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class BaseController : ControllerBase
    {
    }
}

