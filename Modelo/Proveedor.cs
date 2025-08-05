// 🔹 Herencia: Proveedor hereda de EntidadBase
using System;

namespace Modelo
{
    public class Proveedor : EntidadBase
    {
        private string _nombre;

        public string Nombre
        {
            get => _nombre;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El nombre del proveedor no puede estar vacío.");
                _nombre = value;
            }
        }
    }
}
