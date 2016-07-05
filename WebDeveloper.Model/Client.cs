using System;
using System.ComponentModel.DataAnnotations;
using WebDeveloper.Resources;

namespace WebDeveloper.Model
{
    
    public class Client
    {
        [Required]
        [Display(Name = "Client_Id", ResourceType = typeof(Resource))]
        public int ID { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [Display(Name = "Client_Name", ResourceType =typeof(Resource))]
        public string Name { get; set; }

        [Required(ErrorMessage = "This Last Name is required")]
        [Display(Name = "Client_LastName", ResourceType = typeof(Resource))]
        public string LastName { get; set; }

        
        [Display(Name = "Client_DateCreation", ResourceType = typeof(Resource))]
        [DataType(DataType.DateTime)]
        public DateTime? DateCreation { get; set; }
    }
}
