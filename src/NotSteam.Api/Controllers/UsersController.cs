using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NotSteam.Core.Requests;
using NotSteam.Core.Services.Contracts;
using NotSteam.Infrastructure.DB;
using NotSteam.Model.Models;

namespace NotSteam.Api.Controllers
{
    public class UsersController : BaseController
    {
        private readonly IUserService UserService;

        public UsersController(IUserService userService, NotSteamContext context, IMapper mapper) : base(context, mapper)
        {
            UserService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> GetPage([FromQuery] UserPaginationRequest request = null)
        {
            return ApiOk(await UserService.GetPageAsync(request));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetOne(int id)
        {
            return ApiOk(await UserService.GetByIdAsync(id));
        }

        [HttpGet("dropdown")]
        public async Task<IActionResult> GetDropdown()
        {
            return ApiOk(await UserService.GetDropdown());
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutUser(int id, [FromBody]User user)
        {
            if (id != user.Id)
            {
                return BadRequest();
            }

            _context.Entry(user).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (await UserService.DoesExist(id))
                {
                    throw;
                }
                else
                {
                    return NotFound();
                }
            }

            return AcceptedAtAction(nameof(GetOne), new { id = user.Id }, user);
        }

        [HttpPost]
        public async Task<IActionResult> AddOneAsync([FromBody]User user)
        {
            return ApiOk(await UserService.AddAsync(user));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOneAsync(int id)
        {
            return ApiOk(await UserService.DeleteByIdAsync(id));
        }
    }
}
