using System.Threading.Tasks;
using ge_repository.core;
using ge_repository.core.repositories;
using ge_repository.data.repositories;

namespace ge_repository.data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ge_DbContext _context;
        private DataRepository _dataRepository;
        private ProjectRepository _projectRepository;
        private GroupRepository _groupRepository;
        private TransformRepository _transformRepository;
        private UserOpsRepository _useropsRepository;
        private UserRepository _userRepository;

        public UnitOfWork(ge_DbContext context)
        {
            this._context = context;
        }

        public IDataRepository Data => _dataRepository = _dataRepository ?? new DataRepository(_context);

        public IProjectRepository Project => _projectRepository = _projectRepository ?? new ProjectRepository(_context);
        
        public IGroupRepository Group => _groupRepository = _groupRepository ?? new GroupRepository(_context);
        public ITransformRepository Transform => _transformRepository = _transformRepository ?? new TransformRepository(_context);
        public IUserOpsRepository UserOps => _useropsRepository = _useropsRepository ?? new UserOpsRepository(_context);
        public IUserRepository User => _userRepository = _userRepository ?? new UserRepository(_context);
        
        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}