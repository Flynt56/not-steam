using System.Collections.Generic;
using System.Threading.Tasks;
using NotSteam.Core.Requests;
using NotSteam.Core.ViewModels.Companies;
using NotSteam.Model.Models;
using NotSteam.Shared.Pagination;

namespace NotSteam.Core.Interfaces.Services
{
    public interface ICompanyService
    {
        Task<PagedResult<CompaniesList>> GetPageAsync(CompanyPaginationRequest request);
        Task<CompanyDetails> GetByIdAsync(int id);

        Task<IEnumerable<CompaniesDropdown>> GetDropdown();

        Task<int> DeleteByIdAsync(int id);

        Task<int> AddAsync(Company company);
        Task<int> EditAsync(int id, Company company);

        Task<bool> DoesExist(int id);
    }
}
