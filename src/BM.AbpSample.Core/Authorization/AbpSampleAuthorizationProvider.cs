using Abp.Authorization;
using Abp.Localization;
using Abp.MultiTenancy;

namespace BM.AbpSample.Authorization
{
    public class AbpSampleAuthorizationProvider : AuthorizationProvider
    {
        public override void SetPermissions(IPermissionDefinitionContext context)
        {
            //Common permissions
            var pages = context.GetPermissionOrNull(PermissionNames.Pages);
            if (pages == null)
            {
                pages = context.CreatePermission(PermissionNames.Pages, L("Pages"));
            }

            #region 系统管理
            //系统管理
            var pages_Sys = pages.CreateChildPermission(PermissionNames.Pages_Sys, L("系统管理"));

            //用户管理
            var pages_Sys_Users = pages_Sys.CreateChildPermission(PermissionNames.Pages_Sys_Users, L("用户管理"));
            pages_Sys_Users.CreateChildPermission(PermissionNames.Pages_Sys_Users_Create, L("新增"));
            pages_Sys_Users.CreateChildPermission(PermissionNames.Pages_Sys_Users_Edit, L("修改"));
            pages_Sys_Users.CreateChildPermission(PermissionNames.Pages_Sys_Users_Delete, L("删除"));
            pages_Sys_Users.CreateChildPermission(PermissionNames.Pages_Sys_Users_权限设置, L("权限设置"));
            pages_Sys_Users.CreateChildPermission(PermissionNames.Pages_Sys_Users_角色设置, L("角色设置"));

            //用户管理
            var pages_Sys_Roles = pages_Sys.CreateChildPermission(PermissionNames.Pages_Sys_Roles, L("用户管理"));
            pages_Sys_Roles.CreateChildPermission(PermissionNames.Pages_Sys_Roles_Create, L("新增"));
            pages_Sys_Roles.CreateChildPermission(PermissionNames.Pages_Sys_Roles_Edit, L("修改"));
            pages_Sys_Roles.CreateChildPermission(PermissionNames.Pages_Sys_Roles_Delete, L("删除"));
            pages_Sys_Roles.CreateChildPermission(PermissionNames.Pages_Sys_Roles_权限设置, L("权限设置"));

            //租户管理
            var tenants = pages_Sys.CreateChildPermission(PermissionNames.Pages_Sys_Tenats, L("Tenants"), multiTenancySides: MultiTenancySides.Host);

            #endregion //end of 系统管理
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, AbpSampleConsts.LocalizationSourceName);
        }
    }
}
