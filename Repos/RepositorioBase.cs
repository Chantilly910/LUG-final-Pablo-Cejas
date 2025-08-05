// 🔹 Clase abstracta que implementa IRepositorio y encapsula lógica básica
// 🔹 Herencia: repositorios específicos heredan de esta clase
// 🔹 Encapsulamiento: lista privada para manejar colección en memoria
using System;
using System.Collections.Generic;
using System.Linq;
using Modelo;

namespace Repos
{
    public abstract class RepositorioBase<T> : IRepositorio<T> where T : EntidadBase
    {
        // Lista privada para control interno de datos
        protected List<T> lista = new List<T>();

        public virtual void Agregar(T entidad)
        {
            entidad.Id = lista.Count > 0 ? lista.Max(e => e.Id) + 1 : 1;
            lista.Add(entidad);
        }

        public virtual void Modificar(T entidad)
        {
            var original = ObtenerPorId(entidad.Id);
            if (original == null)
                throw new Exception($"No se encontró la entidad con Id {entidad.Id} para modificar.");

            int index = lista.IndexOf(original);
            lista[index] = entidad;
        }

        public virtual void Eliminar(int id)
        {
            var entidad = ObtenerPorId(id);
            if (entidad == null)
                throw new Exception($"No se encontró la entidad con Id {id} para eliminar.");

            entidad.Activo = false; // Baja lógica
        }

        public virtual T ObtenerPorId(int id)
        {
            return lista.FirstOrDefault(e => e.Id == id && e.Activo);
        }

        public virtual IEnumerable<T> ListarTodos()
        {
            return lista.Where(e => e.Activo);
        }
    }
}
