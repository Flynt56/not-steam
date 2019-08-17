using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NotSteam.Core.ViewModels;

namespace NotSteam.Core.Controllers
{
    public class LibrariesController : BaseController
    {
        public LibrariesController(NotSteamContext context, IMapper mapper) : base(context, mapper)
        {
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<LibrariesList>>> GetLibraries()
        {
            return Ok(await _context.Libraries.ProjectTo<LibrariesList>(_mapper.ConfigurationProvider).ToListAsync());
        }

        [HttpGet("{idUser}/{idGame}")]
        public async Task<ActionResult<LibraryDetails>> GetLibrary(int idUser, int idGame)
        {
            var library = await _context.Libraries.FindAsync(idUser, idGame);

            if (library == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<LibraryDetails>(library));
        }

        [HttpPut("{idUser}/{idGame}")]
        public async Task<IActionResult> PutLibrary(int idUser, int idGame, [FromBody]LibraryDetails library)
        {
            var l = _mapper.Map<Library>(library);

            if (idUser == l.UserId && idGame == l.GameId)
            {
                _context.Entry(l).State = EntityState.Modified;

                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (await LibraryExists(idUser, idGame))
                    {
                        throw;
                    }
                    else
                    {
                        return NotFound();
                    }
                }

                return AcceptedAtAction(nameof(GetLibrary), new { idUser = library.UserId, idGame = library.GameId }, library);
            }

            return BadRequest();
        }

        [HttpPost]
        public async Task<ActionResult<Library>> PostLibrary([FromBody]LibraryDetails library)
        {
            await _context.Libraries.AddAsync(_mapper.Map<Library>(library));
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetLibrary), new { idUser = library.UserId, idGame = library.GameId }, library);
        }

        [HttpDelete("{idUser}/{idGame}")]
        public async Task<ActionResult<Library>> DeleteLibrary(int idUser, int idGame)
        {
            var library = await _context.Libraries.FindAsync(idUser, idGame);

            if (library == null)
            {
                return NotFound();
            }

            _context.Libraries.Remove(library);
            await _context.SaveChangesAsync();

            return library;
        }

        private async Task<bool> LibraryExists(int idUser, int idGame)
        {
            return await _context.Libraries.AnyAsync(e => e.UserId == idUser && e.GameId == idGame);
        }
    }
}
