using System.Collections.Generic;
using System.Threading.Tasks;
using ge_repository.core.models;

namespace ge_repository.core.services
{
    public interface IGroupService
    {
        Task<IEnumerable<ge_group>> GetAllGroups();
        Task<ge_group> GetGroupById(int id);
        Task<ge_group> CreateGroup(ge_project newGroup);
        Task UpdateGroup(ge_group groupToBeUpdated, ge_group group);
        Task DeleteGroup(ge_group group);
    }
}