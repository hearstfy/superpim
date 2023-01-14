using System.ComponentModel.DataAnnotations;

namespace SuperPIM.Domain.DTOs.Responses
{
    public class AddUserResponseDTO
    {
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string email { get; set; }
    }
}
