using System.ComponentModel.DataAnnotations;

namespace SudaneseShop.API.Models
{
    public class Category
    {
        public int Id { get; set; }
        [NameValidation]
        [Display(Name = "Category Name")]
        public required string Name { get; set; }
        public List<Product>? Products { get; set; }
        public bool IsActivate { get; set; } = true;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public string? Notes { get; set; }
    }
}
