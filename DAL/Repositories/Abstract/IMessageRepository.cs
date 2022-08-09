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
        void Create(Message message);
        void Delete(Guid id);
        Message FindById(Guid id);

    }
}
