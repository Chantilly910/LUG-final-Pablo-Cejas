// 🔹 Interfaz: Define la estructura mínima para un movimiento de stock
using System;

namespace Modelo
{
    public interface IMovimiento
    {
        DateTime Fecha { get; set; }
        int Cantidad { get; set; }
        void ProcesarMovimiento();
    }
}
