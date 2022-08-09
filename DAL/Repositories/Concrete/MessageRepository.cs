using DAL.Context;
using DAL.Domains;
using DAL.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Concrete
{
    public class MessageRepository : IMessageRepository
    {
        private readonly OnionDbContext _contex;

        public MessageRepository(OnionDbContext contex)
        {
            _contex = contex;
        }
        public void Create(Message message)
        {
            if (message == null) throw new ArgumentNullException();
            _contex.Messages.Add(message);
        }

        public void Delete(Guid id)
        {
            var message = _contex.Messages.Find(id);
            if(message == null)
            {
                throw new KeyNotFoundException();
            }
            _contex.Remove(message);

        }


        public Message FindById(Guid id)
        {
            var message = _contex.Messages.Find(id);
            if (message == null)
            {
                throw new KeyNotFoundException();
            }
            return message;
        }

       
    }
}
