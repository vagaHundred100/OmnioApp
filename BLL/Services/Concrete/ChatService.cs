using BLL.Domains;
using BLL.DTO;
using BLL.Services.Abstract;
using DAL.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Concrete
{
    public class ChatService : IChatService
    {
        public ServiceResponceWithData<List<MessageReadDTO>> Read(Guid UserID, List<Message> messages)
        {
            throw new NotImplementedException();
        }

        public ServiceResponce Write(Guid fromID, Guid toID, string body)
        {
            var message = new Message()
            {
                FromUserId = fromID,
                ToUserId = toID,
                Body = body,
                CreateDate = DateTime.Now
            };

            throw new NotImplementedException();
        }
    }
}
