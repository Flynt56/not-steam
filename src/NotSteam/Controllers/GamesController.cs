using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NotSteam.DB;
using NotSteam.Models;

namespace NotSteam.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamesController : ControllerBase
    {
        private readonly NotSteamContext _context;

        public GamesController(NotSteamContext context)
        {
            _context = context;

            // Add default entries
            if (_context.Games.Count() < 2)
            {
                _context.Games.Add(new Game { Title = "World of Minecraft", CompanyId = 5 });
                _context.Games.Add(new Game { Title = "C4ll of $$$$", CompanyId = 6 });
                _context.SaveChanges();
            }
        }

        // GET api/games
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Game>>> GetGames()
        {
            return await _context.Games.ToListAsync();
        }

        // GET api/games/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Game>> GetGame(int id)
        {
            var game = await _context.Games.FindAsync(id);

            if (game == null)
            {
                return NotFound();
            }

            return game;
        }

        // POST api/games
        [HttpPost]
        public async Task<ActionResult<Game>> PostGame([FromBody] Game item)
        {
            await _context.Games.AddAsync(item);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetGame), new { id = item.Id }, item);
        }

        // PUT api/games/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGame(int id, [FromBody] Game item)
        {
            if (id != item.Id)
            {
                return BadRequest();
            }

            _context.Entry(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE api/games/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGame(int id)
        {
            var game = await _context.Games.FindAsync(id);

            if (game == null)
            {
                return NotFound();
            }

            _context.Games.Remove(game);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
