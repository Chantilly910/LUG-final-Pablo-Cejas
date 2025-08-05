using Modelo;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Persistencia;

namespace Repos
{
    public class RepositorioProducto
    {
        private readonly ProductosDbContext _context;

        public RepositorioProducto()
        {
            _context = new ProductosDbContext();
        }

        public void Agregar(Producto producto)
        {
            _context.Productos.Add(producto);
            _context.SaveChanges();
        }

        public void Modificar(Producto producto)
        {
            _context.Productos.Update(producto);
            _context.SaveChanges();
        }

        public void Eliminar(int id)
        {
            var prod = _context.Productos.Find(id);
            if (prod != null)
            {
                _context.Productos.Remove(prod);
                _context.SaveChanges();
            }
        }

        public Producto ObtenerPorId(int id)
        {
            return _context.Productos.Find(id);
        }

        public List<Producto> ListarTodos()
        {
            return _context.Productos.ToList();
        }

        public List<Producto> BuscarPorNombre(string nombre)
        {
            return _context.Productos
                .Where(p => p.Nombre.Contains(nombre))
                .ToList();
        }

        public List<Producto> ObtenerProductosProximosAVencer()
        {
            var fechaLimite = DateTime.Now.AddDays(7); // próximos 7 días
            return _context.Productos
                .Where(p => p.FechaVencimiento <= fechaLimite)
                .ToList();
        }
    }
}
