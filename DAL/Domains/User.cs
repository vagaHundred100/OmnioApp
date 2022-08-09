using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Domains
{
    public class User : IdentityUser
    {
        public bool IsEnabled { get; set; } = true;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<ChatBox> ChatBoxes { get; set; }
        public ICollection<Message> Messages { get; set; }
    }
}
