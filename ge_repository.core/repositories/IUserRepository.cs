using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ge_repository.core.models;

namespace ge_repository.core.repositories
{
    public interface IUserRepository : IRepository<ge_user>
    {
        Task<IEnumerable<ge_user>> GetAllUserAsync();
        Task<ge_user> GetById(string Id);
    }
}