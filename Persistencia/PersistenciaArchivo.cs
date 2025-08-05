// 🔹 Clase estática para manejar lectura y escritura CSV
// 🔹 Manejo de excepciones para I/O
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Persistencia
{
    public static class PersistenciaArchivo
    {
        public static void GuardarCSV<T>(string ruta, List<T> datos)
        {
            try
            {
                var lineas = new List<string>();

                // Obtener nombres de propiedades para cabecera
                var props = typeof(T).GetProperties();
                string header = string.Join(";", props.Select(p => p.Name));
                lineas.Add(header);

                // Agregar valores de cada objeto
                foreach (var item in datos)
                {
                    var valores = props.Select(p =>
                    {
                        var val = p.GetValue(item);
                        return val != null ? val.ToString() : "";
                    });
                    lineas.Add(string.Join(";", valores));
                }

                File.WriteAllLines(ruta, lineas);
            }
            catch (Exception ex)
            {
                throw new IOException($"Error al guardar archivo CSV en {ruta}: {ex.Message}");
            }
        }

        public static List<T> CargarCSV<T>(string ruta) where T : new()
        {
            var lista = new List<T>();

            try
            {
                if (!File.Exists(ruta))
                    return lista;

                var lineas = File.ReadAllLines(ruta);
                if (lineas.Length < 2)
                    return lista;

                var props = typeof(T).GetProperties();

                // Saltar la primera línea (cabecera)
                for (int i = 1; i < lineas.Length; i++)
                {
                    var valores = lineas[i].Split(';');
                    var obj = new T();

                    for (int j = 0; j < props.Length && j < valores.Length; j++)
                    {
                        var prop = props[j];
                        var valor = valores[j];

                        if (string.IsNullOrEmpty(valor))
                            continue;

                        object valorConvertido = Convert.ChangeType(valor, prop.PropertyType);
                        prop.SetValue(obj, valorConvertido);
                    }

                    lista.Add(obj);
                }
            }
            catch (Exception ex)
            {
                throw new IOException($"Error al cargar archivo CSV en {ruta}: {ex.Message}");
            }

            return lista;
        }
    }
}
