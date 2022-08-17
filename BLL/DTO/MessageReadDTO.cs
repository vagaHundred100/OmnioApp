using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class MessageReadDTO
    {
        public string Body { get; set; }
        public bool ReadStatus { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
