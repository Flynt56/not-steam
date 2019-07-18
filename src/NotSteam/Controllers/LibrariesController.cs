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
    public class LibrariesController : ControllerBase
    {
        private readonly NotSteamContext _context;

        public LibrariesController(NotSteamContext context)
        {
            _context = context;

            // Add default entries
            if (_context.Libraries.Count() < 3)
            {
                _context.Libraries.Add(new Library { UserId = 1, GameId = 2, TotalPlayTimeHours = 321 });
                _context.Libraries.Add(new Library { UserId = 2, GameId = 2, TotalPlayTimeHours = 40 });
                _context.Libraries.Add(new Library { UserId = 1, GameId = 1, TotalPlayTimeHours = 10 });
                _context.SaveChanges();
            }
        }

        // GET api/tags
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Library>>> GetLibraries()
        {
            return await _context.Libraries.ToListAsync();
        }

        // GET api/tags/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Library>> GetLibrary(int id)
        {
            var tag = await _context.Libraries.FindAsync(id);

            if (tag == null)
            {
                return NotFound();
            }

            return tag;
        }

        // POST api/tags
        [HttpPost]
        public async Task<ActionResult<Library>> PostLibrary([FromBody] Library item)
        {
            await _context.Libraries.AddAsync(item);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetLibrary), new { id = item.Id }, item);
        }

        // PUT api/tags/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLibrary(int id, [FromBody] Library item)
        {
            if (id != item.Id)
            {
                return BadRequest();
            }

            _context.Entry(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE api/tags/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLibrary(int id)
        {
            var tag = await _context.Libraries.FindAsync(id);

            if (tag == null)
            {
                return NotFound();
            }

            _context.Libraries.Remove(tag);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
