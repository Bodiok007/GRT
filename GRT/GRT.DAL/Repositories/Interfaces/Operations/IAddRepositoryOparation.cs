namespace GRT.DAL.Repositories.Interfaces.Operations
{
    public interface IAddRepositoryOparation<TEntity> where TEntity : class
    {
        void Add(TEntity item);
    }
}
