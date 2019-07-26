using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NotSteam.DB;
using NotSteam.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotSteam.Controllers
{
    public class GamesController : BaseController
    {
        public GamesController(NotSteamContext context) : base(context)
        { }

        // GET: api/Games
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Game>>> GetGames()
        {
            return await Context.Games.ToListAsync();
        }

        // GET: api/Games/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Game>> GetGame(int id)
        {
            var game = await Context.Games.FindAsync(id);

            if (game == null)
            {
                return NotFound();
            }

            return game;
        }

        // PUT: api/Games/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGame(int id, [FromBody]Game game)
        {
            if (id != game.Id)
            {
                return BadRequest();
            }

            Context.Entry(game).State = EntityState.Modified;

            try
            {
                await Context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GameExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return AcceptedAtAction(nameof(GetGame), new { id = game.Id }, game);
        }

        // POST: api/Games
        [HttpPost]
        public async Task<ActionResult<Game>> PostGame([FromBody]Game game)
        {
            Context.Games.Add(game);
            await Context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetGame), new { id = game.Id }, game);
        }

        // DELETE: api/Games/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Game>> DeleteGame(int id)
        {
            var game = await Context.Games.FindAsync(id);
            if (game == null)
            {
                return NotFound();
            }

            Context.Games.Remove(game);
            await Context.SaveChangesAsync();

            return game;
        }

        private bool GameExists(int id)
        {
            return Context.Games.Any(e => e.Id == id);
        }
    }
}

