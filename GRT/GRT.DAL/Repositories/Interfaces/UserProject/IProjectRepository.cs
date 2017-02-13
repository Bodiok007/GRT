using GRT.DAL.Repositories.Interfaces.Operations;

namespace GRT.DAL.Repositories.Interfaces.UserProject
{
    interface IProjectRepository<TEntity>
        : IGetRepositoryOparation<TEntity>,
          IGetByIdRepositoryOperation<TEntity>,
          IUpdateRepositoryOparation<TEntity>,
          IDeleteRepositoryOparation<TEntity>,
          IAddRepositoryOparation<TEntity> where TEntity : class
    {
    }
}
