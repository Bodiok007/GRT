using GRT.DAL.Repositories.Interfaces.Operations;

namespace GRT.DAL.Repositories.Interfaces.Menus
{
    public interface IMenuTranslateRepository<TEntity>
        : IGetRepositoryOparation<TEntity>,
          IGetByIdComplexKeyRepositoryOperation<TEntity>,
          IUpdateRepositoryOparation<TEntity>,
          IAddRepositoryOparation<TEntity>,
          IDeleteRepositoryOperation<TEntity> where TEntity : class
    {
    }
}
