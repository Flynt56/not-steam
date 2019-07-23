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
    public class GameTagsController : ControllerBase
    {
        private readonly NotSteamContext _context;

        public GameTagsController(NotSteamContext context)
        {
            _context = context;
        }

        // GET api/tags
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GameTag>>> GetGameTags()
        {
            return await _context.GameTags.ToListAsync();
        }

        // GET api/tags/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GameTag>> GetGameTag(int id)
        {
            var tag = await _context.GameTags.FindAsync(id);

            if (tag == null)
            {
                return NotFound();
            }

            return tag;
        }

        // POST api/tags
        [HttpPost]
        public async Task<ActionResult<GameTag>> PostGameTag([FromBody] GameTag item)
        {
            await _context.GameTags.AddAsync(item);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetGameTag), new { id = item.Id }, item);
        }

        // PUT api/tags/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGameTag(int id, [FromBody] GameTag item)
        {
            if (id != item.Id)
            {
                return BadRequest();
            }

            _context.Entry(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return AcceptedAtAction(nameof(GetGameTag), new { id = item.Id }, item);
        }

        // DELETE api/tags/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGameTag(int id)
        {
            var tag = await _context.GameTags.FindAsync(id);

            if (tag == null)
            {
                return NotFound();
            }

            _context.GameTags.Remove(tag);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
