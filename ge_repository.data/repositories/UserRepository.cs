using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ge_repository.core.models;
using ge_repository.core.repositories;

namespace ge_repository.data.repositories
{
    public class UserRepository : Repository<ge_user>, IUserRepository
    {
        public UserRepository(ge_DbContext context) 
            : base(context)
        { }
         public async Task<IEnumerable<ge_user>> GetAllUserAsync()
        {
            return await ge_DbContext.ge_user
                   .ToListAsync();
        }
        public async Task<ge_user> GetById(string id)
        {
            return await ge_DbContext.ge_user
                .SingleOrDefaultAsync(a => a.Id == id);
        }
       
        private ge_DbContext ge_DbContext
        {
            get { return Context as ge_DbContext; }
        }
    }
}