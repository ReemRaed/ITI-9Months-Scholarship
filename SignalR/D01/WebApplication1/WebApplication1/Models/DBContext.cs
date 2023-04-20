using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public class DBContext:DbContext
    {
        public DBContext(DbContextOptions<DBContext> options)
           : base(options)
        {
        }
        public DbSet<Product> products { get; set; }
        public DbSet<Comments> Comments { get; set; }

    }
}
