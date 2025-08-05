// 🔹 Excepción personalizada para manejo de errores
using System;

namespace Excepciones
{
    public class StockInsuficienteException : Exception
    {
        public StockInsuficienteException(string mensaje) : base(mensaje) { }
    }
}
