using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ge_repository.core.models;

namespace ge_repository.core.services
{
    public interface IDataService
    {
        Task<IEnumerable<ge_data>> GetAllWithProject();
        Task<ge_data> GetDataById(Guid Id);
        Task<IEnumerable<ge_data>> GetDataByProjectId(Guid Id);
        Task<ge_data> CreateData(ge_data newData);
        Task UpdateData(ge_data dataToBeUpdated, ge_data data);
        Task DeleteData(ge_data data);
    }
}