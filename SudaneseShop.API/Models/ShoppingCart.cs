namespace SudaneseShop.API.Models
{
    public class ShoppingCart
    {
        public string UserId { get; set; }
        public List<ShoppingCartItem> Items { get; set; }

        public decimal TotalPrice => Items.Sum(item => item.Product.Price * item.Quantity);
    }
}
