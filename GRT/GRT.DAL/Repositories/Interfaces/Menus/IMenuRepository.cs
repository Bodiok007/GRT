using GRT.DAL.Repositories.Interfaces.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GRT.DAL.Repositories.Interfaces.Menus
{
    interface IMenuRepository<TEntity, TKey>
        : IGetRepositoryOparation<TEntity>,
          IGetByIdRepositoryOperation<TEntity, TKey>,
          IUpdateRepositoryOparation<TEntity>,
          IAddRepositoryOparation<TEntity>, 
          IDeleteRepositoryOperation<TEntity> where TEntity : class
    {
    }
}
