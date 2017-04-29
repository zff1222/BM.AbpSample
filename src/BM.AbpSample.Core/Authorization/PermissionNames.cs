namespace BM.AbpSample.Authorization
{
    public static class PermissionNames
    {
        #region 通用权限
        /// <summary>
        /// 权限root
        /// </summary>
        public const string Pages = "Pages";

        #region 系统管理
        /// <summary>
        /// 系统管理
        /// </summary>
        public const string Pages_Sys = "Pages.Sys";

        #region 租户管理
        /// <summary>
        /// 系统管理.租户管理
        /// </summary>
        public const string Pages_Sys_Tenats = Pages_Sys + ".Tenants";
        #endregion 

        #region 用户管理
        /// <summary>
        /// 系统管理.用户管理
        /// </summary>
        public const string Pages_Sys_Users = Pages_Sys + ".Users";
        public const string Pages_Sys_Users_Create = Pages_Sys_Users + ".Create";
        public const string Pages_Sys_Users_Edit = Pages_Sys_Users + ".Edit";
        public const string Pages_Sys_Users_Delete = Pages_Sys_Users + ".Delete";
        public const string Pages_Sys_Users_权限设置 = Pages_Sys_Users + ".权限设置";
        public const string Pages_Sys_Users_角色设置 = Pages_Sys_Users + ".角色设置";
        #endregion 

        #region 角色管理
        /// <summary>
        /// 系统管理.角色管理
        /// </summary>
        public const string Pages_Sys_Roles = Pages_Sys + ".Roles";
        public const string Pages_Sys_Roles_Create = Pages_Sys_Roles + ".Create";
        public const string Pages_Sys_Roles_Edit = Pages_Sys_Roles + ".Edit";
        public const string Pages_Sys_Roles_Delete = Pages_Sys_Roles + ".Delete";
        public const string Pages_Sys_Roles_权限设置 = Pages_Sys_Roles + ".权限设置";
        #endregion 

        #endregion //end of 系统管理

        #endregion //end of 权限
    }
}