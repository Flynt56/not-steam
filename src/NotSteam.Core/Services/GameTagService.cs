using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using NotSteam.Core.Requests;
using NotSteam.Core.Services.Contracts;
using NotSteam.Core.ViewModels.GameTags;
using NotSteam.Infrastructure.DB;
using NotSteam.Model.Models;
using NotSteam.Shared.Extensions;
using NotSteam.Shared.Pagination;

namespace NotSteam.Core.Services
{
    public class GameTagService : BaseService, IGameTagService
    {
        private readonly NotSteamContext _context;
        private readonly IMapper _mapper;

        public GameTagService(NotSteamContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<PagedResult<GameTagsList>> GetPageAsync(GameTagPaginationRequest request)
        {
            var pagedResult = await _context
                .GameTags
                .ProjectTo<GameTagsList>(_mapper.ConfigurationProvider)
                .ToPagedResultAsync(request);

            return pagedResult;
        }

        public async Task<GameTagDetails> GetByIdAsync(int id)
        {
            return await _context
                .GameTags
                .Where(c => c.Id == id)
                .ProjectTo<GameTagDetails>(_mapper.ConfigurationProvider)
                .FirstAsync();
        }

        public async Task<int> DeleteByIdAsync(int id)
        {
            var user = await _context
                .GameTags
                .FindAsync(id);

            _context.GameTags.Remove(user);

            return await _context.SaveChangesAsync();
        }

        public async Task<int> AddAsync(GameTag user)
        {
            await _context.GameTags.AddAsync(user);

            return await _context.SaveChangesAsync();
        }

        public async Task<int> EditAsync(int id, GameTag user)
        {
            _context.Entry(user).State = EntityState.Modified;

            return await _context.SaveChangesAsync();
        }

        public async Task<bool> DoesExist(int id)
        {
            return await _context.GameTags.AnyAsync(e => e.Id == id);
        }
    }
}
