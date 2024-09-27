using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaContacto
{
    internal class Archivo
    {
        public void escribir(string nombreArchivo, bool agrega, string registro)
        {
            using (StreamWriter escribir = new StreamWriter(nombreArchivo, agrega, Encoding.UTF8))
            {
                escribir.WriteLine(registro);
            }
        }

        public void Exportar(string nombreArchivo, List<Dictionary<string, object>> listaDatos)
        {
            if (listaDatos.Count > 0)
            {
                var columnas = listaDatos[0].Keys;
                escribir(nombreArchivo, false, string.Join(";", columnas));

                foreach (var fila in listaDatos) 
                {  
                   
                    List<string> valoresFila = new List<string>();

                    foreach (var columna in columnas)
                    {
                        var valor = fila[columna]?.ToString() ?? "";

                        if (valor.Contains(",") || valor.Contains("\"") || valor.Contains("\n"))
                        {
                            valor = $"\"{valor.Replace("\"", "\"\"")}\"";  // Doblar las comillas dobles si las hay
                        }

                        valoresFila.Add(valor);
                    }

                    escribir(nombreArchivo, true, string.Join(";", valoresFila));

                }

            }
        }
    }
}
