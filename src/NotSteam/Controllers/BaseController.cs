using Microsoft.AspNetCore.Mvc;
using NotSteam.DB;

namespace NotSteam.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class BaseController : ControllerBase
    {
        private readonly NotSteamContext context;

        protected NotSteamContext Context => context;

        public BaseController(NotSteamContext context)
        {
            this.context = context;
        }
    }
}

