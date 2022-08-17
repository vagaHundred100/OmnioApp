using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Domains
{
    public class ResponceWithData<T> : Responce
    {
        public T Data { get; set; }
    }
}
