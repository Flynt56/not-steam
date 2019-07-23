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
    public class LibrariesController : ControllerBase
    {
        private readonly NotSteamContext _context;

        public LibrariesController(NotSteamContext context)
        {
            _context = context;
        }

        // GET api/tags
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Library>>> GetLibrariesAsync()
        {
            return await _context.Libraries.ToListAsync();
        }

        // GET api/tags/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Library>> GetLibraryAsync(int id)
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
        public async Task<ActionResult<Library>> PostLibraryAsync([FromBody] Library item)
        {
            await _context.Libraries.AddAsync(item);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetLibraryAsync), new { id = item.Id }, item);
        }

        // PUT api/tags/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLibraryAsync(int id, [FromBody] Library item)
        {
            if (id != item.Id)
            {
                return BadRequest();
            }

            _context.Entry(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return AcceptedAtAction(nameof(GetLibraryAsync), new { id = item.Id }, item);
        }

        // DELETE api/tags/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLibraryAsync(int id)
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
