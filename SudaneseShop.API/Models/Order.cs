namespace SudaneseShop.API.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        public List<OrderItem> OrderItems { get; set; }
    }
}
