using System;
using System.ComponentModel.DataAnnotations;

namespace DAL.Domains
{
    public class Message
    {
        [Key]
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public bool Status { get; set; } = false;
        public int FromUserId { get; set; }
        public ChatBox ChatBox { get; set; }

    }
}
