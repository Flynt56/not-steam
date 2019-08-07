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
    public class PurchasesController : BaseController
    {
        public PurchasesController(NotSteamContext context, IMapper mapper) : base(context, mapper)
        {
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PurchasesList>>> GetPurchases()
        {
            return await _context.Purchases.ProjectTo<PurchasesList>(_mapper.ConfigurationProvider).ToListAsync();
        }

        [HttpGet("{idUser}/{idGame}")]
        public async Task<ActionResult<PurchaseDetails>> GetPurchase(int idUser, int idGame)
        {
            var purchase = await _context.Purchases.FindAsync(idUser, idGame);

            if (purchase == null)
            {
                return NotFound();
            }

            return PurchaseDetails.Create(purchase);
        }

        [HttpPut("{idUser}/{idGame}")]
        public async Task<IActionResult> PutPurchase(int idUser, int idGame, [FromBody]Purchase purchase)
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

        [HttpDelete("{idUser}/{idGame}")]
        public async Task<ActionResult<Purchase>> DeletePurchase(int idUser, int idGame)
        {
            var purchase = await _context.Purchases.FindAsync(idUser, idGame);

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

