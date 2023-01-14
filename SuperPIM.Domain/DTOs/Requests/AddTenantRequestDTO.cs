using System.ComponentModel.DataAnnotations;

namespace SuperPIM.Domain.DTOs.Requests
{
    public class AddTenantRequestDTO
    {
        [Required]
        public string name { get; set; }
        [Required]
        public string domainName { get; set; }
    }
}
