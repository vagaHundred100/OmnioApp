using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAL.Domains
{
    public class ChatBox
    {
        [Key]
        public int Id { get; set; }
        public ICollection<User> Users { get; set; }

    }
}
