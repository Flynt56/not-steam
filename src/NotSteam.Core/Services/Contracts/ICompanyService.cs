using System.Threading.Tasks;
using NotSteam.Core.Requests;
using NotSteam.Core.ViewModels.Companies;
using NotSteam.Model.Models;
using NotSteam.Shared.Pagination;

namespace NotSteam.Core.Services.Contracts
{
    public interface ICompanyService
    {
        Task<PagedResult<CompaniesList>> GetPageAsync(UserPaginationRequest request);
        Task<CompanyDetails> GetByIdAsync(int id);

        Task<int> DeleteByIdAsync(int id);

        Task<int> AddAsync(Company user);
        Task<int> EditAsync(int id, Company user);

        Task<bool> DoesExist(int id);
    }
}
