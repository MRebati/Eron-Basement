using System;
using Eron.Core.Entities.User;
using Eron.DataAccess.Contract.Repositories;
using Eron.DataAccess.Contract.UnitOfWorks;
using Eron.DataAccess.EntityFramework.Infrastructure;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Eron.DataAccess.EntityFramework.UnitOfWorks
{
    public class ManagementUnitOfWork : UnitOfWork, IManagementUnitOfWork
    {
        private bool _disposed;
        private IdentityDbContext<ApplicationUser> _appContext;
        private ITenantRepository _tenantRepository;

        public ManagementUnitOfWork()
            : base(new ApplicationDbContext())
        {
            
        }

        public ITenantRepository TenantRepository
        {
            get
            {

                return _tenantRepository;
            }
        }

        public IdentityDbContext<ApplicationUser> AppContext
        {
            get
            {
                if(_appContext == null)
                    _appContext = new IdentityDbContext<ApplicationUser>();
                return _appContext;
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    Context.Dispose();
                }
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
