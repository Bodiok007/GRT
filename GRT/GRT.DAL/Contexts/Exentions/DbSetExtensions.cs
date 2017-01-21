using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GRT.DAL.Contexts.Exentions
{
    public static class DbSetExtensions
    {
        public static IEnumerable<T> Local<T>(this DbSet<T> set)
          where T : class
        {

            var infrastructure = (IInfrastructure<IServiceProvider>)set;

            var context = (DbContext)infrastructure.Instance.GetService(typeof(DbContext));

            return context.ChangeTracker.Entries<T>()
              .Where(e => 
                  e.State == EntityState.Added || 
                  e.State == EntityState.Unchanged || 
                  e.State == EntityState.Modified)
              .Select(e => e.Entity);
        }
    }
}
