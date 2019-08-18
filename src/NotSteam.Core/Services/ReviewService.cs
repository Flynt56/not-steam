using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using NotSteam.Core.Requests;
using NotSteam.Core.Services.Contracts;
using NotSteam.Core.ViewModels.Reviews;
using NotSteam.Infrastructure.DB;
using NotSteam.Model.Models;
using NotSteam.Shared.Extensions;
using NotSteam.Shared.Pagination;

namespace NotSteam.Core.Services
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
                .ProjectTo<ReviewsList>(_mapper.ConfigurationProvider)
                .ToPagedResultAsync(request);

            return pagedResult;
        }

        public async Task<ReviewDetails> GetByIdAsync(int id)
        {
            return await _context
                .Reviews
                .Where(c => c.Id == id)
                .ProjectTo<ReviewDetails>(_mapper.ConfigurationProvider)
                .FirstAsync();
        }

        public async Task<int> DeleteByIdAsync(int id)
        {
            var user = await _context
                .Reviews
                .FindAsync(id);

            _context.Reviews.Remove(user);

            return await _context.SaveChangesAsync();
        }

        public async Task<int> AddAsync(Review user)
        {
            await _context.Reviews.AddAsync(user);

            return await _context.SaveChangesAsync();
        }

        public async Task<int> EditAsync(int id, Review user)
        {
            _context.Entry(user).State = EntityState.Modified;

            return await _context.SaveChangesAsync();
        }

        public async Task<bool> DoesExist(int id)
        {
            return await _context.Reviews.AnyAsync(e => e.Id == id);
        }
    }
}
