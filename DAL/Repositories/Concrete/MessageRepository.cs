using System;
using System.Collections.Generic;
using DAL.Domains;
using DAL.Repositories.Abstract;

namespace DAL.Repositories.Concrete
{
    public class MessageRepository : IMessageRepository
    {
        public void Create(Message message)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Message> FindAll()
        {
            throw new NotImplementedException();
        }

        public List<Message> FindUsersAllMessages()
        {
            throw new NotImplementedException();
        }

        public void Update(Message message)
        {
            throw new NotImplementedException();
        }
    }
}
