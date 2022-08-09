using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Domains
{
    public class Image
    {
        [Key]
        public Guid Id { get; set; } 
        public string Name { get; set; }
        [NotMapped]
        public IFormFile File { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public string FilePath { get; set; }
    }
}
