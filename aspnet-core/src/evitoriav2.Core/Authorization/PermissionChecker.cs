using Abp.Authorization;
using evitoriav2.Authorization.Roles;
using evitoriav2.Authorization.Users;

namespace evitoriav2.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
