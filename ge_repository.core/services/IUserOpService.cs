using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ge_repository.core.models;

namespace ge_repository.core.services
{
    public interface IUserOpService
    {
        Task<IEnumerable<ge_user_ops>> GetAllWithProject();
        Task<ge_user_ops> GetByProjectId(Guid id);
        Task<IEnumerable<ge_user_ops>> GetByGroupId(Guid Id);
        Task<ge_user_ops> CreateUserOps(ge_user_ops user_ops);
        Task UpdateUserOps(ge_user_ops source, ge_user_ops destination);
        Task DeleteUserOps(ge_user_ops user_ops);
    }
}