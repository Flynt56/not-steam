using System.Threading.Tasks;
using NotSteam.Model.Models;
using NotSteam.Shared.Pagination;

namespace NotSteam.Core.Interfaces.Services
{
    public interface IService<TEntity> where TEntity : EntityBase
    {
        Task<PagedResult<TEntity>> GetPageAsync(AbstractPagingRequest<TEntity> request);
        Task<TEntity> GetByIdAsync(int id);

        Task<int> DeleteByIdAsync(int id);

        Task<int> AddAsync(TEntity entity);
        Task<int> EditAsync(int id, TEntity entity);

        Task<bool> DoesExist(int id);
    }
}
