// 🔹 Herencia: Producto hereda de EntidadBase
// 🔹 Encapsulamiento: Validación en setters para precio y stock
using System;

namespace Modelo
{
    public class Producto : EntidadBase
    {
        private string _nombre;
        private decimal _precioCompra;
        private decimal _precioVenta;
        private int _stock;
        private DateTime _fechaVencimiento;

        public string Nombre
        {
            get => _nombre;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El nombre no puede estar vacío.");
                _nombre = value;
            }
        }

        public decimal PrecioCompra
        {
            get => _precioCompra;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("El precio de compra debe ser mayor a cero.");
                _precioCompra = value;
                PrecioVenta = _precioCompra * 1.5m; // 🔹 Encapsulamiento y lógica automática
            }
        }

        public decimal PrecioVenta
        {
            get => _precioVenta;
            private set => _precioVenta = value; // privado para evitar cambios externos directos
        }

        public int Stock
        {
            get => _stock;
            set
            {
                if (value < 0)
                    throw new ArgumentException("El stock no puede ser negativo.");
                _stock = value;
            }
        }

        public DateTime FechaVencimiento
        {
            get => _fechaVencimiento;
            set
            {
                if (value < DateTime.Today)
                    throw new ArgumentException("La fecha de vencimiento no puede ser anterior a hoy.");
                _fechaVencimiento = value;
            }
        }
    }
}
