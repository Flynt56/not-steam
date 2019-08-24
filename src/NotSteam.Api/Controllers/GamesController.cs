using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NotSteam.Core.App.Games.Queries.GetGameDetail;
using NotSteam.Core.App.Games.Queries.GetPaginatedGamesList;
using NotSteam.Core.Interfaces.Services;
using NotSteam.Core.Requests;
using NotSteam.Core.ViewModels.Games;
using NotSteam.Infrastructure.DB;
using NotSteam.Model.Models;
using NotSteam.Shared.Pagination;

namespace NotSteam.Api.Controllers
{
    public class GamesController : BaseController
    {
        [HttpGet]
        public async Task<IActionResult> GetPage([FromQuery]GetPaginatedGamesListQuery request = null)
        {
            return ApiOk(await Mediator.Send(request));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetOne(int id)
        {
            return ApiOk(await GameService.GetByIdAsync(id));
        }

        [HttpGet("dropdown")]
        public async Task<IActionResult> GetDropdown()
        {
            return ApiOk(await GameService.GetDropdown());
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
