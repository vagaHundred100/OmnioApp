using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class RegisterDTO
    {
        [Required(ErrorMessage = "First name is requared")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Passward is requared")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Last name is requared")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "User name  is requared")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
