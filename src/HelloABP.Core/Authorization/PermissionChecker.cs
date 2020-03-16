using Abp.Authorization;
using HelloABP.Authorization.Roles;
using HelloABP.Authorization.Users;

namespace HelloABP.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
