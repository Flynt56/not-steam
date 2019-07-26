using Microsoft.AspNetCore.Mvc;
using NotSteam.DB;

namespace NotSteam.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class BaseController : ControllerBase
    {
        protected readonly NotSteamContext _context;

        public BaseController(NotSteamContext context)
        {
            _context = context;
        }
    }
}

