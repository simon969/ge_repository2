using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ge_repository.core.models;

namespace ge_repository.core.services
{
    public interface IUserService
    {
        Task<IEnumerable<ge_user>> GetAll();
        Task<ge_user> GetById(string Id);
        Task<ge_user> CreateUser(ge_user newUser);
        Task UpdateUser(ge_user source, ge_user destination);
        Task DeleteUser(ge_user user);
    }
}