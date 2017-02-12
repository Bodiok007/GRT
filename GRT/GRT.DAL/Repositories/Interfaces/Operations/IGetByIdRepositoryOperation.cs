using System;

namespace GRT.DAL.Repositories.Interfaces.Operations
{
    public interface IGetByIdRepositoryOperation<TEntity> where TEntity : class
    {
        TEntity GetById(Object id);
    }
}
