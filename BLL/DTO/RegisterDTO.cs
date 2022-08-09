using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        [Required(ErrorMessage = "Email is requared")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phonenumber is requared")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Please Upload a Valid Image File. Only jpg format allowed")]
        [DataType(DataType.Upload)]
        [Display(Name = "Upload Product Image")]
        [NotMapped]
        public IFormFile ImageFile { get; set; }
    }
}
