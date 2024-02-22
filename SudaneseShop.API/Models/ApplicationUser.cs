using Microsoft.AspNetCore.Identity;

namespace SudaneseShop.API.Models
{
    public class ApplicationUser : IdentityUser
    {
        // Additional properties specific to your application
        public string FullName { get; set; }
        public List<Order> Orders { get; set; }
    }
}
