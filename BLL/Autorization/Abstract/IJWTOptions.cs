using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Autorization.Abstract
{
    public interface IJWTOptions
    {
        public string Issuer { get; set; } // Tokeni gonderen
        public string Audience { get; set; } // Tokeni gebul eden
        public string SecretKey { get; set; }
        public int ExpirationInYears { get; set; }
    }
}

