using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebDeveloper.Model
{
    public class Product
    {
        [Required]
        public int ID { get; set; }

        [Required(ErrorMessage = "This Description is required")]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [Required(ErrorMessage = "This Category is required")]
        [Display(Name = "Category")]
        public string Category { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "This Price is required")]
        [Display(Name = "Price")]
        [Range(0, 10000, ErrorMessage = "Rango valido Min=0 Max=1000")]
        public double Price { get; set; }

        [Required(ErrorMessage = "This Registration Date is required")]
        [Display(Name = "Registry")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? Registry { get; set; }        
    }
}
