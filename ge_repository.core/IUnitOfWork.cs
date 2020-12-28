using System;
using System.Threading.Tasks;
using ge_repository.core.repositories;

namespace ge_repository.core
{
    public interface IUnitOfWork : IDisposable
    {
        IDataRepository Data {get;}
        IProjectRepository Project { get; }
        IGroupRepository Group { get; }
        ITransformRepository Transform {get;}
        IUserRepository User {get;}
        IUserOpsRepository UserOps {get;}


        Task<int> CommitAsync();
    }
}