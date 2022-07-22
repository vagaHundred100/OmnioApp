using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Domains
{
    public class ServiceResponceWithData<T> : ServiceResponce
    {
        public T Data { get; set; }
    }
}
