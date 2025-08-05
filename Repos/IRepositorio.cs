// 🔹 Interfaz genérica para operaciones CRUD
using System.Collections.Generic;

namespace Repos
{
    public interface IRepositorio<T>
    {
        void Agregar(T entidad);
        void Modificar(T entidad);
        void Eliminar(int id); // Baja lógica
        T ObtenerPorId(int id);
        IEnumerable<T> ListarTodos();
    }
}
