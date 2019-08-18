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
                .Include(e => e.Tag)
                .Include(e => e.Game)
                .ProjectTo<GameTagsList>(_mapper.ConfigurationProvider)
                .ToPagedResultAsync(request);

            return pagedResult;
        }

        public async Task<GameTagDetails> GetByIdAsync(int gameId, int tagId)
        {
            return await _context
                .GameTags
                .Where(e => e.GameId == gameId && e.TagId == tagId)
                .Include(e => e.Tag)
                .Include(e => e.Game)
                .ProjectTo<GameTagDetails>(_mapper.ConfigurationProvider)
                .FirstAsync();
        }

        public async Task<int> DeleteByIdAsync(int gameId, int tagId)
        {
            var gameTag = await _context
                .GameTags
                .FindAsync(gameId, tagId);

            _context.GameTags.Remove(gameTag);

            return await _context.SaveChangesAsync();
        }

        public async Task<int> AddAsync(GameTag gameTag)
        {
            await _context.GameTags.AddAsync(gameTag);

            return await _context.SaveChangesAsync();
        }

        public async Task<int> EditAsync(int gameId, int tagId, GameTag gameTag)
        {
            _context.Entry(gameTag).State = EntityState.Modified;

            return await _context.SaveChangesAsync();
        }

        public async Task<bool> DoesExist(int gameId, int tagId)
        {
            return await _context.GameTags.AnyAsync(e => e.GameId == gameId && e.TagId == tagId);
        }
    }
}
