using SuperPIM.Domain.DTOs.Requests;
using SuperPIM.Domain.DTOs.Responses;
using SuperPIM.Domain.Entities;

namespace SuperPIM.Domain.Mappers
{
    public static class UserMapper
    {
        public static User ToEntity(this AddUserRequestDTO userDto, int tenantId)
        {
            return new User()
            {
                Name = userDto.name,
                Surname = userDto.surname,
                Email = userDto.email,
                TenantId = tenantId
            };
        }

        public static AddUserResponseDTO FromEntity(this User user)
        {
            return new AddUserResponseDTO()
            {
                id = user.Id,
                name = user.Name,
                surname = user.Surname,
                email = user.Email,
            };
        }

        public static List<AddUserResponseDTO> FromEntities(this List<User> users)
        {
            var dtos = new List<AddUserResponseDTO>();

            foreach (var user in users)
            {
                dtos.Add(user.FromEntity());
            }

            return dtos;
        }
    }
}
