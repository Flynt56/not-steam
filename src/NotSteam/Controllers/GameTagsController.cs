using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NotSteam.DB;
using NotSteam.DTOs;
using NotSteam.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NotSteam.Controllers
{
    public class GameTagsController : BaseController
    {
        public GameTagsController(NotSteamContext context, IMapper mapper) : base(context, mapper)
        { }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<GameTagsList>>> GetGameTags()
        {
            return await _context.GameTags.ProjectTo<GameTagsList>(_mapper.ConfigurationProvider).ToListAsync();
        }

        [HttpGet("{idGame}/{idTag}")]
        public async Task<ActionResult<GameTagDetails>> GetGameTag(int idGame, int idTag)
        {
            var gameTag = await _context.GameTags.FindAsync(idGame, idTag);

            if (gameTag == null)
            {
                return NotFound();
            }

            return GameTagDetails.Create(gameTag);
        }

        [HttpPut("{idGame}/{idTag}")]
        public async Task<IActionResult> PutGameTag(int idGame, int idTag, [FromBody]GameTag gameTag)
        {
            if (idGame == gameTag.TagId && idTag == gameTag.GameId)
            {
                _context.Entry(gameTag).State = EntityState.Modified;

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

                return AcceptedAtAction(nameof(GetGameTag), new { idGame = gameTag.TagId, idTag = gameTag.GameId }, gameTag);
            }

            return BadRequest();
        }

        [HttpPost]
        public async Task<ActionResult<GameTag>> PostGameTag([FromBody]GameTag gameTag)
        {
            await _context.GameTags.AddAsync(gameTag);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetGameTag), new { idGame = gameTag.TagId, idTag = gameTag.GameId }, gameTag);
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
            return await _context.GameTags.AnyAsync(e => e.TagId == idGame && e.GameId == idTag);
        }
    }
}

