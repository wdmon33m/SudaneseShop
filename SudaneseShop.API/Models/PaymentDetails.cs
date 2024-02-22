namespace SudaneseShop.API.Models
{
    public class PaymentDetails
    {
        public int Id { get; set; }
        public string CardNumber { get; set; }
        public string ExpiryDate { get; set; }
        public string CVV { get; set; }
        public string CardholderName { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}
