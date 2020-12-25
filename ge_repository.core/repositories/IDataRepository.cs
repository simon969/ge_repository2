using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ge_repository.core.models;

namespace ge_repository.core.repositories
{
    public interface IDataRepository : IRepository<ge_data>
    {
        Task<IEnumerable<ge_data>> GetAllDataAsync();
        Task<IEnumerable<ge_data>> GetAllWithProjectAsync();
        Task<ge_data> GetWithProjectAsync(Guid id);
        Task<IEnumerable<ge_data>> GetAllByProjectIdAsync(Guid Id);
        Task<IEnumerable<ge_data>> GetAllByGroupIdAsync(Guid Id);
    }
}