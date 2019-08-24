using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NotSteam.Core.App.Games.Queries.GetGameDetail;
using NotSteam.Core.App.Games.Queries.GetPaginatedGamesList;
using NotSteam.Model.Models;

namespace NotSteam.Api.Controllers
{
    public class GamesController : BaseController
    {
        [HttpGet]
        public async Task<IActionResult> GetPage([FromQuery] GetPaginatedGamesListQuery query = null)
        {
            return ApiOk(await Mediator.Send(query));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetOne([FromQuery] GetGameDetailQuery query)
        {
            return ApiOk(await Mediator.Send(query));
        }

        [HttpGet("dropdown")]
        public async Task<IActionResult> GetDropdown()
        {
            return ApiOk(await Mediator.Send(new GetGamesMapQuery()));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutGame(int id, [FromBody]Game game)
        {
            if (id != game.Id)
            {
                return BadRequest();
            }

            _context.Entry(game).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (await GameService.DoesExist(id))
                {
                    throw;
                }
                else
                {
                    return NotFound();
                }
            }

            return AcceptedAtAction(nameof(GetOne), new { id = game.Id }, game);
        }

        [HttpPost]
        public async Task<IActionResult> PostGame([FromBody]Game game)
        {
            return ApiOk(await GameService.AddAsync(game));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGame(int id)
        {
            return ApiOk(await GameService.DeleteByIdAsync(id));
        }
    }
}
