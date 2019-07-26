using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NotSteam.DB;
using NotSteam.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotSteam.Controllers
{
    public class GameTagsController : BaseController
    {
        public GameTagsController(NotSteamContext context) : base(context)
        { }

        // GET: api/GameTags
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GameTag>>> GetGameTags()
        {
            return await Context.GameTags.ToListAsync();
        }

        // GET: api/GameTags/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GameTag>> GetGameTag(int id)
        {
            var gameTag = await Context.GameTags.FindAsync(id);

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

            Context.Entry(gameTag).State = EntityState.Modified;

            try
            {
                await Context.SaveChangesAsync();
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
            Context.GameTags.Add(gameTag);
            await Context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetGameTag), new { id = gameTag.Id }, gameTag);
        }

        // DELETE: api/GameTags/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<GameTag>> DeleteGameTag(int id)
        {
            var gameTag = await Context.GameTags.FindAsync(id);
            if (gameTag == null)
            {
                return NotFound();
            }

            Context.GameTags.Remove(gameTag);
            await Context.SaveChangesAsync();

            return gameTag;
        }

        private bool GameTagExists(int id)
        {
            return Context.GameTags.Any(e => e.Id == id);
        }
    }
}

