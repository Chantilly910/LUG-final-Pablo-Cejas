// 🔹 Abstracción: Clase base abstracta para todas las entidades
// 🔹 Herencia: Producto, Proveedor, Rubro, Movimiento heredan de esta clase
using System;

namespace Modelo
{
    public abstract class EntidadBase
    {
        public int Id { get; set; }
        public bool Activo { get; set; } = true;
    }
}
