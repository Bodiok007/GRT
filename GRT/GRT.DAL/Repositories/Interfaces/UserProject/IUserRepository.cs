using GRT.DAL.Repositories.Interfaces.Operations;

namespace GRT.DAL.Repositories.Interfaces.UserProject
{
    public interface IUserRepository<TEntity, TKey>
        : IGetRepositoryOparation<TEntity>,
          IGetByIdRepositoryOperation<TEntity, TKey>,
          IUpdateRepositoryOparation<TEntity>,
          IAddRepositoryOparation<TEntity> where TEntity : class
    {
    }
}
