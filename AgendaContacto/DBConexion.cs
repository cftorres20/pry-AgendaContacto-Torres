using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

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
            cadena = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Productos.accdb;";

            conexion = new OleDbConnection(cadena);
        }

    }
}
