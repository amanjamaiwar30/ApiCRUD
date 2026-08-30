using ApiCRUD.Model;
using Microsoft.EntityFrameworkCore;

namespace ApiCRUD.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; } = null!;
    }
}
