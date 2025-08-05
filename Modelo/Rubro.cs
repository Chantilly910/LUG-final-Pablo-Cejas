// 🔹 Herencia: Rubro hereda de EntidadBase
using System;

namespace Modelo
{
    public class Rubro : EntidadBase
    {
        private string _descripcion;

        public string Descripcion
        {
            get => _descripcion;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("La descripción no puede estar vacía.");
                _descripcion = value;
            }
        }
    }
}
