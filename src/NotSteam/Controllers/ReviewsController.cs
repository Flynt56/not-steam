using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NotSteam.DB;
using NotSteam.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NotSteam.Controllers
{
    public class ReviewsController : BaseController
    {
        public ReviewsController(NotSteamContext context) : base(context)
        { }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Review>>> GetReviews()
        {
            return await _context.Reviews.ToListAsync();
        }

        [HttpGet("{idUser:int}/{idGame:int}", Name = "GetReview")]
        public async Task<ActionResult<Review>> GetReview([FromQuery]int idUser, [FromQuery]int idGame)
        {
            var review = await _context.Reviews.FindAsync(new { idUser, idGame });

            if (review == null)
            {
                return NotFound();
            }

            return review;
        }

        [HttpGet("{idUser:int}/{idGame:int}", Name = "PutReview")]
        public async Task<IActionResult> PutReview([FromQuery]int idUser, [FromQuery]int idGame, [FromBody]Review review)
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
                    if (await ReviewExists(idUser, idGame))
                    {
                        throw;
                    }
                    else
                    {
                        return NotFound();
                    }
                }

                return AcceptedAtAction(nameof(GetReview), new { idUser = review.UserId, idGame = review.GameId }, review);
            }

            return BadRequest();
        }

        [HttpPost]
        public async Task<ActionResult<Review>> PostReview([FromBody]Review review)
        {
            await _context.Reviews.AddAsync(review);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetReview), new { idUser = review.UserId, idGame = review.GameId }, review);
        }

        [HttpDelete("{idUser:int}/{idGame:int}", Name = "DeleteReview")]
        public async Task<ActionResult<Review>> DeleteReview([FromQuery]int idUser, [FromQuery]int idGame)
        {
            var review = await _context.Reviews.FindAsync(new { idUser, idGame });

            if (review == null)
            {
                return NotFound();
            }

            _context.Reviews.Remove(review);
            await _context.SaveChangesAsync();

            return review;
        }

        private async Task<bool> ReviewExists(int idUser, int idGame)
        {
            return await _context.Reviews.AnyAsync(e => e.UserId == idUser && e.GameId == idGame);
        }
    }
}

