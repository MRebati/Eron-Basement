using Eron.Core.Entities.User;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Eron.DataAccess.Contract.UnitOfWorks
{
    public interface IManagementUnitOfWork : IUnitOfWork
    {
        /// <summary>
        /// This Repository will return CRUD Actions related to ApplcationUsers.
        /// </summary>
        IdentityDbContext<ApplicationUser> AppContext { get; }
    }
}
