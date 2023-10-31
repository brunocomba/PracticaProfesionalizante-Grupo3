using FrontEnd;
using Logica;
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
            dgvClientes.DataSource = principal.ObtenerListClientes();


            toolTip1.SetToolTip(btnAgregar, "Crear nuevo cliente.");
            toolTip1.SetToolTip(btnMod, "Modificar un cliente.");
            toolTip1.SetToolTip(btnDelete, "Eliminar un cliente.");
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
                var confirmacion = MessageBox.Show($"Seguro que desea eliminar el cliente {cliente_Elegido}", "ADVERTENCIA", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

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



        private void ListaClientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            ApplicationDbContex context = new ApplicationDbContex();

            // Preguntar si desea cerrar el programa o no.
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Administrador admActual = principal.BuscarAdmLogueado();
                var rta = MessageBox.Show("¿Seguro que deseas salir?", "Confirmar salida ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (rta == DialogResult.OK)
                {

                    Application.Exit();

                    // Cambiarle al administrador que esta logueado (actual) la propiedad Logueado a NO.
                    admActual.Logueado = Administrador.SioNo.NO;
                    context.Administradores.Update(admActual);
                    context.SaveChanges();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
