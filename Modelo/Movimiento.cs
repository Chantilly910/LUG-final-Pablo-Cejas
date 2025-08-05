// 🔹 Herencia: Movimiento base para movimientos de stock
// 🔹 Polimorfismo: ProcesarMovimiento es virtual y será sobrescrito
using System;

namespace Modelo
{
    public abstract class Movimiento : EntidadBase, IMovimiento
    {
        public DateTime Fecha { get; set; }
        public int Cantidad { get; set; }
        public int ProductoId { get; set; }

        // 🔹 Polimorfismo: Método virtual que será sobrescrito en clases hijas
        public virtual void ProcesarMovimiento()
        {
            throw new NotImplementedException("Este método debe ser sobrescrito en la clase derivada.");
        }
    }
}
