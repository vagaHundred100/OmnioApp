using BLL.DTO;
using BLL.Services.Abstract;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnionApp.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace OnionApp.Controllers
{
    //no magic string test

    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Authorize(Policy = POLICY.ONLY_FOR_ACTIVE)]
    [Route("api/[controller]")]
    [ApiController]
    public class ChatController : ControllerBase
    {
        private readonly IChatService _chatService;

        public ChatController(IChatService chatService)
        {
            _chatService = chatService;
        }

        [HttpPost("WriteMessage")]
        public async Task<IActionResult> WriteAsync(MessageWriteDTO writeMessageDTO)
        {
            if (ModelState.IsValid)
            {
                var senderID = HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
                writeMessageDTO.SenderId = senderID;
                var response = await _chatService.WriteMessageAsync(writeMessageDTO);
                return StatusCode(response.StatusCode, response);
            }

            return BadRequest();
        }

        [HttpPost("ReadAllRecivedMessages")]
        public async Task<IActionResult> ReadAllRecivedMessagesAsync()
        {
            if (ModelState.IsValid)
            {
                var reciverID = HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
                var response = await _chatService.ReadAllRecivedMessagesAsync(reciverID);
                return StatusCode(response.StatusCode, response);
            }

            return BadRequest();
        }

        [HttpPost("ReadAllSentMessages")]
        public async Task<IActionResult> ReadAllSentMessagesAsync()
        {
            if (ModelState.IsValid)
            {
                var senderID = HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
                var response = await _chatService.ReadAllSentMessagesAsync(senderID);
                return StatusCode(response.StatusCode, response);
            }

            return BadRequest();
        }

        [HttpPost("DeleteMessageFromUser")]
        public async Task<IActionResult> DeleteMessageFromUser(string messageId)
        {
            if (ModelState.IsValid)
            {
                var userID = HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
                var response = await _chatService.DeleteMesageFromUserAsync(messageId, userID);
                return StatusCode(response.StatusCode, response);
            }

            return BadRequest();
        }

        [HttpPost("DeleteMessageFromChat")]
        public async Task<IActionResult> DeleteMessageFromChat(string messageId)
        {
            if (ModelState.IsValid)
            {
                var userID = HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
                var response = await _chatService.DeleteMessageFromChatAsync(messageId, userID);
                return StatusCode(response.StatusCode, response);
            }

            return BadRequest();
        }

        [HttpPost("UpdateMessage")]
        public async Task<IActionResult> UpdateMessage(string messageID)
        {
            if (ModelState.IsValid)
            {
                var response = await _chatService.UpdateMessage(messageID);
                return StatusCode(response.StatusCode, response);
            }

            return BadRequest();
        }

    }
}
