using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperPIM.Application.Common.Interfaces.Services;
using SuperPIM.Domain.DTOs.Requests;

namespace SuperPIM.API.Controllers
{
    [Route("api/tenant/{tenantId}/users")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("{userId}")]
        public async Task<IActionResult> GetUser([FromRoute] int userId)
        {
            var user = await _userService.GetUser(userId);
            return Ok(user);
        }

        [HttpGet]
        public async Task<IActionResult> GetUsers([FromRoute] int tenantId)
        {
            var user = await _userService.GetUsers(tenantId);
            return Ok(user);
        }

        [HttpPost]
        public async Task<IActionResult> AddUser([FromRoute] int tenantId, [FromBody] AddUserRequestDTO userDTO)
        {
            var user = await _userService.AddUser(tenantId, userDTO);
            return Ok(user);
        }
    }
}
