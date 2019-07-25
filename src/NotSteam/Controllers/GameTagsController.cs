using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NotSteam.DB;
using NotSteam.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotSteam.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameTagsController : ControllerBase
    {
        private readonly NotSteamContext _context;

        public GameTagsController(NotSteamContext context)
        {
            _context = context;
        }

        // GET: api/GameTags
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GameTag>>> GetGameTags()
        {
            return await _context.GameTags.ToListAsync();
        }

        // GET: api/GameTags/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GameTag>> GetGameTag(int id)
        {
            var gameTag = await _context.GameTags.FindAsync(id);

            if (gameTag == null)
            {
                return NotFound();
            }

            return gameTag;
        }

        // PUT: api/GameTags/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGameTag(int id, GameTag gameTag)
        {
            if (id != gameTag.Id)
            {
                return BadRequest();
            }

            _context.Entry(gameTag).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GameTagExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return AcceptedAtAction(nameof(GetGameTag), new { id = gameTag.Id }, gameTag);
        }

        // POST: api/GameTags
        [HttpPost]
        public async Task<ActionResult<GameTag>> PostGameTag(GameTag gameTag)
        {
            _context.GameTags.Add(gameTag);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetGameTag), new { id = gameTag.Id }, gameTag);
        }

        // DELETE: api/GameTags/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<GameTag>> DeleteGameTag(int id)
        {
            var gameTag = await _context.GameTags.FindAsync(id);
            if (gameTag == null)
            {
                return NotFound();
            }

            _context.GameTags.Remove(gameTag);
            await _context.SaveChangesAsync();

            return gameTag;
        }

        private bool GameTagExists(int id)
        {
            return _context.GameTags.Any(e => e.Id == id);
        }
    }
}

