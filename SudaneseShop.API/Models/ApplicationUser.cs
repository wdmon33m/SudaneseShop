using Microsoft.AspNetCore.Identity;

namespace SudaneseShop.API.Models
{
    public class ApplicationUser : IdentityUser
    {
        // Additional properties specific to your application
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public List<Order>? Orders { get; set; }
        public bool IsActivate { get; set; } = true;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public string? Notes { get; set; }
    }
}
