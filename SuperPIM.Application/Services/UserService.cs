using SuperPIM.Application.Common.Interfaces.Services;
using SuperPIM.Domain.Common.Interfaces.Persistance;
using SuperPIM.Domain.DTOs.Requests;
using SuperPIM.Domain.DTOs.Responses;
using SuperPIM.Domain.Mappers;

namespace SuperPIM.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<AddUserResponseDTO> AddUser(int tenantId, AddUserRequestDTO userDTO)
        {
            var user = (await _userRepository.AddUser(userDTO.ToEntity(tenantId))).FromEntity();
            return user;
        }

        public async Task<AddUserResponseDTO> GetUser(int userId)
        {
            return (await _userRepository.GetUser(userId)).FromEntity();
        }

        public async Task<List<AddUserResponseDTO>> GetUsers(int tenantId)
        {
            return (await _userRepository.GetUsers(tenantId)).FromEntities();
        }
    }
}
