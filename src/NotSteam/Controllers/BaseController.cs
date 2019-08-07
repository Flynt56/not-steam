using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NotSteam.DB;

namespace NotSteam.Controllers
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
    }
}

