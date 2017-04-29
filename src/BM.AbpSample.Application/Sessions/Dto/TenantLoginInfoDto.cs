using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using BM.AbpSample.MultiTenancy;

namespace BM.AbpSample.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}