using BLL.DTO;
using DAL.Helpers;
using BLL.Services.Abstract;
using DAL.Context;
using DAL.Domains;
using DAL.Repositories.Abstract;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AutoMapper;

namespace BLL.Services.Concrete
{
    public class ChatService : IChatService
    {
        private readonly OnionDbContext _context;
        private readonly IMessageRepository _messageRepository;
        private readonly UserManager<User> _userManeger;
        private readonly IMapper _mapper;
        public ChatService(IMessageRepository messageRepository,
                           UserManager<User> userManeger,
                           OnionDbContext context,
                           IMapper mapper)
        {
            _messageRepository = messageRepository;
            _userManeger = userManeger;
            _context = context;
            _mapper = mapper;
        }
        public ResponceWithData<List<MessageReadDTO>> Read(string reciverID)
        {
            Guid.TryParse(reciverID, out var reciverGuidID);
            var messages = _context.Users
                .Include(c => c.ReceivedMessages)
                .Where(c => c.Id == reciverGuidID)
                .Single()
                .ReceivedMessages?
                .Where(c => c.DeleteStatus == false);
                
            List<MessageReadDTO> messagesToRead = new List<MessageReadDTO>();
            foreach (var message in messages)
            {
                message.ReadStatus = true;
                var response = _messageRepository.Update(message);
                if (!response.Success)
                {
                    return ResponseCreator.CreateUnsuccessifullResponseWithData<List<MessageReadDTO>>(
                        response.ErrorMessages, response.StatusCode);
                }
                var readMessage = _mapper.Map<MessageReadDTO>(message);
                messagesToRead.Add(readMessage);
            }

            return new ResponceWithData<List<MessageReadDTO>>() { Data = messagesToRead };


        }

        public async Task<Responce> WriteAsync(MessageWriteDTO messageDTO)
        {
            var sender = await _userManeger.FindByIdAsync(messageDTO.SenderId);
            var reciver = await _userManeger.FindByIdAsync(messageDTO.ReciverId);

            if (sender == null)
            {
                var errorMessage = new[] { "user with senderID was not found" }.ToList();
                return ResponseCreator.CreateUnsuccessifullResponse(errorMessage,
                               (int)HttpStatusCode.NotFound);
            }

            if (reciver == null)
            {
                var errorMessage = new[] { "user with reciverID was not found" }.ToList();
                return ResponseCreator.CreateUnsuccessifullResponse(errorMessage,
                               (int)HttpStatusCode.NotFound);
            }

            Message message = new Message
            {
                Sender = sender,
                Reciver = reciver,
                Body = messageDTO.Body
            };

            var response = _messageRepository.Create(message);
            return response;
        }
    }
}
