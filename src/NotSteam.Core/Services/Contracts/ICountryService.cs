using System.Threading.Tasks;
using NotSteam.Api.Requests;
using NotSteam.Api.Responses;
using NotSteam.Shared.Pagination;

namespace NotSteam.Api.Services.Contracts
{
    public interface ICountryService
    {
        Task<PagedResult<CountryResponse>> GetPageAsync(CountryPaginationRequest request);
        Task<CountryResponse> GetByIdAsync(long id);

        Task<int> DeleteByIdAsync(long id);
    }
}
