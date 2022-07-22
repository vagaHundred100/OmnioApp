using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class RisetPasswordDTO
    {
        [Required(ErrorMessage = "UserName is requared")]
        public string UserId { get; set; }

        [Required(ErrorMessage = "Token is requared")]
        public string Token { get; set; }

        [Required(ErrorMessage = "NewPass is requared")]
        public string NewPass { get; set; }
    }
}
