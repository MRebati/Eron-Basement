using Eron.Business.Core.Core.ApplicationUserManagement.Dto;

namespace Eron.Business.Core.Core.ApplicationUserManagement
{
    public interface IApplicationUserManagement
    {
        ApplicationUserDto GetUserById(string userId);
    }
}