namespace SudaneseShop.API.Models
{
    public class DeletedRow
    {
        public string? RowId { get; set;}
        public string? TableId { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime DeletedAt { get; set; } = DateTime.Now;
    }
}
