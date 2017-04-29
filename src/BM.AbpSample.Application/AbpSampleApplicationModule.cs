﻿using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;

namespace BM.AbpSample
{
    [DependsOn(typeof(AbpSampleCoreModule), typeof(AbpAutoMapperModule))]
    public class AbpSampleApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Modules.AbpAutoMapper().Configurators.Add(mapper =>
            {
                //Add your custom AutoMapper mappings here...
                //mapper.CreateMap<,>()
            });
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
