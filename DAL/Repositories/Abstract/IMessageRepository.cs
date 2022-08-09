using System;
using System.Collections.Generic;
using DAL.Domains;

namespace DAL.Repositories.Abstract
{
    public interface IMessageRepository
    {
        public void Create(Message message);
        public void Update(Message message);
        public void Delete(int id);
        public List<Message> FindAll();
        public List<Message> FindUsersAllMessages();

    }
}
