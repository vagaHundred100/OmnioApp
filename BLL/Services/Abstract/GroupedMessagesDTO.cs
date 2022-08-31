using BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Abstract
{
    public class GroupedMessagesDTO
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string PhoneNumber { get; set; }
        public string ImageFilePath { get; set; }
        public List<MessageReadDTO> Messages { get; set; }
    }
}
