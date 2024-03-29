﻿using System.Data.Common;
using System.Data.Entity;
using Abp.Zero.EntityFramework;
using BM.AbpSample.Authorization.Roles;
using BM.AbpSample.MultiTenancy;
using BM.AbpSample.Users;

namespace BM.AbpSample.EntityFramework
{
    public class AbpSampleDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public AbpSampleDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in AbpSampleDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of AbpSampleDbContext since ABP automatically handles it.
         */
        public AbpSampleDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public AbpSampleDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public AbpSampleDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //修改abp的默认表前缀
            modelBuilder.ChangeAbpTablePrefix<Tenant, Role, User>("System", null);
            base.OnModelCreating(modelBuilder);
        }
    }
}
