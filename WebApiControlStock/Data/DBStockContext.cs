using Microsoft.EntityFrameworkCore;
using WebApiControlStock.Models;

namespace WebApiControlStock.Data
{
    public class DBStockContext : DbContext
    {
        public DBStockContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Producto> Productos { get; set; }

        
    }
}
