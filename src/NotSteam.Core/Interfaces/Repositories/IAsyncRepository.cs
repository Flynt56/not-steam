﻿using System.Collections.Generic;
using System.Threading.Tasks;
using NotSteam.Core.Interfaces.Specifications;
using NotSteam.Model.Interfaces;
using NotSteam.Model.Models;

namespace NotSteam.Core.Interfaces.Repositories
{
    public interface IAsyncRepository<T> where T : EntityBase, IAggregateRoot
    {
        Task<T> GetByIdAsync(int id);

        Task<IReadOnlyList<T>> ListAllAsync();
        Task<IReadOnlyList<T>> ListAsync(ISpecification<T> spec);

        Task<T> AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);

        Task<int> CountAsync(ISpecification<T> spec);
    }
}
