using System.Linq;
using BM.AbpSample.EntityFramework;
using BM.AbpSample.MultiTenancy;

namespace BM.AbpSample.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly AbpSampleDbContext _context;

        public DefaultTenantCreator(AbpSampleDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
