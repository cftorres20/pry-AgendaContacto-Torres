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
    public partial class BuscarContacto : Form
    {
        public BuscarContacto()
        {
            InitializeComponent();
        }
        private void BuscarContacto_Load(object sender, EventArgs e)
        {
            cargarTreeView(); 
        }

        private void cargarTreeView()
        {
            DBConexion db = new DBConexion();
            List<Dictionary<string, object>> listaContactos = db.obtenerDatos();

            Dictionary<string, TreeNode> categoriasNodos = new Dictionary<string, TreeNode>();

            foreach (var contacto in listaContactos)
            {
                string categoria = contacto["categoria"].ToString();
                string apellido = contacto["apellido"].ToString();
                string nombre = contacto["nombre"].ToString();
                string telefono = contacto["telefono"].ToString();
                string correo = contacto["correo"].ToString();

                if (!categoriasNodos.ContainsKey(categoria))
                {
                    TreeNode categoriaNodo = new TreeNode(categoria);
                    categoriasNodos.Add(categoria, categoriaNodo);
                    treeViewContactos.Nodes.Add(categoriaNodo);
                }

                // Crea un nodo para el apellido
                TreeNode apellidoNodo = new TreeNode(apellido);
                categoriasNodos[categoria].Nodes.Add(apellidoNodo);

                // Subnodos para nombre, teléfono y correo
                apellidoNodo.Nodes.Add(new TreeNode("Nombre: " + nombre));
                apellidoNodo.Nodes.Add(new TreeNode("Teléfono: " + telefono));
                apellidoNodo.Nodes.Add(new TreeNode("Correo: " + correo));

            }

        }

        private void panelSalir_MouseHover(object sender, EventArgs e)
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
