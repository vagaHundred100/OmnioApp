using System;
using System.ComponentModel.DataAnnotations;

namespace DAL.Domains
{
    public class Message// base ent
    {
        [Key]
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public bool Status { get; set; } = false; // enum
        public ChatBox ChatBox { get; set; }
        public User User { get; set; } // rename omniouser
    }
}
