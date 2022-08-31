using DAL.Context;
using DAL.Domains;
using DAL.Helpers;
using DAL.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

        public async Task<Responce> CreateAsync(Message message)
        {
            try
            {
                _contex.Messages.Add(message);
                await _contex.SaveChangesAsync();
                return ResponseCreator.CreateSuccessifullResponse();
            }
            catch (Exception ex)
            {
                List<string> errorMeesages = new List<string>() { ex.Message };
                return ResponseCreator
                    .CreateUnsuccessifullResponse(errorMeesages,
                        (int)HttpStatusCode.InternalServerError);
            }
        }

        public async Task<Responce> DeleteAsync(Guid id)
        {
            var message = await _contex.Messages.FindAsync(id);
            try
            {
                _contex.Remove(message);
                await _contex.SaveChangesAsync();
                return ResponseCreator.CreateSuccessifullResponse();
            }
            catch (Exception ex)
            {
                List<string> errorMeesages = new List<string>() { ex.Message };
                return ResponseCreator
                    .CreateUnsuccessifullResponse(errorMeesages,
                        (int)HttpStatusCode.InternalServerError);
            }
        }


        public async Task<Message> FindByIdAsync(Guid id)
        {
            var message = await _contex.Messages.FindAsync(id);
            return message;
        }

        public async Task<Responce> UpdateAsync(Message message)
        {
            try
            {
                _contex.Messages.Update(message);
                await _contex.SaveChangesAsync();
                return ResponseCreator.CreateSuccessifullResponse();
            }
            catch (Exception ex)
            {
                List<string> errorMeesages = new List<string>() { ex.Message };
                return ResponseCreator
                    .CreateUnsuccessifullResponse(errorMeesages,
                        (int)HttpStatusCode.InternalServerError);
            }
        }

        public async Task<List<Message>> GetAllMessagesAsListAsync()
        {
            return await _contex.Messages.ToListAsync();
        }

        public IQueryable<Message> GetAllMessages()
        {
            return _contex.Messages;
        }
    }
}
