using GRT.DAL.Repositories.Interfaces.Operations;

namespace GRT.DAL.Repositories.Interfaces.Menus
{
    public interface IMenuAttributeValueRepository<TEntity, TKey>
        : IGetRepositoryOparation<TEntity>,
          IGetByIdRepositoryOperation<TEntity, TKey>,
          IUpdateRepositoryOparation<TEntity>,
          IAddRepositoryOparation<TEntity>,
          IDeleteRepositoryOperation<TEntity> where TEntity : class
    {
    }
}
