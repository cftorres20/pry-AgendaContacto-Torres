using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace AgendaContacto
{
    internal class DBConexion
    {
        OleDbCommand comando;
        OleDbConnection conexion;
        OleDbDataAdapter adaptador;
        string cadena;

        public DBConexion()
        {
            cadena = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=contactos.accdb;";
            conexion = new OleDbConnection(cadena);
        }

        public void abrirConexion()
        {
            try
            {
                conexion.Open();
                //MessageBox.Show("Conexion abierta!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir la conexión: {ex.Message}");
            }
        }

        public void cerrarConexion()
        {
            try
            {
                conexion.Close();
                //MessageBox.Show("Conexion cerrada!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cerrar la conexión: {ex.Message}");
            }
        }

        public List<Dictionary<string, object>> obtenerDatos()
        {
            List<Dictionary<string, object>> listaContactos = new List<Dictionary<string, object>>();

            try
            {
                conexion.Open();
                string query = "SELECT * FROM contactos ORDER BY Id ASC";
                OleDbCommand comando = new OleDbCommand(query, conexion);
                OleDbDataReader leer = comando.ExecuteReader();

                while (leer.Read())
                {
                    Dictionary<string, object> fila = new Dictionary<string, object>();

                    for (int i = 0; i < leer.FieldCount; i++)
                    {
                        string nombreColumna = leer.GetName(i);
                        object valor = leer[i];
                        fila[nombreColumna] = valor;
                    }
                    listaContactos.Add(fila);
                }
                leer.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }

            return listaContactos;
        }

    }
}
