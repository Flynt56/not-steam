using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NotSteam.DB;
using NotSteam.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotSteam.Controllers
{
    public class LibrariesController : BaseController
    {
        public LibrariesController(NotSteamContext context) : base(context)
        { }

        // GET: api/Libraries
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Library>>> GetLibraries()
        {
            return await Context.Libraries.ToListAsync();
        }

        // GET: api/Libraries/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Library>> GetLibrary(int id)
        {
            var library = await Context.Libraries.FindAsync(id);

            if (library == null)
            {
                return NotFound();
            }

            return library;
        }

        // PUT: api/Libraries/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLibrary(int id, Library library)
        {
            if (id != library.Id)
            {
                return BadRequest();
            }

            Context.Entry(library).State = EntityState.Modified;

            try
            {
                await Context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LibraryExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return AcceptedAtAction(nameof(GetLibrary), new { id = library.Id }, library);
        }

        // POST: api/Libraries
        [HttpPost]
        public async Task<ActionResult<Library>> PostLibrary(Library library)
        {
            Context.Libraries.Add(library);
            await Context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetLibrary), new { id = library.Id }, library);
        }

        // DELETE: api/Libraries/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Library>> DeleteLibrary(int id)
        {
            var library = await Context.Libraries.FindAsync(id);
            if (library == null)
            {
                return NotFound();
            }

            Context.Libraries.Remove(library);
            await Context.SaveChangesAsync();

            return library;
        }

        private bool LibraryExists(int id)
        {
            return Context.Libraries.Any(e => e.Id == id);
        }
    }
}

