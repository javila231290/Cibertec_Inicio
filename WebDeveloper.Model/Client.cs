using System;
using System.ComponentModel.DataAnnotations;

namespace WebDeveloper.Model
{
    public class Client
    {
        [Required]
        [Display(Name = "Client ID: ")]
        public int ID { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [Display(Name = "First Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "This Last Name is required")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }


    }
}
