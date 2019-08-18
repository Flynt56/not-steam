using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using NotSteam.Core.Requests;
using NotSteam.Core.Services.Contracts;
using NotSteam.Core.ViewModels.Purchases;
using NotSteam.Infrastructure.DB;
using NotSteam.Model.Models;
using NotSteam.Shared.Extensions;
using NotSteam.Shared.Pagination;

namespace NotSteam.Core.Services
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
                .ProjectTo<PurchasesList>(_mapper.ConfigurationProvider)
                .ToPagedResultAsync(request);

            return pagedResult;
        }

        public async Task<PurchaseDetails> GetByIdAsync(int id)
        {
            return await _context
                .Purchases
                .Where(c => c.Id == id)
                .ProjectTo<PurchaseDetails>(_mapper.ConfigurationProvider)
                .FirstAsync();
        }

        public async Task<int> DeleteByIdAsync(int id)
        {
            var user = await _context
                .Purchases
                .FindAsync(id);

            _context.Purchases.Remove(user);

            return await _context.SaveChangesAsync();
        }

        public async Task<int> AddAsync(Purchase user)
        {
            await _context.Purchases.AddAsync(user);

            return await _context.SaveChangesAsync();
        }

        public async Task<int> EditAsync(int id, Purchase user)
        {
            _context.Entry(user).State = EntityState.Modified;

            return await _context.SaveChangesAsync();
        }

        public async Task<bool> DoesExist(int id)
        {
            return await _context.Purchases.AnyAsync(e => e.Id == id);
        }
    }
}
