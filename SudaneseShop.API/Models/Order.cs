using System.ComponentModel.DataAnnotations.Schema;

namespace SudaneseShop.API.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public string? UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public ApplicationUser? User { get; set; }
        public List<OrderItems>? OrderItems { get; set; }
    }
}
