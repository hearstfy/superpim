using Microsoft.EntityFrameworkCore;
using SuperPIM.Domain.Common.Interfaces.Persistance;
using SuperPIM.Domain.Entities;
using SuperPIM.Infrastructure.Persistance.DbContexts;

namespace SuperPIM.Infrastructure.Persistance.Repositories
{
    public class TenantRepository : ITenantRepository
    {
        private readonly ApplicationDbContext _context;

        public TenantRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Tenant> AddTenant(Tenant tenant)
        {
            var newTenant = _context.Tenants.Add(tenant).Entity;
            await _context.SaveChangesAsync();
            return newTenant;
        }

        public async Task<Tenant> GetTenant(int id)
        {
            return await _context.Tenants.FindAsync(id);
        }

        public async Task<List<Tenant>> GetTenants()
        {
            return await _context.Tenants.ToListAsync();
        }
    }
}
