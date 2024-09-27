using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaContacto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panelGestionContacto_MouseHover(object sender, EventArgs e)
        {
            panelGestionContacto.Size = new Size(103, 98);
        }

        private void panelGestionContacto_MouseLeave(object sender, EventArgs e)
        {
            panelGestionContacto.Size = new Size(101, 95);
        }

        private void panelBuscarContacto_MouseHover(object sender, EventArgs e)
        {
            panelBuscarContacto.Size = new Size(109, 98);    
        }

        private void panelBuscarContacto_MouseLeave(object sender, EventArgs e)
        {
            panelBuscarContacto.Size = new Size(106, 95);
        }

        private void panelExportar_MouseHover(object sender, EventArgs e)
        {
            panelExportar.Size = new Size(109, 101);
        }

        private void panelExportar_MouseLeave(object sender, EventArgs e)
        {
            panelExportar.Size = new Size(106, 98);
        }

        private void panelSalir_MouseHover(object sender, EventArgs e)
        {
            panelSalir.Size = new Size(53, 49);
        }

        private void panelSalir_MouseLeave(object sender, EventArgs e)
        {
            panelSalir.Size = new Size(50, 46);
        }

        private void panelSalir_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void panelGestionContacto_MouseClick(object sender, MouseEventArgs e)
        {

            Busquedas buscar = new Busquedas();
            //GestionContacto gestionContacto = new GestionContacto();
            buscar.Show(); //.Show() es para interactuar con ambas 
            this.Hide();

        }

        private void panelBuscarContacto_MouseClick(object sender, MouseEventArgs e)
        {
            Busquedas buscar = new Busquedas();
            buscar.Show();
            this.Hide();
        }

        private void panelExportar_MouseClick(object sender, MouseEventArgs e)
        {
            exportar();
        }

        private void exportar()
        {
            DBConexion db = new DBConexion();
            Archivo archivo = new Archivo();

            List<Dictionary<string, object>> listaContactos = db.obtenerDatos();

            if (listaContactos.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.");
                return;
            }

            Random rand = new Random();
            int num = rand.Next(0,1000);

            string nombreArchivo = $"contactos{num}.csv";
            string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, nombreArchivo);

            archivo.Exportar(rutaArchivo, listaContactos);

            MessageBox.Show($"Datos exportados exitosamente a {rutaArchivo}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


    }
}
