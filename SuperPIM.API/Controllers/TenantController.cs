using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperPIM.Application.Common.Interfaces.Services;
using SuperPIM.Domain.DTOs.Requests;

namespace SuperPIM.API.Controllers
{
    [Route("api/tenants")]
    [ApiController]
    public class TenantController : ControllerBase
    {
        private readonly ITenantService _tenantService;

        public TenantController(ITenantService tenantService)
        {
            _tenantService = tenantService;
        }

        [HttpPost]
        public async Task<IActionResult> AddTenant([FromBody] AddTenantRequestDTO tenantDTO)
        {
            var tenant = await _tenantService.AddTenant(tenantDTO);
            return Ok(tenant);
        }

        [HttpGet("{tenantId}")]
        public async Task<IActionResult> GetTenant([FromRoute] int tenantId)
        {
            var tenant = await _tenantService.GetTenant(tenantId);
            return Ok(tenant);
        }

        [HttpGet]
        public async Task<IActionResult> GetTenants()
        {
            var tenants = await _tenantService.GetTenants();
            return Ok(tenants);
        }
    }
}
