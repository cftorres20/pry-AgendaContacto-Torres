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
    public partial class GestionContacto : Form
    {
        public GestionContacto()
        {
            InitializeComponent();
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
