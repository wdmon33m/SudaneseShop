﻿namespace SudaneseShop.API.Models
{
    public class ShoppingCartItem
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public string UserId { get; set; }
    }
}
