﻿using GRT.DAL.Repositories.Interfaces.Operations;

namespace GRT.DAL.Repositories.Interfaces
{
    public interface IUserRepository<TEntity>
        : IGetRepositoryOparation<TEntity>,
          IGetByIdRepositoryOperation<TEntity>,
          IUpdateRepositoryOparation<TEntity>,
          IAddRepositoryOparation<TEntity> where TEntity : class
    {
    }
}
