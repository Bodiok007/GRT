using GRT.DAL.Repositories.Interfaces.Operations;

namespace GRT.DAL.Repositories.Interfaces.UserProject
{
    public interface IPermissionRepository<TEntity>
        : IGetRepositoryOparation<TEntity>,
          IGetByIdRepositoryOperation<TEntity> where TEntity : class
    {
    }
}
