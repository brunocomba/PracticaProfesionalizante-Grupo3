using Frontend;
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

namespace FrontEnd
{
    public partial class ListaAdmi : Form
    {
        public ListaAdmi()
        {
            InitializeComponent();
        }
        Principal principal = new Principal();
        private void ListaAdmi_Load(object sender, EventArgs e)
        {
            dgvAdministradores.DataSource = null;
            dgvAdministradores.DataSource = Principal.ObtenerAdministradores();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MenuInicio menuInicio = new MenuInicio();
            menuInicio.Show();
            this.Hide();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AltaAdmin altaAdmin = new AltaAdmin(this);
            altaAdmin.Show();
            this.Hide();
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {

            ModificarAdmi modAdmi = new ModificarAdmi();

            Administrador admi_Elegido = (Administrador)dgvAdministradores.CurrentRow.DataBoundItem;
            modAdmi.ModificarAdmin(admi_Elegido);
            modAdmi.Show();
            this.Hide();

            dgvAdministradores.DataSource = null; // Eliminar el origen de datos actual
            dgvAdministradores.DataSource = Principal.ObtenerAdministradores(); // Asignar la lista actualizada
            dgvAdministradores.Refresh();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            //MIRO EL ID SELECCIONADO EN LA GRILLA.

            Administrador valor_Elegido = (Administrador)dgvAdministradores.CurrentRow.DataBoundItem;

            if (valor_Elegido != null)
            {
                var confirmacion = MessageBox.Show("Seguro que desea eliminar este administrador, con el DNI " + valor_Elegido.dni, "ADVERTENCIA", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (confirmacion == DialogResult.OK)
                {
                    principal.removeAdmin(valor_Elegido);
                }
            }
            else
            {
                MessageBox.Show("No hay ningun cliente seleccionado");
            }

            dgvAdministradores.DataSource = null;
            dgvAdministradores.DataSource = Principal.ObtenerAdministradores();

        }
    }
}
