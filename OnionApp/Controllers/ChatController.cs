using BLL.DTO;
using BLL.Services.Abstract;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace OnionApp.Controllers
{

    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Authorize(Policy = "OnlyForActive")]
    [Route("api/[controller]")]
    [ApiController]
    public class ChatController : ControllerBase
    {
        private readonly IChatService _chatService;

        public ChatController(IChatService chatService)
        {
            _chatService = chatService;
        }

        [HttpPost("write")]
        public async Task<IActionResult> WriteAsync(MessageWriteDTO writeMessageDTO)
        {
            if (ModelState.IsValid)
            {
                var senderID =  HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
                writeMessageDTO.SenderId = senderID;
                var response  = await _chatService.WriteAsync(writeMessageDTO);
                return StatusCode(response.StatusCode, response);
            }
            
            return BadRequest();
        }

        [HttpPost("read")]
        public async Task<IActionResult> ReadAsync()
        {
            if (ModelState.IsValid)
            {
                var reciverID = HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
                var response =  await _chatService.ReadAsync(reciverID);
                return StatusCode(response.StatusCode, response);
            }

            return BadRequest();
        }

    }
}
