using AutoMapper;
using GRT.Logger.Interfaces;

namespace GRT.BLL.Managers
{
    public abstract class BaseManager<TEntity> where TEntity : class
    {
        public BaseManager(ILogger logger,
                           IMapper mapper)
        {
            _logger = logger;
            _mapper = mapper;
        }

        /*public IEnumerable<TEntity> Get(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null)
        {

        }*/

        #region Fields

        protected readonly ILogger _logger;
        protected readonly IMapper _mapper;

        #endregion
    }
}
