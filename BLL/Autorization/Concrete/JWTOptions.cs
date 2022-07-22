using BLL.Autorization.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Autorization.Concrete
{
    public class JWTOptions : IJWTOptions
    {
        public string Issuer { get; set; }
        public string Audience { get; set; }
        public string SecretKey { get; set; }
        public int ExpirationInYears { get; set; }
    }
}
