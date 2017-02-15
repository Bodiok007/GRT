namespace GRT.DAL.Repositories.Interfaces.Operations
{
    public interface IDeleteRepositoryOperation<TEntity> where TEntity : class
    {
        void Delete(TEntity item);
    }
}
