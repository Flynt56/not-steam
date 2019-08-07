using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NotSteam.Core.DB;
using NotSteam.Core.Models;
using NotSteam.Core.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NotSteam.Core.Controllers
{
    public class ReviewsController : BaseController
    {
        public ReviewsController(NotSteamContext context, IMapper mapper) : base(context, mapper)
        {
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ReviewsList>>> GetReviews()
        {
            return await _context.Reviews.ProjectTo<ReviewsList>(_mapper.ConfigurationProvider).ToListAsync();
        }

        [HttpGet("{idUser}/{idGame}")]
        public async Task<ActionResult<ReviewDetails>> GetReview(int idUser, int idGame)
        {
            var review = await _context.Reviews.FindAsync(idUser, idGame);

            if (review == null)
            {
                return NotFound();
            }

            return ReviewDetails.Create(review);
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

        [HttpDelete("{idUser}/{idGame}")]
        public async Task<ActionResult<Review>> DeleteReview(int idUser, int idGame)
        {
            var review = await _context.Reviews.FindAsync(idUser, idGame);

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

