using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NotSteam.Core.Interfaces.Services;
using NotSteam.Core.Requests;
using NotSteam.Infrastructure.DB;
using NotSteam.Model.Models;

namespace NotSteam.Api.Controllers
{
    public class LibrariesController : BaseController
    {
        private readonly ILibraryService LibraryService;

        public LibrariesController(ILibraryService libraryService, NotSteamContext context, IMapper mapper) : base(context, mapper)
        {
            LibraryService = libraryService;
        }

        [HttpGet]
        public async Task<IActionResult> GetPage([FromQuery]LibraryPaginationRequest request = null)
        {
            return ApiOk(await LibraryService.GetPageAsync(request));
        }

        [HttpGet("{idUser}/{idGame}")]
        public async Task<IActionResult> GetOne(int idUser, int idGame)
        {
            return ApiOk(await LibraryService.GetByIdAsync(idUser, idGame));
        }

        [HttpPut("{idUser}/{idGame}")]
        public async Task<IActionResult> PutLibrary(int idUser, int idGame, [FromBody]Library library)
        {
            if (idUser == library.UserId && idGame == library.GameId)
            {
                _context.Entry(library).State = EntityState.Modified;

                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (await LibraryService.DoesExist(idUser, idGame))
                    {
                        throw;
                    }
                    else
                    {
                        return NotFound();
                    }
                }

                return AcceptedAtAction(nameof(GetOne), new { idUser = library.UserId, idGame = library.GameId }, library);
            }

            return BadRequest();
        }

        [HttpPost]
        public async Task<IActionResult> PostLibrary([FromBody]Library library)
        {
            return ApiOk(await LibraryService.AddAsync(library));
        }

        [HttpDelete("{idUser}/{idGame}")]
        public async Task<IActionResult> DeleteLibrary(int idUser, int idGame)
        {
            return ApiOk(await LibraryService.DeleteByIdAsync(idUser, idGame));
        }
    }
}
