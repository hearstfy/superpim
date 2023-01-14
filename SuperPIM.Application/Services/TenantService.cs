using SuperPIM.Application.Common.Interfaces.Services;
using SuperPIM.Domain.Common.Interfaces.Persistance;
using SuperPIM.Domain.DTOs.Requests;
using SuperPIM.Domain.DTOs.Responses;
using SuperPIM.Domain.Mappers;

namespace SuperPIM.Application.Services
{
    public class TenantService : ITenantService
    {
        private readonly ITenantRepository _tenantRepository;

        public TenantService(ITenantRepository tenantRepository)
        {
            _tenantRepository = tenantRepository;
        }

        public async Task<AddTenantResponseDTO> AddTenant(AddTenantRequestDTO tenantDTO)
        {
            var tenant = (await _tenantRepository.AddTenant(tenantDTO.ToEntity())).FromEntity();
            return tenant;
        }

        public async Task<AddTenantResponseDTO> GetTenant(int id)
        {
            //TODO: null check and throw
            return (await _tenantRepository.GetTenant(id)).FromEntity();
        }

        public async Task<List<AddTenantResponseDTO>> GetTenants()
        {
            return (await _tenantRepository.GetTenants()).FromEntities();
        }
    }
}
