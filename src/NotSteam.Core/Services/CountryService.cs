using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using NotSteam.Api.Requests;
using NotSteam.Api.Responses;
using NotSteam.Infrastructure.DB;
using NotSteam.Shared.Pagination;
using NotSteam.Api.Services.Contracts;

namespace NotSteam.Api.Services
{
    public class CountryService : BaseService, ICountryService
    {
        private readonly NotSteamContext _context;

        public CountryService(
            NotSteamContext context
        )
        {
            _context = context;
        }

        public async Task<PagedResult<CountryResponse>> GetPageAsync(CountryPaginationRequest request)
        {
            PagedResult<CountryResponse> pagedResult = await _context
                .Countries.AsQueryable()
                .Select(i => new CountryResponse
                {
                    Id = i.Id,
                    Name = i.Name,
                    CityCount = i.Cities.Count
                })
                .ToPagedResultAsync(request);

            return pagedResult;
        }

        public async Task<CountryResponse> GetByIdAsync(long id)
        {
            return await _context
                .Countries
                .Include(c => c.Cities)
                .Where(c => c.Id == id)
                .Select(i => new CountryResponse
                {
                    Id = i.Id,
                    Name = i.Name,
                    Cities = i.Cities
                })
                .FirstAsync();
        }

        public async Task<int> DeleteByIdAsync(long id)
        {
            var country = await _context
                .Countries
                .FindAsync(id);

            _context.Countries.Remove(country);
            return await _context.SaveChangesAsync();
        }

    }
}
