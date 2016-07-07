using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDeveloper.Models.Account
{
    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "User Name ")]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [Display(Name = "Confirm Password ")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "")]
        public string ConfirmPassword { get; set; }
    }
}
