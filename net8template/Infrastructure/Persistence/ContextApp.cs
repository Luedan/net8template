using Microsoft.EntityFrameworkCore;
using net8template.Domain.Models;

namespace net8template.Infrastructure.Persistence
{
    public class ContextApp : DbContext
    {
        public ContextApp(DbContextOptions<ContextApp> contextOptions): base(contextOptions) { }

        public DbSet<Products> Products { get; set; }
    }
}
