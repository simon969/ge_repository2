using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ge_repository.core.models;
using ge_repository.core.repositories;

namespace ge_repository.data.repositories

{
    public class TransformRepository : Repository<ge_transform>, ITransformRepository
    {
        public TransformRepository(ge_DbContext context) 
            : base(context)
        { }
        public async Task<IEnumerable<ge_transform>> GetAllTransformAsync()
        {
            return await ge_DbContext.ge_transform
                   .ToListAsync();
        }
        public async Task<IEnumerable<ge_transform>> GetAllWithProjectAsync()
        {
            return await ge_DbContext.ge_transform
                .Include(a => a.project)
                .ToListAsync();
        }
       
        public async Task<ge_transform> GetWithProjectAsync(Guid id)
        {
            return await ge_DbContext.ge_transform
                .Include(a => a.project)
                .SingleOrDefaultAsync(a => a.Id == id);
        }
        public async Task<IEnumerable<ge_transform>>  GetAllByProjectIdAsync(Guid Id) 
        {
            return await ge_DbContext.ge_transform
                .Where(a => a.projectId == Id)
                .ToListAsync();

        }
        public async Task<IEnumerable<ge_transform>>  GetAllByGroupIdAsync(Guid Id) 
        {
            return await ge_DbContext.ge_transform
                .Where(a => a.project.groupId == Id)
                .ToListAsync();

        }

        private ge_DbContext ge_DbContext
        {
            get { return Context as ge_DbContext; }
        }
    }
}