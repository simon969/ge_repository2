using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ge_repository.core.models;

namespace ge_repository.core.services
{
    public interface ITransformService
    {
        Task<IEnumerable<ge_transform>> GetAllWithProject();
        Task<ge_transform> GetByProjectId(Guid id);
        Task<IEnumerable<ge_transform>> GetByGroupId(Guid Id);
        Task<ge_transform> CreateTransform(ge_transform newTransform);
        Task UpdateTransform(ge_transform source, ge_transform destination);
        Task DeleteTransform(ge_transform transform);
    }
}