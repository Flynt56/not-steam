using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using NotSteam.Core.Requests;
using NotSteam.Core.Services.Contracts;
using NotSteam.Core.ViewModels;
using NotSteam.Infrastructure.DB;
using NotSteam.Model.Models;
using NotSteam.Shared.Extensions;
using NotSteam.Shared.Pagination;

namespace NotSteam.Core.Services
{
    public class UserService : BaseService, IUserService
    {
        private readonly NotSteamContext _context;
        private readonly IMapper _mapper;

        public UserService(NotSteamContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<PagedResult<UsersList>> GetPageAsync(UserPaginationRequest request)
        {
            var pagedResult = await _context
                .Users
                .ProjectTo<UsersList>(_mapper.ConfigurationProvider)
                .ToPagedResultAsync(request);

            return pagedResult;
        }

        public async Task<UserDetails> GetByIdAsync(int id)
        {
            return await _context
                .Users
                .Where(c => c.Id == id)
                .ProjectTo<UserDetails>(_mapper.ConfigurationProvider)
                .FirstAsync();
        }

        public async Task<int> DeleteByIdAsync(int id)
        {
            var user = await _context
                .Users
                .FindAsync(id);

            _context.Users.Remove(user);

            return await _context.SaveChangesAsync();
        }

        public async Task<int> AddAsync(User user)
        {
            await _context.Users.AddAsync(user);

            return await _context.SaveChangesAsync();
        }

        public async Task<int> EditAsync(int id, User user)
        {
            _context.Entry(user).State = EntityState.Modified;

            return await _context.SaveChangesAsync();
        }

        public async Task<bool> DoesExist(int id)
        {
            return await _context.Users.AnyAsync(e => e.Id == id);
        }
    }
}
