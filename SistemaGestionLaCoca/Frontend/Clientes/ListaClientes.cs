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


        private void ListaClientes_Load(object sender, EventArgs e)
        {
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = principal.ObtenerListClientes();

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MenuInicio menuInicio = new MenuInicio();
            menuInicio.Show();
            this.Hide();
        }


        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            AltaCliente altaCliente = new AltaCliente(this);
            altaCliente.Show();
            this.Hide();
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            ModificarCliente modCliente = new ModificarCliente();
            if (dgvClientes.Rows.Count > 0)
            {
                // convertir a objeto cliente la fila seleccionada en la grilla
                Cliente cliente_Elegido = (Cliente)dgvClientes.CurrentRow.DataBoundItem;
                // pasarle el cliente elegido en bla grilla al metodo del formulario de modificacion para que lo utilice
                modCliente.ModificaCliente(cliente_Elegido);
                modCliente.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No hay clientes registrados para realizar una modificacion.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dgvClientes.DataSource = null; // Eliminar el origen de datos actual
            dgvClientes.DataSource = principal.ObtenerListClientes(); // Asignar la lista actualizada
            dgvClientes.Refresh();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // CONVERTIR A OBJETO TIPO CLIENTE LA FILA ELEGIDA EN LA GRILLA.


            if (dgvClientes.Rows.Count > 0)
            {
                Cliente cliente_Elegido = (Cliente)dgvClientes.CurrentRow.DataBoundItem;
                var confirmacion = MessageBox.Show("Seguro que desea eliminar este cliente, con el DNI " + cliente_Elegido.DNI, "ADVERTENCIA", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (confirmacion == DialogResult.OK)
                {
                    principal.removeCliente(cliente_Elegido);
                }
            }
            else
            {
                MessageBox.Show("No hay clientes registrados para eliminar.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




            dgvClientes.DataSource = null;
            dgvClientes.DataSource = principal.ObtenerListaAdmi();
        }
    }
}
