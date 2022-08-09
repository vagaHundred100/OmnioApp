using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Domains
{
    public class User : IdentityUser<Guid>
    {
        public bool IsEnabled { get; set; } = true;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Image Image { get; set; }

        public ICollection<Message> ReceivedMessages { get; set; }
        public ICollection<Message> SentMessages { get; set; }
    }
}
