// 🔹 Repositorio específico para Producto
// 🔹 Uso de LINQ para filtrados y búsquedas
using System;
using System.Collections.Generic;
using System.Linq;
using Modelo;

namespace Repos
{
    public class RepositorioProducto : RepositorioBase<Producto>
    {
        public IEnumerable<Producto> ObtenerProductosProximosAVencer(int dias = 7)
        {
            DateTime limite = DateTime.Today.AddDays(dias);
            // 🔹 LINQ + Lambda para filtrar productos próximos a vencer
            return lista.Where(p => p.Activo && p.FechaVencimiento <= limite);
        }

        public IEnumerable<Producto> BuscarPorNombre(string nombre)
        {
            return lista.Where(p => p.Activo && p.Nombre.IndexOf(nombre, StringComparison.OrdinalIgnoreCase) >= 0);
        }
    }
}
