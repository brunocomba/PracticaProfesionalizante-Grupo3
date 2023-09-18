using Frontend;
using Logica.Clases;

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
            dgvAdministradores.DataSource = principal.ObtenerListaAdmi();
            dgvAdministradores.Refresh();
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

            dgvAdministradores.DataSource = principal.ObtenerListaAdmi();
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            if (dgvAdministradores.Rows.Count > 0)
            {
                ModificarAdmi modAdmi = new ModificarAdmi();
                // CONVERTIR A OBJETO TIPO ADMINISTRADOR LA FILA ELEGIDA EN LA GRILLA.
                Administrador admi_Elegido = (Administrador)dgvAdministradores.CurrentRow.DataBoundItem;
                // PASARLE AL METODO DEL FORMULARIO DE MODIFICACION DICHO OBJETO SELECCIONADO.
                modAdmi.ModificarAdmin(admi_Elegido);
                // MOSTRAR EL FORMULARIO DE MODIFICACION.
                modAdmi.Show();
                this.Hide();
            }


            dgvAdministradores.DataSource = null; // Eliminar el origen de datos actual
            dgvAdministradores.DataSource = principal.ObtenerListaAdmi(); // Asignar la lista actualizada
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (dgvAdministradores.Rows.Count > 0)
            {
                // CONVERTIR A OBJETO TIPO ADMINISTRADOR LA FILA ELEGIDA EN LA GRILLA.
                Administrador admi_Elegido = (Administrador)dgvAdministradores.CurrentRow.DataBoundItem;
                var confirmacion = MessageBox.Show("Seguro que desea eliminar este administrador, con el DNI " + admi_Elegido.DNI, "ADVERTENCIA", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (confirmacion == DialogResult.OK)
                {
                    principal.RemoveAdmin(admi_Elegido);
                }
            }
            else
            {
                MessageBox.Show("No hay ningun cliente seleccionado");
            }


            dgvAdministradores.DataSource = null;
            dgvAdministradores.DataSource = principal.ObtenerListaAdmi();

        }
    }
}
