namespace SuperPIM.Domain.Entities
{
    public class Tenant : BaseEntity
    {
        public string Name { get; set; } = null!;
        public string DomainName { get; set; } = null!;
        public bool IsActive { get; set; }

        public List<User> Users { get; set; }
    }
}
