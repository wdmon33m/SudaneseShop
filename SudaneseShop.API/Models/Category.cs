using System.ComponentModel.DataAnnotations;

namespace SudaneseShop.API.Models
{
    public class Category
    {
        public int Id { get; set; }
        [NameValidation]
        [Display(Name = "Product Name")]
        public required string Name { get; set; }
        public List<Product>? Products { get; set; }
    }
}
