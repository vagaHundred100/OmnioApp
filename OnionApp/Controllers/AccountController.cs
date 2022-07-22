using BLL.DTO;
using BLL.Services.Abstract;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionApp.Controllers
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [ApiController]
    [Route("[controller]")]
    public class AccountController : ControllerBase
    {
        private IAccauntService _accauntService;
        public AccountController(IAccauntService accauntService)
        {
            _accauntService = accauntService;
        }

        [AllowAnonymous]
        [HttpPost("Login")]
        public async Task<IActionResult> LoginAsync(LoginDTO model)
        {
            if (ModelState.IsValid)
            {

                var response = await _accauntService.LoginAsync(model);
                return StatusCode(response.StatusCode, response);
            }

            return BadRequest(model);

        }

        [AllowAnonymous]
        [HttpPost("Register")]
        public async Task<IActionResult> RegisterAsync(RegisterDTO model)
        {
            if (ModelState.IsValid)
            {
                var response = await _accauntService.RegisterAsync(model);
                return StatusCode(response.StatusCode, response);

            }

            return BadRequest(model);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost("ChaingePassword")]
        public async Task<IActionResult> ChaingePasswordAsync(ChangePasswordDTO model)
        {
            if (ModelState.IsValid)
            {
                var response = await _accauntService.ChangePasswordAsync(model);
                return StatusCode(response.StatusCode, response);
            }

            return BadRequest();
        }

        [HttpPost("ResetPassword")]
        public async Task<IActionResult> ResetPasswordAsync(RisetPasswordDTO model)
        {
            if (ModelState.IsValid)
            {
                var response = await _accauntService.ResetPasswordAsync(model);
                return StatusCode(response.StatusCode, response);
            }

            return BadRequest();
        }

        [Authorize(Roles = "Admin")]
        [HttpPut("Update")]
        public async Task<IActionResult> UpdateAsync(UpdateDTO model)
        {
            if (ModelState.IsValid)
            {
                var response = await _accauntService.UpdateUserAsync(model);
                return StatusCode(response.StatusCode, response);
            }

            return BadRequest(model);
        }

        [Authorize(Roles = "Admin")]
        [HttpDelete("Delete")]
        public async Task<IActionResult> DeleteAsync(string userName)
        {
            if (ModelState.IsValid)
            {
                var response = await _accauntService.DeleteUserAsync(userName);
                return StatusCode(response.StatusCode, response);
            }

            return BadRequest();
        }

        [Authorize(Roles = "Admin")]
        [HttpPost("Activate")]
        public async Task<IActionResult> ActivateUserAsync(string userName)
        {
            if (ModelState.IsValid)
            {
                var response = await _accauntService.ActivateUserAsync(userName);
                return StatusCode(response.StatusCode, response);
            }

            return BadRequest();
        }

        [Authorize(Roles = "Admin")]
        [HttpPost("Deactivate")]
        public async Task<IActionResult> DeactivateAync(string userName)
        {
            if (ModelState.IsValid)
            {
                var response = await _accauntService.DeactivateUserAsync(userName);
                return StatusCode(response.StatusCode, response);
            }

            return BadRequest();
        }

        [Authorize(Roles = "Admin")]
        [HttpPost("AddRoleToUser")]
        public async Task<IActionResult> AddRoleToUserAsync(string userName, string role)
        {
            if (ModelState.IsValid)
            {
                var response = await _accauntService.AddUserToRoleAsync(userName, role);
                return StatusCode(response.StatusCode, response);
            }

            return BadRequest();
        }

        [Authorize(Roles = "Admin")]
        [HttpPost("RemoveRoleFromUser")]
        public async Task<IActionResult> RemoveRoleFromUserAsync(string userName, string role)
        {
            if (ModelState.IsValid)
            {
                var response = await _accauntService.RemoveUserFromRoleAsync(userName, role);
                return StatusCode(response.StatusCode, response);
            }

            return BadRequest();
        }

        [Authorize(Roles ="Admin")]
        [HttpPost("GetAllUsers")]
        public IActionResult GetAllUsersAsync()
        {
            var response = _accauntService.GetAllUsersAsync();
            return Ok(response);
        }

    }
}
