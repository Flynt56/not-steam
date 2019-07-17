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
    public class PurchasesController : ControllerBase
    {
        private readonly NotSteamContext _context;

        public PurchasesController(NotSteamContext context)
        {
            _context = context;

            // Add default entries
            if (_context.Purchases.Count() < 3)
            {
                _context.Purchases.Add(new Purchase { UserId = 1, GameId = 1, TotalPrice = 29.99M });
                _context.Purchases.Add(new Purchase { UserId = 2, GameId = 1, TotalPrice = 59.99M });
                _context.Purchases.Add(new Purchase { UserId = 1, GameId = 2, TotalPrice = 44.99M });
                _context.SaveChanges();
            }
        }

        // GET api/tags
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Purchase>>> GetPurchases()
        {
            return await _context.Purchases.ToListAsync();
        }

        // GET api/tags/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Purchase>> GetPurchase(int id)
        {
            var tag = await _context.Purchases.FindAsync(id);

            if (tag == null)
            {
                return NotFound();
            }

            return tag;
        }

        // POST api/tags
        [HttpPost]
        public async Task<ActionResult<Purchase>> PostPurchase([FromBody] Purchase item)
        {
            await _context.Purchases.AddAsync(item);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetPurchase), new { id = item.Id }, item);
        }

        // PUT api/tags/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPurchase(int id, [FromBody] Purchase item)
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
        public async Task<IActionResult> DeletePurchase(int id)
        {
            var tag = await _context.Purchases.FindAsync(id);

            if (tag == null)
            {
                return NotFound();
            }

            _context.Purchases.Remove(tag);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
