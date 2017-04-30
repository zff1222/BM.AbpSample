namespace BM.AbpSample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class 修改abp表前缀 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.AbpAuditLogs", newName: "SystemAuditLogs");
            RenameTable(name: "dbo.AbpBackgroundJobs", newName: "SystemBackgroundJobs");
            RenameTable(name: "dbo.AbpFeatures", newName: "SystemFeatures");
            RenameTable(name: "dbo.AbpEditions", newName: "SystemEditions");
            RenameTable(name: "dbo.AbpLanguages", newName: "SystemLanguages");
            RenameTable(name: "dbo.AbpLanguageTexts", newName: "SystemLanguageTexts");
            RenameTable(name: "dbo.AbpNotifications", newName: "SystemNotifications");
            RenameTable(name: "dbo.AbpNotificationSubscriptions", newName: "SystemNotificationSubscriptions");
            RenameTable(name: "dbo.AbpOrganizationUnits", newName: "SystemOrganizationUnits");
            RenameTable(name: "dbo.AbpPermissions", newName: "SystemPermissions");
            RenameTable(name: "dbo.AbpRoles", newName: "SystemRoles");
            RenameTable(name: "dbo.AbpUsers", newName: "SystemUsers");
            RenameTable(name: "dbo.AbpUserClaims", newName: "SystemUserClaims");
            RenameTable(name: "dbo.AbpUserLogins", newName: "SystemUserLogins");
            RenameTable(name: "dbo.AbpUserRoles", newName: "SystemUserRoles");
            RenameTable(name: "dbo.AbpSettings", newName: "SystemSettings");
            RenameTable(name: "dbo.AbpTenantNotifications", newName: "SystemTenantNotifications");
            RenameTable(name: "dbo.AbpTenants", newName: "SystemTenants");
            RenameTable(name: "dbo.AbpUserAccounts", newName: "SystemUserAccounts");
            RenameTable(name: "dbo.AbpUserLoginAttempts", newName: "SystemUserLoginAttempts");
            RenameTable(name: "dbo.AbpUserNotifications", newName: "SystemUserNotifications");
            RenameTable(name: "dbo.AbpUserOrganizationUnits", newName: "SystemUserOrganizationUnits");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.SystemUserOrganizationUnits", newName: "AbpUserOrganizationUnits");
            RenameTable(name: "dbo.SystemUserNotifications", newName: "AbpUserNotifications");
            RenameTable(name: "dbo.SystemUserLoginAttempts", newName: "AbpUserLoginAttempts");
            RenameTable(name: "dbo.SystemUserAccounts", newName: "AbpUserAccounts");
            RenameTable(name: "dbo.SystemTenants", newName: "AbpTenants");
            RenameTable(name: "dbo.SystemTenantNotifications", newName: "AbpTenantNotifications");
            RenameTable(name: "dbo.SystemSettings", newName: "AbpSettings");
            RenameTable(name: "dbo.SystemUserRoles", newName: "AbpUserRoles");
            RenameTable(name: "dbo.SystemUserLogins", newName: "AbpUserLogins");
            RenameTable(name: "dbo.SystemUserClaims", newName: "AbpUserClaims");
            RenameTable(name: "dbo.SystemUsers", newName: "AbpUsers");
            RenameTable(name: "dbo.SystemRoles", newName: "AbpRoles");
            RenameTable(name: "dbo.SystemPermissions", newName: "AbpPermissions");
            RenameTable(name: "dbo.SystemOrganizationUnits", newName: "AbpOrganizationUnits");
            RenameTable(name: "dbo.SystemNotificationSubscriptions", newName: "AbpNotificationSubscriptions");
            RenameTable(name: "dbo.SystemNotifications", newName: "AbpNotifications");
            RenameTable(name: "dbo.SystemLanguageTexts", newName: "AbpLanguageTexts");
            RenameTable(name: "dbo.SystemLanguages", newName: "AbpLanguages");
            RenameTable(name: "dbo.SystemEditions", newName: "AbpEditions");
            RenameTable(name: "dbo.SystemFeatures", newName: "AbpFeatures");
            RenameTable(name: "dbo.SystemBackgroundJobs", newName: "AbpBackgroundJobs");
            RenameTable(name: "dbo.SystemAuditLogs", newName: "AbpAuditLogs");
        }
    }
}
