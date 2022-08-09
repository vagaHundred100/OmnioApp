using BLL.Autorization.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Autorization.Concrete
{
    public class UserClaimsOptions : IUserClaimsOptions
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public bool IsEnabled { get; set; }

    }
}
