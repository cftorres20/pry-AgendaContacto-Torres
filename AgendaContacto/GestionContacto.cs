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
            Form1 form1 = Application.OpenForms["Form1"] as Form1;

            if (form1 != null)
            {
                form1.Show();
            }
            this.Close();
        }
    }
}
