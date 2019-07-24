using System.Collections.Generic;
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
        }

        // GET api/games
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Game>>> GetGamesAsync()
        {
            return await _context.Games.ToListAsync();
        }

        // GET api/games/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Game>> GetGameAsync(int id)
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
        public async Task<ActionResult<Game>> PostGameAsync([FromBody] Game item)
        {
            await _context.Games.AddAsync(item);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetGameAsync), new { id = item.Id }, item);
        }

        // PUT api/games/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGameAsync(int id, [FromBody] Game item)
        {
            if (id != item.Id)
            {
                return BadRequest();
            }

            item.UpdateModificationDate();

            _context.Entry(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return AcceptedAtAction(nameof(GetGameAsync), new { id = item.Id }, item);
        }

        // DELETE api/games/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGameAsync(int id)
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
