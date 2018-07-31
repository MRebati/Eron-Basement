using Eron.Core.Entities.User;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Eron.DataAccess.EntityFramework
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        //your DbSets here...

    }
}
