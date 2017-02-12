namespace GRT.DAL.Repositories.Interfaces.Operations
{
    public interface IUpdateRepositoryOparation<TEntity> where TEntity : class
    {
        void Update(TEntity item);
    }
}
