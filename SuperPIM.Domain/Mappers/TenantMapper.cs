using SuperPIM.Domain.DTOs.Requests;
using SuperPIM.Domain.DTOs.Responses;
using SuperPIM.Domain.Entities;

namespace SuperPIM.Domain.Mappers
{
    public static class TenantMapper
    {
        public static Tenant ToEntity(this AddTenantRequestDTO tenantDto)
        {
            return new Tenant()
            {
                Name = tenantDto.name,
                DomainName = tenantDto.domainName
            };
        }

        public static AddTenantResponseDTO FromEntity(this Tenant tenant)
        {
            return new AddTenantResponseDTO()
            {
                id = tenant.Id,
                name = tenant.Name,
                domainName = tenant.DomainName
            };
        }

        public static List<AddTenantResponseDTO> FromEntities(this List<Tenant> tenants)
        {
            var dtos = new List<AddTenantResponseDTO>();
            
            foreach(var tenant in tenants)
            {
                dtos.Add(tenant.FromEntity());
            }

            return dtos;
        }
    }
}
