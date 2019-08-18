using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using NotSteam.Core.Requests;
using NotSteam.Core.Services.Contracts;
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
                .ProjectTo<LibrariesList>(_mapper.ConfigurationProvider)
                .ToPagedResultAsync(request);

            return pagedResult;
        }

        public async Task<LibraryDetails> GetByIdAsync(int id)
        {
            return await _context
                .Libraries
                .Where(c => c.Id == id)
                .ProjectTo<LibraryDetails>(_mapper.ConfigurationProvider)
                .FirstAsync();
        }

        public async Task<int> DeleteByIdAsync(int id)
        {
            var user = await _context
                .Libraries
                .FindAsync(id);

            _context.Libraries.Remove(user);

            return await _context.SaveChangesAsync();
        }

        public async Task<int> AddAsync(Library user)
        {
            await _context.Libraries.AddAsync(user);

            return await _context.SaveChangesAsync();
        }

        public async Task<int> EditAsync(int id, Library user)
        {
            _context.Entry(user).State = EntityState.Modified;

            return await _context.SaveChangesAsync();
        }

        public async Task<bool> DoesExist(int id)
        {
            return await _context.Libraries.AnyAsync(e => e.Id == id);
        }
    }
}
