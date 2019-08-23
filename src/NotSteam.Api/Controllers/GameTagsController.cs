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
    public class GameTagsController : BaseController
    {
        private readonly IGameTagService GameTagService;

        public GameTagsController(IGameTagService gameTagService, NotSteamContext context, IMapper mapper) : base(context, mapper)
        {
            GameTagService = gameTagService;
        }

        [HttpGet]
        public async Task<IActionResult> GetPage([FromQuery]GameTagPaginationRequest request = null)
        {
            return ApiOk(await GameTagService.GetPageAsync(request));
        }

        [HttpGet("{idGame}/{idTag}")]
        public async Task<IActionResult> GetOne(int idGame, int idTag)
        {
            return ApiOk(await GameTagService.GetByIdAsync(idGame, idTag));
        }

        [HttpPut("{idGame}/{idTag}")]
        public async Task<IActionResult> PutGameTag(int idGame, int idTag, [FromBody]GameTag gameTag)
        {
            if (idTag == gameTag.TagId && idGame == gameTag.GameId)
            {
                _context.Entry(gameTag).State = EntityState.Modified;

                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (await GameTagService.DoesExist(idGame, idTag))
                    {
                        throw;
                    }
                    else
                    {
                        return NotFound();
                    }
                }

                return AcceptedAtAction(nameof(GetOne), new { idGame = gameTag.GameId, idTag = gameTag.TagId }, gameTag);
            }

            return BadRequest();
        }

        [HttpPost]
        public async Task<IActionResult> PostGameTag([FromBody]GameTag gameTag)
        {
            return ApiOk(await GameTagService.AddAsync(gameTag));
        }

        [HttpDelete("{idGame}/{idTag}")]
        public async Task<IActionResult> DeleteGameTag(int idGame, int idTag)
        {
            return ApiOk(await GameTagService.DeleteByIdAsync(idGame, idTag));
        }
    }
}
