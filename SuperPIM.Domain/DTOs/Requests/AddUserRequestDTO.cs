using System.ComponentModel.DataAnnotations;

namespace SuperPIM.Domain.DTOs.Requests
{
    public class AddUserRequestDTO
    {
        [Required]
        public string name { get; set; }
        [Required]
        public string surname { get; set; }
        [Required]
        public string email { get; set; }
    }
}
