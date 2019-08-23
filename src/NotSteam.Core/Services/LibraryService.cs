using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using NotSteam.Core.Interfaces.Services;
using NotSteam.Core.Requests;
using NotSteam.Core.ViewModels.Libraries;
using NotSteam.Infrastructure.DB;
using NotSteam.Model.Models;
using NotSteam.Shared.Extensions;
using NotSteam.Shared.Pagination;

namespace NotSteam.Core.Services
{
    public class LibraryService : BaseService, ILibraryService
    {
        private readonly NotSteamContext _context;
        private readonly IMapper _mapper;

        public LibraryService(NotSteamContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<PagedResult<LibrariesList>> GetPageAsync(LibraryPaginationRequest request)
        {
            var pagedResult = await _context
                .Libraries
                .Include(c => c.Game)
                .Include(c => c.User)
                .ProjectTo<LibrariesList>(_mapper.ConfigurationProvider)
                .ToPagedResultAsync(request);

            return pagedResult;
        }

        public async Task<LibraryDetails> GetByIdAsync(int userId, int gameId)
        {
            return await _context
                .Libraries
                .Where(c => c.UserId == userId && c.GameId == gameId)
                .Include(c => c.Game)
                .Include(c => c.User)
                .ProjectTo<LibraryDetails>(_mapper.ConfigurationProvider)
                .FirstAsync();
        }

        public async Task<int> DeleteByIdAsync(int userId, int gameId)
        {
            var library = await _context
                .Libraries
                .FindAsync(userId, gameId);

            _context.Libraries.Remove(library);

            return await _context.SaveChangesAsync();
        }

        public async Task<int> AddAsync(Library library)
        {
            await _context.Libraries.AddAsync(library);

            return await _context.SaveChangesAsync();
        }

        public async Task<int> EditAsync(int userId, int gameId, Library library)
        {
            _context.Entry(library).State = EntityState.Modified;

            return await _context.SaveChangesAsync();
        }

        public async Task<bool> DoesExist(int userId, int gameId)
        {
            return await _context.Libraries.AnyAsync(e => e.UserId == userId && e.GameId == gameId);
        }
    }
}
