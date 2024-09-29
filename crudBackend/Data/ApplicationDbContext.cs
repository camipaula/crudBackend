using crudBackend.Models;
using Microsoft.EntityFrameworkCore;

namespace crudBackend.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Producto> Productos { get; set; }
    }
}
