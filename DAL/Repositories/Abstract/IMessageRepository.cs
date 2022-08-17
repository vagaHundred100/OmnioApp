using DAL.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Abstract
{
    public interface IMessageRepository
    {
        Responce Create(Message message);
        Responce Update(Message message);
        Responce Delete(Guid id);
        Message FindById(Guid id);
        List<Message> GetAllMessages();
    }
}
