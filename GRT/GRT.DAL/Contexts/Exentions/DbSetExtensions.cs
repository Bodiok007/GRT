using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Entity.Infrastructure;

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
