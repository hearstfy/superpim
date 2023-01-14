using Microsoft.EntityFrameworkCore;
using SuperPIM.Domain.Common.Interfaces.Persistance;
using SuperPIM.Domain.Entities;
using SuperPIM.Infrastructure.Persistance.DbContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperPIM.Infrastructure.Persistance.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<User> AddUser(User user)
        {
            var newUser = _context.Users.Add(user).Entity;
            await _context.SaveChangesAsync();
            return newUser;
        }

        public async Task<User> GetUser(int id)
        {
            return await _context.Users.FindAsync(id);
        }

        public async Task<List<User>> GetUsers(int tenantId)
        {
            return await _context.Users.Where(user => user.TenantId == tenantId).ToListAsync();
        }
    }
}
