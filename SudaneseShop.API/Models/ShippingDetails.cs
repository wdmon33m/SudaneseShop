namespace SudaneseShop.API.Models
{
    public class ShippingDetails
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}
