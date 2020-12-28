using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ge_repository.core.models;

namespace ge_repository.core.repositories
{
    public interface IUserOpsRepository : IRepository<ge_user_ops>
    {
        Task<IEnumerable<ge_user_ops>> GetAllUserOpsAsync();
        Task<IEnumerable<ge_user_ops>> GetAllWithProjectAsync();
        Task<IEnumerable<ge_user_ops>> GetAllWithGroupAsync();
        Task<ge_user_ops> GetWithProjectById(Guid Id);
        Task<ge_user_ops> GetWithGroupById(Guid Id);
        Task<IEnumerable<ge_user_ops>> GetAllByUserIdAsync(string Id);
        Task<IEnumerable<ge_user_ops>> GetAllByProjectIdAsync(Guid Id);
        Task<IEnumerable<ge_user_ops>> GetAllByGroupIdAsync(Guid Id);
    }
}