using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class MessageWriteDTO
    {
        [Required(ErrorMessage = "Id is required")]
        public string ReciverId { get; set; }

        [JsonIgnore]
        public string SenderId { get; set; }
        public string Body { get; set; }
    }
}
