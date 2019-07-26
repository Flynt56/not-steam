using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NotSteam.DB;
using NotSteam.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NotSteam.Controllers
{
    public class PurchasesController : BaseController
    {
        public PurchasesController(NotSteamContext context) : base(context)
        { }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Purchase>>> GetPurchases()
        {
            return await _context.Purchases.ToListAsync();
        }

        [HttpGet("{idUser:int}/{idGame:int}", Name = "GetPurchase")]
        public async Task<ActionResult<Purchase>> GetPurchase([FromQuery]int idUser, [FromQuery]int idGame)
        {
            var purchase = await _context.Purchases.FindAsync(new { idUser, idGame });

            if (purchase == null)
            {
                return NotFound();
            }

            return purchase;
        }

        [HttpGet("{idUser:int}/{idGame:int}", Name = "PutPurchase")]
        public async Task<IActionResult> PutPurchase([FromQuery]int idUser, [FromQuery]int idGame, [FromBody]Purchase purchase)
        {
            if (idUser == purchase.UserId && idGame == purchase.GameId)
            {
                _context.Entry(purchase).State = EntityState.Modified;

                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (await PurchaseExists(idUser, idGame))
                    {
                        throw;
                    }
                    else
                    {
                        return NotFound();
                    }
                }

                return AcceptedAtAction(nameof(GetPurchase), new { idUser = purchase.UserId, idGame = purchase.GameId }, purchase);
            }

            return BadRequest();
        }

        [HttpPost]
        public async Task<ActionResult<Purchase>> PostPurchase([FromBody]Purchase purchase)
        {
            await _context.Purchases.AddAsync(purchase);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetPurchase), new { idUser = purchase.UserId, idGame = purchase.GameId }, purchase);
        }

        [HttpDelete("{idUser:int}/{idGame:int}", Name = "DeletePurchase")]
        public async Task<ActionResult<Purchase>> DeletePurchase([FromQuery]int idUser, [FromQuery]int idGame)
        {
            var purchase = await _context.Purchases.FindAsync(new { idUser, idGame });

            if (purchase == null)
            {
                return NotFound();
            }

            _context.Purchases.Remove(purchase);
            await _context.SaveChangesAsync();

            return purchase;
        }

        private async Task<bool> PurchaseExists(int idUser, int idGame)
        {
            return await _context.Purchases.AnyAsync(e => e.UserId == idUser && e.GameId == idGame);
        }
    }
}

