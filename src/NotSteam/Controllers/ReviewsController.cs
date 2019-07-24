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
    public class ReviewsController : ControllerBase
    {
        private readonly NotSteamContext _context;

        public ReviewsController(NotSteamContext context)
        {
            _context = context;
        }

        // GET api/tags
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Review>>> GetReviewsAsync()
        {
            return await _context.Reviews.ToListAsync();
        }

        // GET api/tags/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Review>> GetReviewAsync(int id)
        {
            var tag = await _context.Reviews.FindAsync(id);

            if (tag == null)
            {
                return NotFound();
            }

            return tag;
        }

        // POST api/tags
        [HttpPost]
        public async Task<ActionResult<Review>> PostReviewAsync([FromBody] Review item)
        {
            await _context.Reviews.AddAsync(item);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetReviewAsync), new { id = item.Id }, item);
        }

        // PUT api/tags/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutReviewAsync(int id, [FromBody] Review item)
        {
            if (id != item.Id)
            {
                return BadRequest();
            }

            item.UpdateModificationDate();

            _context.Entry(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return AcceptedAtAction(nameof(GetReviewAsync), new { id = item.Id }, item);
        }

        // DELETE api/tags/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteReviewAsync(int id)
        {
            var tag = await _context.Reviews.FindAsync(id);

            if (tag == null)
            {
                return NotFound();
            }

            _context.Reviews.Remove(tag);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
