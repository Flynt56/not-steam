using System.Threading.Tasks;
using NotSteam.Core.Requests;
using NotSteam.Core.ViewModels.Libraries;
using NotSteam.Model.Models;
using NotSteam.Shared.Pagination;

namespace NotSteam.Core.Interfaces.Services
{
    public interface ILibraryService
    {
        Task<PagedResult<LibrariesList>> GetPageAsync(LibraryPaginationRequest request);
        Task<LibraryDetails> GetByIdAsync(int userId, int gameId);

        Task<int> DeleteByIdAsync(int userId, int gameId);

        Task<int> AddAsync(Library library);
        Task<int> EditAsync(int userId, int gameId, Library library);

        Task<bool> DoesExist(int userId, int gameId);
    }
}
