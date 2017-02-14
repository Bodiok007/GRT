using System;

namespace GRT.DAL.Repositories.Interfaces.Operations
{
    public interface IGetByIdRepositoryOperation<TEntity, TKey> where TEntity : class
    {
        TEntity GetById(TKey id);
    }
}
