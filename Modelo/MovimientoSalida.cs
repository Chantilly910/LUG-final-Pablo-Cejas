// 🔹 Herencia y Polimorfismo: Sobrescribe ProcesarMovimiento para salida de stock
using System;
using Modelo;

namespace Modelo
{
    public class MovimientoSalida : Movimiento
    {
        public override void ProcesarMovimiento()
        {
            // Lógica para disminuir stock
            // Esto será implementado en controladora, aquí solo la firma
        }
    }
}
