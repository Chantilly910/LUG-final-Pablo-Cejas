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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Producto>(entity =>
            {
                entity.Property(e => e.PrecioCompra)
                      .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PrecioVenta)
                      .HasColumnType("decimal(18, 2)");
            });
        }

    }
}