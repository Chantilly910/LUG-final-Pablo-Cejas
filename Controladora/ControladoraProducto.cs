// 🔹 Controladora para la entidad Producto
// 🔹 Encapsulamiento: controla acceso a repositorio y lógica de negocio
// 🔹 Uso de excepciones para manejo de errores

using System;
using System.Collections.Generic;
using System.Linq;
using Excepciones;
using Microsoft.EntityFrameworkCore;
using Modelo;
using Repos;
using Persistencia;

namespace Controladora
{
    public class ControladoraProducto
    {
        private readonly RepositorioProducto _repositorio;

        public ControladoraProducto(RepositorioProducto repositorio)
        {
            _repositorio = repositorio;
        }

        public void AltaProducto(Producto producto)
        {
            if (producto == null)
                throw new ArgumentNullException(nameof(producto));

            if (_repositorio.ListarTodos().Any(p => p.Nombre.Equals(producto.Nombre, StringComparison.OrdinalIgnoreCase)))
                throw new Exception("Ya existe un producto con ese nombre.");

            _repositorio.Agregar(producto);
        }

        public void ModificarProducto(Producto producto)
        {
            if (producto == null)
                throw new ArgumentNullException(nameof(producto));

            var original = _repositorio.ObtenerPorId(producto.Id);
            if (original == null)
                throw new Exception("Producto no encontrado.");

            _repositorio.Modificar(producto);
        }

        public void BajaProducto(int id)
        {
            var producto = _repositorio.ObtenerPorId(id);
            if (producto == null)
                throw new Exception("Producto no encontrado.");

            _repositorio.Eliminar(id); // Baja lógica
        }

        public Producto ObtenerProductoPorId(int id)
        {
            return _repositorio.ObtenerPorId(id);
        }

        public IEnumerable<Producto> ListarProductos()
        {
            return _repositorio.ListarTodos();
        }

        public IEnumerable<Producto> BuscarProductosPorNombre(string nombre)
        {
            return _repositorio.BuscarPorNombre(nombre);
        }

        public List<Producto> ObtenerProductosProximosAVencer(int dias = 7)
        {
            var fechaLimite = DateTime.Now.AddDays(dias);
            return _repositorio.ObtenerProductosProximosAVencer()
                .Where(p => p.FechaVencimiento <= fechaLimite)
                .ToList();
        }


        public void ProcesarMovimientoEntrada(int productoId, int cantidad)
        {
            var producto = _repositorio.ObtenerPorId(productoId);
            if (producto == null)
                throw new Exception("Producto no encontrado.");

            producto.Stock += cantidad;
            _repositorio.Modificar(producto);
        }

        public void ProcesarMovimientoSalida(int productoId, int cantidad)
        {
            var producto = _repositorio.ObtenerPorId(productoId);
            if (producto == null)
                throw new Exception("Producto no encontrado.");

            if (producto.Stock < cantidad)
                throw new StockInsuficienteException("Stock insuficiente para la salida solicitada.");

            producto.Stock -= cantidad;
            _repositorio.Modificar(producto);
        }
    }
}
