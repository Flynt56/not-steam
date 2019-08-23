using System.Threading.Tasks;
using NotSteam.Core.Requests;
using NotSteam.Model.Models;
using NotSteam.Shared.Pagination;

namespace NotSteam.Core.Interfaces.Services
{
    public interface ICompanyService
    {
        Task<PagedResult<Company>> GetPageAsync(CompanyPaginationRequest request);
        Task<Company> GetByIdAsync(int id);

        Task<int> DeleteByIdAsync(int id);

        Task<int> AddAsync(Company company);
        Task<int> EditAsync(int id, Company company);

        Task<bool> DoesExist(int id);
    }
}
