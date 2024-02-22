using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SudaneseShop.API.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="{0} can't be null")]
        [Display(Name = "Product Name")]
        [StringLength(100, MinimumLength = 3)]
        public required string Name { get; set; }
        public string? Description { get; set; }
        [Required(ErrorMessage ="Please enter {0} betwwn {1} and {2}")]
        [Range(0.01, 10000.00)]
        public required decimal Price { get; set; }

        public int CategoryId { get; set; }
        public Category? Category { get; set; }

        public string ImageUrl { get; set; } = "https://via.placeholder.com/150";
        public int StockQuantity { get; set; }
    }

}
