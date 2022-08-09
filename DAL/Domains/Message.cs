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
        public bool DeleteStatus { get; set; } = false;
        public DateTime CreateDate { get; set; } 

        public Guid? FromUserId { get; set; }
        public User FromUser { get; set; }

        public Guid? ToUserId { get; set; }
        public User ToUser { get; set; }
    }
}
