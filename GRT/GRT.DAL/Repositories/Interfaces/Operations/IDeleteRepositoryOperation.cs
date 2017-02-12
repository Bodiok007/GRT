namespace GRT.DAL.Repositories.Interfaces.Operations
{
    public interface IDeleteRepositoryOparation<TEntity> where TEntity : class
    {
        void Delete(TEntity item);
    }
}
