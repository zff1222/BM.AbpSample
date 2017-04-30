using System.Reflection;
using System.Web.Http;
using Abp.Application.Services;
using Abp.Configuration.Startup;
using Abp.Modules;
using Abp.WebApi;

namespace BM.AbpSample.Api
{
    [DependsOn(typeof(AbpWebApiModule), typeof(AbpSampleApplicationModule))]
    public class AbpSampleWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            Configuration.Modules.AbpWebApi().DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(AbpSampleApplicationModule).Assembly, "app")
                .Build();

            Configuration.Modules.AbpWebApi().HttpConfiguration.Filters.Add(new HostAuthenticationFilter("Bearer"));


            //发送错误信息到前台
            //Configuration.Modules.AbpWebCommon().SendAllExceptionsToClients = true;

        }
    }
}
