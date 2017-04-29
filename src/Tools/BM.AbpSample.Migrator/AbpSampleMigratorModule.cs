using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using BM.AbpSample.EntityFramework;

namespace BM.AbpSample.Migrator
{
    [DependsOn(typeof(AbpSampleDataModule))]
    public class AbpSampleMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<AbpSampleDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}