using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NotSteam.Core.Requests;
using NotSteam.Core.Services.Contracts;
using NotSteam.Infrastructure.DB;
using NotSteam.Model.Models;

namespace NotSteam.Api.Controllers
{
    public class ReviewsController : BaseController
    {
        private readonly IReviewService ReviewService;

        public ReviewsController(IReviewService reviewService, NotSteamContext context, IMapper mapper) : base(context, mapper)
        {
            ReviewService = reviewService;
        }

        [HttpGet]
        public async Task<IActionResult> GetPage([FromQuery]ReviewPaginationRequest request = null)
        {
            return ApiOk(await ReviewService.GetPageAsync(request));
        }

        [HttpGet("{idUser}/{idGame}")]
        public async Task<IActionResult> GetOne(int idUser, int idGame)
        {
            return ApiOk(await ReviewService.GetByIdAsync(idUser, idGame));
        }

        [HttpPut("{idUser}/{idGame}")]
        public async Task<IActionResult> PutReview(int idUser, int idGame, [FromBody]Review review)
        {
            if (idUser == review.UserId && idGame == review.GameId)
            {
                _context.Entry(review).State = EntityState.Modified;

                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (await ReviewService.DoesExist(idUser, idGame))
                    {
                        throw;
                    }
                    else
                    {
                        return NotFound();
                    }
                }

                return AcceptedAtAction(nameof(GetOne), new { idUser = review.UserId, idGame = review.GameId }, review);
            }

            return BadRequest();
        }

        [HttpPost]
        public async Task<IActionResult> AddOneAsync([FromBody]Review review)
        {
            return ApiOk(await ReviewService.AddAsync(review));
        }

        [HttpDelete("{idUser}/{idGame}")]
        public async Task<IActionResult> DeleteReview(int idUser, int idGame)
        {
            return ApiOk(await ReviewService.DeleteByIdAsync(idUser, idGame));
        }
    }
}
