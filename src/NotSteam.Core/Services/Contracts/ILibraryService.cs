using System.Threading.Tasks;
using NotSteam.Core.Requests;
using NotSteam.Core.ViewModels.Libraries;
using NotSteam.Model.Models;
using NotSteam.Shared.Pagination;

namespace NotSteam.Core.Services.Contracts
{
    public interface ILibraryService
    {
        Task<PagedResult<LibrariesList>> GetPageAsync(LibraryPaginationRequest request);
        Task<LibraryDetails> GetByIdAsync(int id);

        Task<int> DeleteByIdAsync(int id);

        Task<int> AddAsync(Library user);
        Task<int> EditAsync(int id, Library user);

        Task<bool> DoesExist(int id);
    }
}
