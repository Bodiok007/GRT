using GRT.DAL.Repositories.Interfaces.Operations;

namespace GRT.DAL.Repositories.Interfaces.UserProject
{
    interface IProjectRepository<TEntity, TKey>
        : IGetRepositoryOparation<TEntity>,
          IGetByIdRepositoryOperation<TEntity, TKey>,
          IUpdateRepositoryOparation<TEntity>,
          IDeleteRepositoryOparation<TEntity>,
          IAddRepositoryOparation<TEntity> where TEntity : class
    {
    }
}
