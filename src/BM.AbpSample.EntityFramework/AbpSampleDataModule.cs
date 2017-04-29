using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using BM.AbpSample.EntityFramework;

namespace BM.AbpSample
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(AbpSampleCoreModule))]
    public class AbpSampleDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<AbpSampleDbContext>());

            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
