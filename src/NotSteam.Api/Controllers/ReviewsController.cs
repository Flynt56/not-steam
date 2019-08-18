﻿using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NotSteam.Core.ViewModels.Reviews;
using NotSteam.Infrastructure.DB;
using NotSteam.Model.Models;

namespace NotSteam.Api.Controllers
{
    public class ReviewsController : BaseController
    {
        public ReviewsController(NotSteamContext context, IMapper mapper) : base(context, mapper)
        {
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ReviewsList>>> GetReviews()
        {
            return Ok(await _context.Reviews.ProjectTo<ReviewsList>(_mapper.ConfigurationProvider).ToListAsync());
        }

        [HttpGet("{idUser}/{idGame}")]
        public async Task<ActionResult<ReviewDetails>> GetReview(int idUser, int idGame)
        {
            var review = await _context.Reviews.FindAsync(idUser, idGame);

            if (review == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<ReviewDetails>(review));
        }

        [HttpPut("{idUser}/{idGame}")]
        public async Task<IActionResult> PutReview(int idUser, int idGame, [FromBody]ReviewDetails review)
        {
            var r = _mapper.Map<Review>(review);

            if (idUser == r.UserId && idGame == r.GameId)
            {
                _context.Entry(r).State = EntityState.Modified;

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
        public async Task<ActionResult<Review>> PostReview([FromBody]ReviewDetails review)
        {
            await _context.Reviews.AddAsync(_mapper.Map<Review>(review));
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

