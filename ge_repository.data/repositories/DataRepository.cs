using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ge_repository.core.models;
using ge_repository.core.repositories;

namespace ge_repository.data.repositories
{
    public class DataRepository : Repository<ge_data>, IDataRepository
    {
        public DataRepository(ge_DbContext context) 
            : base(context)
        { }
        public async Task<IEnumerable<ge_data>> GetAllDataAsync()
        {
            return await ge_DbContext.ge_data
                   .ToListAsync();
        }
        public async Task<IEnumerable<ge_data>> GetAllWithProjectAsync()
        {
            return await ge_DbContext.ge_data
                .Include(a => a.project)
                .ToListAsync();
        }
       
        public async Task<ge_data> GetWithProjectAsync(Guid id)
        {
            return await ge_DbContext.ge_data
                .Include(a => a.project)
                .SingleOrDefaultAsync(a => a.Id == id);
        }
        public async Task<IEnumerable<ge_data>>  GetAllByProjectIdAsync(Guid Id) 
        {
            return await ge_DbContext.ge_data
                .Where(a => a.projectId == Id)
                .ToListAsync();

        }
        public async Task<IEnumerable<ge_data>>  GetAllByGroupIdAsync(Guid Id) 
        {
            return await ge_DbContext.ge_data
                .Where(a => a.project.groupId == Id)
                .ToListAsync();

        }

        private ge_DbContext ge_DbContext
        {
            get { return Context as ge_DbContext; }
        }
    }
}