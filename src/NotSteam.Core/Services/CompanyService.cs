using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using NotSteam.Core.Requests;
using NotSteam.Core.Services.Contracts;
using NotSteam.Core.ViewModels.Companies;
using NotSteam.Infrastructure.DB;
using NotSteam.Model.Models;
using NotSteam.Shared.Extensions;
using NotSteam.Shared.Pagination;

namespace NotSteam.Core.Services
{
    public class CompanyService : BaseService, ICompanyService
    {
        private readonly NotSteamContext _context;
        private readonly IMapper _mapper;

        public CompanyService(NotSteamContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<PagedResult<CompaniesList>> GetPageAsync(CompanyPaginationRequest request)
        {
            var pagedResult = await _context
                .Companies
                .ProjectTo<CompaniesList>(_mapper.ConfigurationProvider)
                .ToPagedResultAsync(request);

            return pagedResult;
        }

        public async Task<CompanyDetails> GetByIdAsync(int id)
        {
            return await _context
                .Companies
                .Where(c => c.Id == id)
                .ProjectTo<CompanyDetails>(_mapper.ConfigurationProvider)
                .FirstAsync();
        }

        public async Task<int> DeleteByIdAsync(int id)
        {
            var company = await _context
                .Companies
                .FindAsync(id);

            _context.Companies.Remove(company);

            return await _context.SaveChangesAsync();
        }

        public async Task<int> AddAsync(Company company)
        {
            await _context.Companies.AddAsync(company);

            return await _context.SaveChangesAsync();
        }

        public async Task<int> EditAsync(int id, Company company)
        {
            _context.Entry(company).State = EntityState.Modified;

            return await _context.SaveChangesAsync();
        }

        public async Task<bool> DoesExist(int id)
        {
            return await _context.Companies.AnyAsync(e => e.Id == id);
        }

        public async Task<IEnumerable<CompaniesDropdown>> GetDropdown()
        {
            return await _context
                .Companies
                .ProjectTo<CompaniesDropdown>(_mapper.ConfigurationProvider)
                .ToListAsync();
        }
    }
}
