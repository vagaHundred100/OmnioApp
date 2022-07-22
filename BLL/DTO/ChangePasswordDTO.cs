using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class ChangePasswordDTO
    {
        [Required(ErrorMessage = "User name is requared")]
        public string UserId { get; set; }

        [Required(ErrorMessage = "CurrentPass is requared")]
        public string CurrentPass { get; set; }

        [Required(ErrorMessage = "NewPass is requared")]
        public string NewPass { get; set; }
    }
}
