using DAL.Domains;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class LoginDTO
    {
        [Required(ErrorMessage ="User name is requared")]
        public string UserName { get;  set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage ="Passward is requared")]
        public string Password { get;  set; }
    }
}
