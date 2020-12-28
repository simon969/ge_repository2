using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ge_repository.core.models;
using ge_repository.core.repositories;

namespace ge_repository.data.repositories

{
    public class UserOpsRepository : Repository<ge_user_ops>, IUserOpsRepository
    {
        public UserOpsRepository(ge_DbContext context) 
            : base(context)
        { }
        
        public async Task<IEnumerable<ge_user_ops>> GetAllUserOpsAsync()
        {
            return await ge_DbContext.ge_user_ops
                   .ToListAsync();
        }
        
        public async Task<IEnumerable<ge_user_ops>> GetAllWithProjectAsync()
        {
            return await ge_DbContext.ge_user_ops
                .Include(a => a.project)
                .ToListAsync();
        }
        
        public async Task<IEnumerable<ge_user_ops>> GetAllWithGroupAsync()
        {
            return await ge_DbContext.ge_user_ops
                .Include(a => a.group)
                .ToListAsync();
        }

        public async Task<IEnumerable<ge_user_ops>> GetAllByUserIdAsync(string Id)
        {
            return await ge_DbContext.ge_user_ops
                 .Where (a => a.userId == Id)
                 .ToListAsync();   
        }

        public async Task<ge_user_ops> GetWithProjectById(Guid id)
        {
            return await ge_DbContext.ge_user_ops
                .Include(a => a.project)
                .SingleOrDefaultAsync(a => a.Id == id);
        }
         public async Task<ge_user_ops> GetWithGroupById(Guid id)
        {
            return await ge_DbContext.ge_user_ops
                .Include(a => a.group)
                .SingleOrDefaultAsync(a => a.Id == id);
        }
        public async Task<IEnumerable<ge_user_ops>> GetAllByProjectIdAsync(Guid Id) 
        {
            return await ge_DbContext.ge_user_ops
                .Where(a => a.projectId == Id)
                .ToListAsync();

        }
        public async Task<IEnumerable<ge_user_ops>> GetAllByGroupIdAsync(Guid Id) 
        {
            return await ge_DbContext.ge_user_ops
                .Where(a => a.project.groupId == Id)
                .ToListAsync();

        }

        private ge_DbContext ge_DbContext
        {
            get { return Context as ge_DbContext; }
        }
    }
}