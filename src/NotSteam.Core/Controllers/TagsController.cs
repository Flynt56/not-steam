using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NotSteam.Core.DB;
using NotSteam.Core.Models;
using NotSteam.Core.ViewModels;

namespace NotSteam.Core.Controllers
{
    public class TagsController : BaseController
    {
        public TagsController(NotSteamContext context, IMapper mapper) : base(context, mapper)
        {
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TagsList>>> GetTags()
        {
            return await _context.Tags.ProjectTo<TagsList>(_mapper.ConfigurationProvider).ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TagDetails>> GetTag(int id)
        {
            var tag = await _context.Tags.FindAsync(id);

            if (tag == null)
            {
                return NotFound();
            }

            return TagDetails.Create(tag);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutTag(int id, [FromBody]Tag tag)
        {
            if (id != tag.Id)
            {
                return BadRequest();
            }

            _context.Entry(tag).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (await TagExists(id))
                {
                    throw;
                }
                else
                {
                    return NotFound();
                }
            }

            return AcceptedAtAction(nameof(GetTag), new { id = tag.Id }, tag);
        }

        [HttpPost]
        public async Task<ActionResult<Tag>> PostTag([FromBody]Tag tag)
        {
            await _context.Tags.AddAsync(tag);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetTag), new { id = tag.Id }, tag);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Tag>> DeleteTag(int id)
        {
            var tag = await _context.Tags.FindAsync(id);
            if (tag == null)
            {
                return NotFound();
            }

            _context.Tags.Remove(tag);
            await _context.SaveChangesAsync();

            return tag;
        }

        private async Task<bool> TagExists(int id)
        {
            return await _context.Tags.AnyAsync(e => e.Id == id);
        }
    }
}

