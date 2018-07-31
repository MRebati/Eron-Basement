using Eron.Business.Core.Core.ApplicationUserManagement.Dto;
using Eron.DataAccess.Contract.UnitOfWorks;
using Nelibur.ObjectMapper;

namespace Eron.Business.Core.Core.ApplicationUserManagement
{
    public class ApplicationUserManagement : IApplicationUserManagement
    {
        private IManagementUnitOfWork unitOfWork;

        public ApplicationUserManagement(IManagementUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public ApplicationUserDto GetUserById(string userId)
        {
            var user = unitOfWork.AppContext.Users.Find(userId);
            return TinyMapper.Map<ApplicationUserDto>(user);
        }
    }
}
