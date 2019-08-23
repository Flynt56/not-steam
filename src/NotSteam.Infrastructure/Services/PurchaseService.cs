using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using NotSteam.Core.Interfaces.Services;
using NotSteam.Core.Requests;
using NotSteam.Core.ViewModels.Purchases;
using NotSteam.Infrastructure.DB;
using NotSteam.Model.Models;
using NotSteam.Shared.Extensions;
using NotSteam.Shared.Pagination;

namespace NotSteam.Infrastructure.Services
{
    public class PurchaseService : BaseService, IPurchaseService
    {
        private readonly NotSteamContext _context;
        private readonly IMapper _mapper;

        public PurchaseService(NotSteamContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<PagedResult<PurchasesList>> GetPageAsync(PurchasePaginationRequest request)
        {
            var pagedResult = await _context
                .Purchases
                .Include(c => c.Game)
                .Include(c => c.User)
                .ProjectTo<PurchasesList>(_mapper.ConfigurationProvider)
                .ToPagedResultAsync(request);

            return pagedResult;
        }

        public async Task<PurchaseDetails> GetByIdAsync(int userId, int gameId)
        {
            return await _context
                .Purchases
                .Where(c => c.UserId == userId && c.GameId == gameId)
                .Include(c => c.Game)
                .Include(c => c.User)
                .ProjectTo<PurchaseDetails>(_mapper.ConfigurationProvider)
                .FirstAsync();
        }

        public async Task<int> DeleteByIdAsync(int userId, int gameId)
        {
            var purchase = await _context
                .Purchases
                .FindAsync(userId, gameId);

            _context.Purchases.Remove(purchase);

            return await _context.SaveChangesAsync();
        }

        public async Task<int> AddAsync(Purchase purchase)
        {
            await _context.Purchases.AddAsync(purchase);

            return await _context.SaveChangesAsync();
        }

        public async Task<int> EditAsync(int userId, int gameId, Purchase purchase)
        {
            _context.Entry(purchase).State = EntityState.Modified;

            return await _context.SaveChangesAsync();
        }

        public async Task<bool> DoesExist(int userId, int gameId)
        {
            return await _context.Purchases.AnyAsync(e => e.UserId == userId && e.GameId == gameId);
        }
    }
}
