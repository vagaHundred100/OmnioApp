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


        public async Task<ResponceWithData<List<GroupedMessagesDTO>>> ReadAllSentMessagesAsync(string senderId)
        {
            List<GroupedMessagesDTO> sendersWithMessagesDTO = new List<GroupedMessagesDTO>();
            var messages = _messageRepository.GetAllMessages();
            var sendersWithMessages = messages
                .Include(m => m.Reciver)?
                    .ThenInclude(c => c.Image)
                .Where(c => c.SenderID == new Guid(senderId))
                .Where(c => c.IsDeletedFromSender == false)
                .AsEnumerable()
                .GroupBy(m => m.Reciver);

            foreach (var reciver in sendersWithMessages)
            {
                var senderDTO = _mapper.Map<GroupedMessagesDTO>(reciver.Key);
                senderDTO.Messages = new List<MessageReadDTO>();
                foreach (var message in reciver)
                {
                    message.ReadStatus = true;
                    await _messageRepository.UpdateAsync(message);
                    senderDTO.Messages.Add(_mapper.Map<MessageReadDTO>(message));
                }
                sendersWithMessagesDTO.Add(senderDTO);
            }

            return new ResponceWithData<List<GroupedMessagesDTO>>() { Data = sendersWithMessagesDTO, Success = true };
        }

        public async Task<ResponceWithData<List<GroupedMessagesDTO>>> ReadAllRecivedMessagesAsync(string reciverID)
        {
            List<GroupedMessagesDTO> sendersWithMessagesDTO = new List<GroupedMessagesDTO>();
            var messages = _messageRepository.GetAllMessages();
            var sendersWithMessages = messages
                .Include(m => m.Sender)?
                    .ThenInclude(c => c.Image)
                .Where(c => c.ReciverID == new Guid(reciverID))
                .Where(c => c.IsDeletedFromReciver == false)
                .AsEnumerable()
                .GroupBy(m => m.Sender);

            foreach (var sender in sendersWithMessages)
            {
                var senderDTO = _mapper.Map<GroupedMessagesDTO>(sender.Key);
                senderDTO.Messages = new List<MessageReadDTO>();
                foreach (var message in sender)
                {
                    message.ReadStatus = true;
                    await _messageRepository.UpdateAsync(message);
                    senderDTO.Messages.Add(_mapper.Map<MessageReadDTO>(message));
                }
                sendersWithMessagesDTO.Add(senderDTO);
            }

            return new ResponceWithData<List<GroupedMessagesDTO>>() { Data = sendersWithMessagesDTO, Success = true };

        }

        public async Task<Responce> WriteMessageAsync(MessageWriteDTO messageDTO)
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

            var response = await _messageRepository.CreateAsync(message);
            return response;
        }

        public async Task<Responce> DeleteMesageFromUserAsync(string messageStringId, string userStringId)
        {
            var userId = new Guid(userStringId);
            var message = await _messageRepository.FindByIdAsync(new Guid(messageStringId));

            if (message == null)
            {
                return ResponseCreator.CreateUnsuccessifullResponse(new[]
                    { "Message was not found" }.ToList()
                    , (int)HttpStatusCode.NotFound);
            }

            if (message.ReciverID == userId)
            {
                message.IsDeletedFromReciver = true;
            }
            else if (message.SenderID == userId)
            {
                message.IsDeletedFromSender = true;
            }
            else
            {
                return ResponseCreator.CreateUnsuccessifullResponse(new[]
                    {"Current user does not contain this message" }.ToList()
                    , (int)HttpStatusCode.NotFound);
            }

            await _messageRepository.UpdateAsync(message);
            return ResponseCreator.CreateSuccessifullResponse();
        }

        public async Task<Responce> DeleteMessageFromChatAsync(string messageId, string userStringId)
        {
            var userId = new Guid(userStringId);
            var message = await _messageRepository.FindByIdAsync(new Guid(messageId));

            if (message == null)
            {
                return ResponseCreator.CreateUnsuccessifullResponse(new[]
                    { "Message was not found" }.ToList()
                    , (int)HttpStatusCode.NotFound);
            }

            if (message.ReciverID != userId && message.SenderID != userId)
            {
                return ResponseCreator.CreateUnsuccessifullResponse(new[]
                   {"Current user does not contain this message" }.ToList()
                   , (int)HttpStatusCode.NotFound);
            }

            message.IsDeletedFromReciver = true;
            message.IsDeletedFromSender = true;
            await _messageRepository.UpdateAsync(message);
            return ResponseCreator.CreateSuccessifullResponse();
        }

        public async Task<Responce> UpdateMessage(string messageId)
        {
            var message = await _messageRepository.FindByIdAsync(new Guid(messageId));
            if (message == null)
            {
                return ResponseCreator.CreateUnsuccessifullResponse(new[]
                    { "Message was not found" }.ToList()
                    , (int)HttpStatusCode.NotFound);
            }
            await _messageRepository.UpdateAsync(message);
            return ResponseCreator.CreateSuccessifullResponse();
        }

    }
}
