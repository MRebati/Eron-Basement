﻿using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq.Expressions;
using Eron.Core.Infrastructure;
using Eron.DataAccess.Contract.Infrastructure;

namespace Eron.DataAccess.EntityFramework.Infrastructure
{
    public class Repository<TEntity> : ReadOnlyRepository<TEntity>, IRepository<TEntity>
    where TEntity : class , IEntity
    {
        public Repository(DbContext context)
            : base(context)
        {

        }

        public virtual TEntity Create(TEntity entity)
        {
            return context.Set<TEntity>().Add(entity);
        }

        public virtual void Update(TEntity entity)
        {
            context.Set<TEntity>().Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
        }


        public virtual void Update(TEntity entity, params Expression<Func<TEntity, object>>[] properties)
        {
            context.Set<TEntity>().Attach(entity);
            DbEntityEntry<TEntity> entry = context.Entry(entity);
            foreach (var selector in properties)
            {
                entry.Property(selector).IsModified = true;
            }
        }

        public virtual void Delete(object id)
        {
            TEntity entity = context.Set<TEntity>().Find(id);
            Delete(entity);
        }

        public virtual void Delete(TEntity entity)
        {
            var dbSet = context.Set<TEntity>();
            if (context.Entry(entity).State == EntityState.Detached)
            {
                dbSet.Attach(entity);
            }
            dbSet.Remove(entity);
        }
    }
}
