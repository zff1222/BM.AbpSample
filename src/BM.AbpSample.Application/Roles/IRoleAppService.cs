using System.Threading.Tasks;
using Abp.Application.Services;
using BM.AbpSample.Roles.Dto;

namespace BM.AbpSample.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
