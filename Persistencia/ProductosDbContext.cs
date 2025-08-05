using Microsoft.EntityFrameworkCore;
using Modelo;

namespace Persistencia
{
    public class ProductosDbContext : DbContext
    {
        public DbSet<Producto> Productos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=LUGProductosDB;Trusted_Connection=True;");
        }
    }
}