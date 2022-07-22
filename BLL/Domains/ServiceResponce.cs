using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Domains
{

    public class ServiceResponce
    {
        public int StatusCode { get; set; } = 200;
        public bool Success { get; set; } = true;
        public List<string> ErrorMessages { get; set; } = new List<string>();
    }


    
}
