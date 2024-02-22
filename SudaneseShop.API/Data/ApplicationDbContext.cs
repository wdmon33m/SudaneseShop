using Microsoft.EntityFrameworkCore;
using SudaneseShop.API.Models;

namespace SudaneseShop.API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
