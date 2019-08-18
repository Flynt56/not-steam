using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NotSteam.Core.ViewModels.Games;
using NotSteam.Infrastructure.DB;
using NotSteam.Model.Models;

namespace NotSteam.Api.Controllers
{
    public class GamesController : BaseController
    {
        public GamesController(NotSteamContext context, IMapper mapper) : base(context, mapper)
        {
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<GamesList>>> GetGames()
        {
            return await _context.Games.ProjectTo<GamesList>(_mapper.ConfigurationProvider).ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<GameDetails>> GetGame(int id)
        {
            var game = await _context.Games.FindAsync(id);

            if (game == null)
            {
                return NotFound();
            }

            return _mapper.Map<GameDetails>(game);
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
                if (await GameExists(id))
                {
                    throw;
                }
                else
                {
                    return NotFound();
                }
            }

            return AcceptedAtAction(nameof(GetGame), new { id = game.Id }, game);
        }

        [HttpPost]
        public async Task<ActionResult<Game>> PostGame([FromBody]Game game)
        {
            await _context.Games.AddAsync(game);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetGame), new { id = game.Id }, game);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Game>> DeleteGame(int id)
        {
            var game = await _context.Games.FindAsync(id);
            if (game == null)
            {
                return NotFound();
            }

            _context.Games.Remove(game);
            await _context.SaveChangesAsync();

            return game;
        }

        private async Task<bool> GameExists(int id)
        {
            return await _context.Games.AnyAsync(e => e.Id == id);
        }
    }
}

