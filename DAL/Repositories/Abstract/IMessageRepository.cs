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
        Task<Responce> CreateAsync(Message message);
        Task<Responce> UpdateAsync(Message message);
        Task<Responce> DeleteAsync(Guid id);
        Task<Message> FindByIdAsync(Guid id);
        Task<List<Message>> GetAllMessagesAsListAsync();
        IQueryable<Message> GetAllMessages();

    }
}
