using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ge_repository.core.models;
using ge_repository.core.repositories;

namespace ge_repository.data.repositories
{
    public class GroupRepository : Repository<ge_group>, IGroupRepository
    {
        public GroupRepository(ge_DbContext context) 
            : base(context)
        { }

        public async Task<IEnumerable<ge_group>> GetAllGroupAsync()
        {
            return await ge_DbContext.ge_group
                .ToListAsync();
        }
        public async Task<ge_group> GetWithGroupIdAsync(Guid Id) {

            return await ge_DbContext.ge_group
                 .SingleOrDefaultAsync(a => a.Id == Id);

        }
       
        private ge_DbContext ge_DbContext
        {
            get { return Context as ge_DbContext; }
        }
    }
}