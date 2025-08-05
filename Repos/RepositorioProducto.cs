using Modelo;
using System.Collections.Generic;
using System.Linq;
using Persistencia;

namespace Repos
{
    public class RepositorioProducto
    {
        public void AltaProducto(Producto producto)
        {
            using var db = new ProductosDbContext();
            db.Productos.Add(producto);
            db.SaveChanges();
        }

        public void ModificarProducto(Producto producto)
        {
            using var db = new ProductosDbContext();
            db.Productos.Update(producto);
            db.SaveChanges();
        }

        public void BajaProducto(int id)
        {
            using var db = new ProductosDbContext();
            var prod = db.Productos.Find(id);
            if (prod != null)
            {
                db.Productos.Remove(prod);
                db.SaveChanges();
            }
        }

        public List<Producto> ListarProductos()
        {
            using var db = new ProductosDbContext();
            return db.Productos.ToList();
        }
    }
}