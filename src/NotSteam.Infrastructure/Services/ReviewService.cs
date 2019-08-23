using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using NotSteam.Core.Interfaces.Services;
using NotSteam.Core.Requests;
using NotSteam.Core.ViewModels.Reviews;
using NotSteam.Infrastructure.DB;
using NotSteam.Model.Models;
using NotSteam.Shared.Extensions;
using NotSteam.Shared.Pagination;

namespace NotSteam.Infrastructure.Services
{
    public class ReviewService : BaseService, IReviewService
    {
        private readonly NotSteamContext _context;
        private readonly IMapper _mapper;

        public ReviewService(NotSteamContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<PagedResult<ReviewsList>> GetPageAsync(ReviewPaginationRequest request)
        {
            var pagedResult = await _context
                .Reviews
                .Include(e => e.Game)
                .Include(e => e.User)
                .ProjectTo<ReviewsList>(_mapper.ConfigurationProvider)
                .ToPagedResultAsync(request);

            return pagedResult;
        }

        public async Task<ReviewDetails> GetByIdAsync(int userId, int gameId)
        {
            return await _context
                .Reviews
                .Where(e => e.UserId == userId && e.GameId == gameId)
                .Include(e => e.Game)
                .Include(e => e.User)
                .ProjectTo<ReviewDetails>(_mapper.ConfigurationProvider)
                .FirstAsync();
        }

        public async Task<int> DeleteByIdAsync(int userId, int gameId)
        {
            var review = await _context
                .Reviews
                .FindAsync(userId, gameId);

            _context.Reviews.Remove(review);

            return await _context.SaveChangesAsync();
        }

        public async Task<int> AddAsync(Review review)
        {
            await _context.Reviews.AddAsync(review);

            return await _context.SaveChangesAsync();
        }

        public async Task<int> EditAsync(int userId, int gameId, Review review)
        {
            _context.Entry(review).State = EntityState.Modified;

            return await _context.SaveChangesAsync();
        }

        public async Task<bool> DoesExist(int userId, int gameId)
        {
            return await _context.Reviews.AnyAsync(e => e.UserId == userId && e.GameId == gameId);
        }
    }
}
