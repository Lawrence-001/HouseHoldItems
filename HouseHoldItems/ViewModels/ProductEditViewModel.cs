using HouseHoldItems.Models;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace HouseHoldItems.ViewModels
{
    public class ProductEditViewModel
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        [Display(Name = "Category")]
        public ProductCategory? ProductCategory { get; set; }
        public string ImgUrl { get; set; }
        [Required]
        public double Cost { get; set; }
    }
}
