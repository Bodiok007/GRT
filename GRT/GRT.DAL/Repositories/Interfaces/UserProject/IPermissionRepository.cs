using GRT.DAL.Repositories.Interfaces.Operations;

namespace GRT.DAL.Repositories.Interfaces.UserProject
{
    public interface IPermissionRepository<TEntity, TKey>
        : IGetRepositoryOparation<TEntity>,
          IGetByIdRepositoryOperation<TEntity, TKey> where TEntity : class
    {
    }
}
