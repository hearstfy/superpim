using SuperPIM.Domain.DTOs.Requests;
using SuperPIM.Domain.DTOs.Responses;

namespace SuperPIM.Application.Common.Interfaces.Services
{
    public interface ITenantService
    {
        public Task<AddTenantResponseDTO> AddTenant(AddTenantRequestDTO tenantDTO);
        public Task<AddTenantResponseDTO> GetTenant(int id);
        public Task<List<AddTenantResponseDTO>> GetTenants();
    }
}
