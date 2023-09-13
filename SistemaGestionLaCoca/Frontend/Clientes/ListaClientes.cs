using FrontEnd;
using Logica.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frontend
{
    public partial class ListaClientes : Form
    {
        public ListaClientes()
        {
            InitializeComponent();
        }
        Principal principal = new Principal();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AltaCliente altaCliente = new AltaCliente(this);
            altaCliente.Show();
            this.Hide();
        }

        private void ListaClientes_Load(object sender, EventArgs e)
        {
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = Principal.ObtenerClientes();

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MenuInicio menuInicio = new MenuInicio();
            menuInicio.Show();
            this.Hide();
        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarCliente modCliente = new ModificarCliente();
            Cliente cliente_Elegido = (Cliente)dgvClientes.CurrentRow.DataBoundItem;
            modCliente.ModificaCliente(cliente_Elegido);
            modCliente.Show();
            this.Hide();

            dgvClientes.DataSource = null; // Eliminar el origen de datos actual
            //dgvClientes.DataSource = Principal.ObtenerAdministradores(); // Asignar la lista actualizada
            dgvClientes.Refresh();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //MIRO EL ID SELECCIONADO EN LA GRILLA
            object DniElegido = this.dgvClientes.SelectedCells[0].Value;
            int DniSeleccionado = (int)DniElegido;

            Cliente valor_Elegido = (Cliente)dgvClientes.CurrentRow.DataBoundItem;

            if (valor_Elegido != null)
            {
                var confirmacion = MessageBox.Show("Seguro que desea eliminar este cliente con el DNI" + DniSeleccionado, "ADVERTENCIA", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (confirmacion == DialogResult.OK)
                {
                    principal.removeCliente(valor_Elegido);
                }

            }
            else
            {
                MessageBox.Show("No hay ningun cliente seleccionado");
            }

            dgvClientes.DataSource = null;

            dgvClientes.DataSource = Principal.ObtenerClientes();
        }

    }
}
