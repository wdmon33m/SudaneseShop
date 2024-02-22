namespace SudaneseShop.API.Models
{
    public class Wishlist
    {
        public string UserId { get; set; }
        public List<WishlistItem> Items { get; set; }
    }
}
