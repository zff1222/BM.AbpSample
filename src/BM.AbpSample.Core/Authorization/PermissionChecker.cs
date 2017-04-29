using Abp.Authorization;
using BM.AbpSample.Authorization.Roles;
using BM.AbpSample.MultiTenancy;
using BM.AbpSample.Users;

namespace BM.AbpSample.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
