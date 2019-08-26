using Microsoft.AspNetCore.Authorization;

namespace NotSteam.Core.Controllers
{
    [Authorize]
    public abstract class AppAuthorizedController : AppController
    {

    }
}
