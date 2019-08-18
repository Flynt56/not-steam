using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NotSteam.Core.ViewModels;
using NotSteam.Infrastructure.DB;
using NotSteam.Model.Models;

namespace NotSteam.Api.Controllers
{
    public class GameTagsController : BaseController
    {
        public GameTagsController(NotSteamContext context, IMapper mapper) : base(context, mapper)
        { }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<GameTagsList>>> GetGameTags()
        {
            return Ok(await _context.GameTags.ProjectTo<GameTagsList>(_mapper.ConfigurationProvider).ToListAsync());
        }

        [HttpGet("{idGame}/{idTag}")]
        public async Task<ActionResult<GameTagDetails>> GetGameTag(int idGame, int idTag)
        {
            var gameTag = await _context.GameTags.FindAsync(idGame, idTag);

            if (gameTag == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<GameTagDetails>(gameTag));
        }

        [HttpPut("{idGame}/{idTag}")]
        public async Task<IActionResult> PutGameTag(int idGame, int idTag, [FromBody]GameTagDetails gameTag)
        {
            var gt = _mapper.Map<GameTag>(gameTag);

            if (idTag == gt.TagId && idGame == gt.GameId)
            {

                _context.Entry(gt).State = EntityState.Modified;

                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (await GameTagExists(idGame, idTag))
                    {
                        throw;
                    }
                    else
                    {
                        return NotFound();
                    }
                }

                return AcceptedAtAction(nameof(GetGameTag), new { idGame = gameTag.GameId, idTag = gameTag.TagId }, gameTag);
            }

            return BadRequest();
        }

        [HttpPost]
        public async Task<ActionResult<GameTag>> PostGameTag([FromBody]GameTagDetails gameTag)
        {
            await _context.GameTags.AddAsync(_mapper.Map<GameTag>(gameTag));
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetGameTag), new { idGame = gameTag.GameId, idTag = gameTag.TagId }, gameTag);
        }

        [HttpDelete("{idGame}/{idTag}")]
        public async Task<ActionResult<GameTag>> DeleteGameTag(int idGame, int idTag)
        {
            var gameTag = await _context.GameTags.FindAsync(idGame, idTag);

            if (gameTag == null)
            {
                return NotFound();
            }

            _context.GameTags.Remove(gameTag);
            await _context.SaveChangesAsync();

            return gameTag;
        }

        private async Task<bool> GameTagExists(int idGame, int idTag)
        {
            return await _context.GameTags.AnyAsync(e => e.TagId == idTag && e.GameId == idGame);
        }
    }
}

