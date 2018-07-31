using System;
using System.Data.Entity;
using Eron.DataAccess.Contract.UnitOfWorks;
using Eron.DataAccess.EntityFramework.Infrastructure;

namespace Eron.DataAccess.EntityFramework.UnitOfWorks
{
    public class DefaultUnitOfWork : UnitOfWork, IDefaultUnitOfWork
    {
        public DefaultUnitOfWork()
            : base(new ApplicationDbContext())
        {
        }

        private bool _disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    Context.Dispose();
                }
            }
            this._disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }


        public DefaultUnitOfWork(DbContext context) : base(context)
        {
        }
    }
}
