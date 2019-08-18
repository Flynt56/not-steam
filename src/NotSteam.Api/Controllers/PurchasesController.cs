﻿using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NotSteam.Core.ViewModels.Purchases;
using NotSteam.Infrastructure.DB;
using NotSteam.Model.Models;

namespace NotSteam.Api.Controllers
{
    public class PurchasesController : BaseController
    {
        public PurchasesController(NotSteamContext context, IMapper mapper) : base(context, mapper)
        {
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PurchasesList>>> GetPurchases()
        {
            return Ok(await _context.Purchases.ProjectTo<PurchasesList>(_mapper.ConfigurationProvider).ToListAsync());
        }

        [HttpGet("{idUser}/{idGame}")]
        public async Task<ActionResult<PurchaseDetails>> GetPurchase(int idUser, int idGame)
        {
            var purchase = await _context.Purchases.FindAsync(idUser, idGame);

            if (purchase == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<PurchaseDetails>(purchase));
        }

        [HttpPut("{idUser}/{idGame}")]
        public async Task<IActionResult> PutPurchase(int idUser, int idGame, [FromBody]PurchaseDetails purchase)
        {
            var purchaseOriginal = _mapper.Map<Purchase>(purchase);

            if (idUser == purchaseOriginal.UserId && idGame == purchaseOriginal.GameId)
            {
                _context.Entry(purchaseOriginal).State = EntityState.Modified;

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
        public async Task<ActionResult<Purchase>> PostPurchase([FromBody]PurchaseDetails purchase)
        {
            await _context.Purchases.AddAsync(_mapper.Map<Purchase>(purchase));
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
