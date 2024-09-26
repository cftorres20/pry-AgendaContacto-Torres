using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaContacto
{
    public partial class Busquedas : Form
    {
        public Busquedas()
        {
            InitializeComponent();
        }

        private void panelBuscarPorDatos_MouseHover(object sender, EventArgs e)
        {
            panelBuscarPorDatos.Size = new Size(113, 113);
        }

        private void panelBuscarPorDatos_MouseLeave(object sender, EventArgs e)
        {
            panelBuscarPorDatos.Size = new Size(110, 110);
        }

        private void panelBuscarCategoria_MouseHover(object sender, EventArgs e)
        {
            panelBuscarCategoria.Size = new Size(113, 92);
        }

        private void panelBuscarCategoria_MouseLeave(object sender, EventArgs e)
        {
            panelBuscarCategoria.Size = new Size(110, 89);
        }

        private void panelVolver_MouseHover(object sender, EventArgs e)
        {
            panelVolver.Size = new Size(53, 49);
        }

        private void panelVolver_MouseLeave(object sender, EventArgs e)
        {
            panelVolver.Size = new Size(50, 46);
        }

        private void panelVolver_MouseClick(object sender, MouseEventArgs e)
        {
            Form1 form1 = Application.OpenForms["Form1"] as Form1;

            if (form1 != null)
            {
                form1.Show();
            }
            this.Close();
        }

        private void panelBuscarPorDatos_MouseClick(object sender, MouseEventArgs e)
        {
            //Este debe hide el panel actual y debe ir al panel de buscar contactos
            BuscarContacto buscarContacto = new BuscarContacto();
            buscarContacto.Show(); 
            this.Hide();
        }

        private void panelBuscarCategoria_MouseClick(object sender, MouseEventArgs e)
        {
            //Este debe hide el panel actual y debe ir al panel de buscar por categoria
            BuscarCategoria buscarCategoria = new BuscarCategoria();
            buscarCategoria.Show();
            this.Hide();
        }
    }
}
