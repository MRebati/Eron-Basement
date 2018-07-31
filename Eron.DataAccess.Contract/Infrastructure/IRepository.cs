using System;
using System.Linq.Expressions;

namespace Eron.DataAccess.Contract.Infrastructure
{
    public interface IRepository<TEntity> : IReadOnlyRepository<TEntity>
    {
        TEntity Create(TEntity entity);
        void Update(TEntity entity);
        void Update(TEntity entity, params Expression<Func<TEntity, object>>[] properties);
        void Delete(object id);
        void Delete(TEntity entity);
    }
}
