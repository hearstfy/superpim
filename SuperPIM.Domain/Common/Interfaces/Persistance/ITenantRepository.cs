using SuperPIM.Domain.Entities;

namespace SuperPIM.Domain.Common.Interfaces.Persistance
{
    public interface ITenantRepository
    {
        public Task<Tenant> AddTenant(Tenant tenant);
        public Task<Tenant> GetTenant(int id);
        public Task<List<Tenant>> GetTenants();
    }
}
