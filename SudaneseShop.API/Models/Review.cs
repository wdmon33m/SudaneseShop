using System.ComponentModel.DataAnnotations;

namespace SudaneseShop.API.Models
{
    public class Review
    {
        public int Id { get; set; }
        public required string UserId { get; set; }
        public ApplicationUser? User { get; set; }
        public int ProductId { get; set; }
        public Product? Product { get; set; }
        public string? Content { get; set; }
        [Required(ErrorMessage ="Plese enter valid rating")]
        [Range(1, 5)]
        public int Rating { get; set; }
        public DateTime DatePosted { get; set; }
    }
}
