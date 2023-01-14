using Microsoft.EntityFrameworkCore;
using SuperPIM.Domain.Entities;

namespace SuperPIM.Infrastructure.Persistance.DbContexts
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Tenant> Tenants { get; set; }
        public DbSet<User> Users { get; set; }

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
