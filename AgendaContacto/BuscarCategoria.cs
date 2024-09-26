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
    public partial class BuscarCategoria : Form
    {
        public BuscarCategoria()
        {
            InitializeComponent();
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
            Busquedas formBusquedas = Application.OpenForms["Busquedas"] as Busquedas;
            if (formBusquedas != null)
            {
                formBusquedas.Show();
            }
            this.Close();
        }
    }
}
