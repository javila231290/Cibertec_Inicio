using System;
using System.ComponentModel.DataAnnotations;
using WebDeveloper.Resources;

namespace WebDeveloper.Model
{
    public class Product
    {
        [Required]
        [Display(Name = "Product_Id", ResourceType = typeof(Resource))]
        public int ID { get; set; }

        [Required(ErrorMessage = "This Description is required")]
        [Display(Name = "Product_Description", ResourceType = typeof(Resource))]        
        public string Description { get; set; }

        [Required(ErrorMessage = "This Category is required")]
        [Display(Name = "Product_Category", ResourceType = typeof(Resource))]        
        public string Category { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "This Price is required")]
        [Display(Name = "Product_Price", ResourceType = typeof(Resource))]        
        [Range(0, 10000, ErrorMessage = "Rango valido Min=0 Max=1000")]
        public double Price { get; set; }

        [Required(ErrorMessage = "This Registration Date is required")]        
        [DataType(DataType.Date)]
        [Display(Name = "Product_Registry", ResourceType = typeof(Resource))]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? Registry { get; set; }        
    }
}
