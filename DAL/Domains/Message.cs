using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Domains
{
    public class Message
    {
        [Key]
        public Guid Id { get; set; }
        public string Body { get; set; }
        public bool ReadStatus { get; set; } = false;
        public bool IsDeletedFromSender { get; set; } = false;
        public bool IsDeletedFromReciver { get; set; } = false;
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public Guid? SenderID { get; set; }
        public Guid? ReciverID { get; set; }
        public User Sender { get; set; }
        public User Reciver { get; set; }
    }
}
