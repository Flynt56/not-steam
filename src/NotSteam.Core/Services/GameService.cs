using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using NotSteam.Core.Requests;
using NotSteam.Core.Services.Contracts;
using NotSteam.Core.ViewModels.Games;
using NotSteam.Infrastructure.DB;
using NotSteam.Model.Models;
using NotSteam.Shared.Extensions;
using NotSteam.Shared.Pagination;

namespace NotSteam.Core.Services
{
    public class GameService : BaseService, IGameService
    {
        private readonly NotSteamContext _context;
        private readonly IMapper _mapper;

        public GameService(NotSteamContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<PagedResult<GamesList>> GetPageAsync(GamePaginationRequest request)
        {
            var pagedResult = await _context
                .Games
                .Include(c => c.GameTags)
                .ProjectTo<GamesList>(_mapper.ConfigurationProvider)
                .ToPagedResultAsync(request);

            return pagedResult;
        }

        public async Task<GameDetails> GetByIdAsync(int id)
        {
            return await _context
                .Games
                .Where(c => c.Id == id)
                .ProjectTo<GameDetails>(_mapper.ConfigurationProvider)
                .FirstAsync();
        }

        public async Task<int> DeleteByIdAsync(int id)
        {
            var user = await _context
                .Games
                .FindAsync(id);

            _context.Games.Remove(user);

            return await _context.SaveChangesAsync();
        }

        public async Task<int> AddAsync(Game user)
        {
            await _context.Games.AddAsync(user);

            return await _context.SaveChangesAsync();
        }

        public async Task<int> EditAsync(int id, Game user)
        {
            _context.Entry(user).State = EntityState.Modified;

            return await _context.SaveChangesAsync();
        }

        public async Task<bool> DoesExist(int id)
        {
            return await _context.Games.AnyAsync(e => e.Id == id);
        }

        public async Task<IEnumerable<GamesDropdown>> GetDropdown()
        {
            return await _context
                .Games
                .ProjectTo<GamesDropdown>(_mapper.ConfigurationProvider)
                .ToListAsync();
        }
    }
}
