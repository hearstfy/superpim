using SuperPIM.Domain.Entities;

namespace SuperPIM.Domain.Common.Interfaces.Persistance
{
    public interface IUserRepository
    {
        public Task<User> AddUser(User user);
        public Task<User> GetUser(int id);
        public Task<List<User>> GetUsers(int tenantId);
    }
}
