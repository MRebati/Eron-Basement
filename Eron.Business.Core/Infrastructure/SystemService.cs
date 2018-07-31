using Eron.Core.AppEnums;
using Eron.DataAccess.Contract.UnitOfWorks;

namespace Eron.Business.Core.Infrastructure
{
    public class SystemService : ISystemService
    {
        protected IManagementUnitOfWork UnitOfWork;
        protected TenantType TenantType;

        public SystemService(IManagementUnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
        }
    }
}