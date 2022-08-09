using BLL.Domains;
using BLL.DTO;
using DAL.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Abstract
{
    public interface IChatService
    {
        ServiceResponce Write(Guid fromID,Guid toID,string body);
        ServiceResponceWithData<List<MessageReadDTO>> Read(Guid UserID, List<Message>messages);
    }
}
