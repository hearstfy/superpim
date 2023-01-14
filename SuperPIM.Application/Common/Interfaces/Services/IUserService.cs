using SuperPIM.Domain.DTOs.Requests;
using SuperPIM.Domain.DTOs.Responses;

namespace SuperPIM.Application.Common.Interfaces.Services
{
    public interface IUserService
    {
        public Task<AddUserResponseDTO> AddUser(int tenantId, AddUserRequestDTO userDTO);
        public Task<AddUserResponseDTO> GetUser(int userId);
        public Task<List<AddUserResponseDTO>> GetUsers(int tenantId);
    }
}
