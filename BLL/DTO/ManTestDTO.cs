using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class ManTestDTO
    {
        [Range(18, 56, ErrorMessage = "Age Must be between 18 to 56")]
        public int MyProperty { get; set; }
        public bool IsMyProperty { get; set; }
    }
}
