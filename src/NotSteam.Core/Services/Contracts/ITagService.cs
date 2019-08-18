using System.Threading.Tasks;
using NotSteam.Core.Requests;
using NotSteam.Core.ViewModels.Tags;
using NotSteam.Model.Models;
using NotSteam.Shared.Pagination;

namespace NotSteam.Core.Services.Contracts
{
    public interface ITagService
    {
        Task<PagedResult<TagsList>> GetPageAsync(TagPaginationRequest request);
        Task<TagDetails> GetByIdAsync(int id);

        Task<int> DeleteByIdAsync(int id);

        Task<int> AddAsync(Tag user);
        Task<int> EditAsync(int id, Tag user);

        Task<bool> DoesExist(int id);
    }
}
