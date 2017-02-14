using System;
namespace GRT.DAL.Repositories.Interfaces.Operations
{
    interface IGetByIdComplexKeyRepositoryOperation<TEntity> where TEntity : class
    {
        TEntity GetById(params object[] keys);
    }
}
