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
    public class PurchasesController : BaseController
    {
        private readonly IPurchaseService PurchaseService;

        public PurchasesController(IPurchaseService purchaseService, NotSteamContext context, IMapper mapper) : base(context, mapper)
        {
            PurchaseService = purchaseService;
        }

        [HttpGet]
        public async Task<IActionResult> GetPage([FromQuery]PurchasePaginationRequest request = null)
        {
            return ApiOk(await PurchaseService.GetPageAsync(request));
        }

        [HttpGet("{idUser}/{idGame}")]
        public async Task<IActionResult> GetOne(int idUser, int idGame)
        {
            return ApiOk(await PurchaseService.GetByIdAsync(idUser, idGame));
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
                    if (await PurchaseService.DoesExist(idUser, idGame))
                    {
                        throw;
                    }
                    else
                    {
                        return NotFound();
                    }
                }

                return AcceptedAtAction(nameof(GetOne), new { idUser = purchase.UserId, idGame = purchase.GameId }, purchase);
            }

            return BadRequest();
        }

        [HttpPost]
        public async Task<IActionResult> PostPurchase([FromBody]Purchase purchase)
        {
            return ApiOk(await PurchaseService.AddAsync(purchase));
        }

        [HttpDelete("{idUser}/{idGame}")]
        public async Task<IActionResult> DeletePurchase(int idUser, int idGame)
        {
            return ApiOk(await PurchaseService.DeleteByIdAsync(idUser, idGame));
        }
    }
}
