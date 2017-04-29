using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using BM.AbpSample.MultiTenancy.Dto;

namespace BM.AbpSample.MultiTenancy
{
    public interface ITenantAppService : IApplicationService
    {
        ListResultDto<TenantListDto> GetTenants();

        Task CreateTenant(CreateTenantInput input);
    }
}
