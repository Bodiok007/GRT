using GRT.DAL.Repositories.Interfaces.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GRT.DAL.Repositories.Interfaces.Menus
{
    interface IMenuTranslateRepository<TEntity>
        : IGetRepositoryOparation<TEntity>,
          IGetByIdComplexKeyRepositoryOperation<TEntity>,
          IUpdateRepositoryOparation<TEntity>,
          IAddRepositoryOparation<TEntity>,
          IDeleteRepositoryOperation<TEntity> where TEntity : class
    {
    }
}
