using Frontend.Elementos_Cancha;
using FrontEnd;
using Logica;
using Logica.Clases;


namespace Frontend
{
    public partial class ListaCanchas : Form
    {
        public ListaCanchas()
        {
            InitializeComponent();
        }

        Principal principal = new Principal();

        private void ListaCanchas_Load(object sender, EventArgs e)
        {
            dgvCanchas.DataSource = null;
            dgvCanchas.DataSource = principal.ObtenerListaCanchas();


            toolTip1.SetToolTip(btnAgregarCancha, "Crear nueva cancha.");
            toolTip1.SetToolTip(btnModCancha, "Modificar una cancha.");
            toolTip1.SetToolTip(btnEliminarCancha, "Eliminar una cancha.");

        }

        private void btnAgregarCancha_Click(object sender, EventArgs e)
        {
            AltaCanchas altaCanchas = new AltaCanchas(this);
            altaCanchas.Show();
            this.Hide();
        }

        private void btnModCancha_Click(object sender, EventArgs e)
        {

            ModificarCancha modCancha = new ModificarCancha();

            if (dgvCanchas.Rows.Count > 0)
            {
                modCancha.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No hay clientes registrados para realizar una modificacion.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dgvCanchas.DataSource = null; // Eliminar el origen de datos actual
            dgvCanchas.DataSource = principal.ObtenerListaCanchas(); // Asignar la lista actualizada
            dgvCanchas.Refresh();
        }

        private void btnEliminarCancha_Click(object sender, EventArgs e)
        {
            //MIRO EL ID SELECCIONADO EN LA GRILLA
            object CanchaElegida = this.dgvCanchas.SelectedCells[0].Value;
            int IdSeleccionado = (int)CanchaElegida;

            Cancha valor_Elegido = (Cancha)dgvCanchas.CurrentRow.DataBoundItem;

            if (valor_Elegido != null)
            {
                var confirmacion = MessageBox.Show("Seguro que desea eliminar esta cancha con el ID" + IdSeleccionado, "ADVERTENCIA", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (confirmacion == DialogResult.OK)
                {
                    principal.removeCancha(valor_Elegido);
                    MessageBox.Show("Cancha eliminada con exito.", "Sistema");

                    //Ajustar los id para tener una secuencia de IDs.
                    //IDCancha.AdjustIDs(Principal.ObtenerCanchas());

                }

                if (confirmacion == DialogResult.Cancel)
                {
                    MessageBox.Show("Se cancelo la eliminacion de la cancha con el ID " + IdSeleccionado);
                }

            }
            else
            {
                MessageBox.Show("No hay ningun cliente seleccionado");
            }

            dgvCanchas.DataSource = null;

            dgvCanchas.DataSource = principal.ObtenerListaCanchas();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MenuInicio menuInicio = new MenuInicio();
            menuInicio.Show();
            this.Hide();
        }



        private void btnElementosDeCancha_Click(object sender, EventArgs e)
        {
            ListaElementosCancha listaElementosCancha = new ListaElementosCancha();
            listaElementosCancha.Show();
            this.Hide();
        }

        private void ListaCanchas_FormClosing(object sender, FormClosingEventArgs e)
        {
            ApplicationDbContex context = new ApplicationDbContex();

            // Preguntar si desea cerrar el programa o no.
            if (e.CloseReason == CloseReason.UserClosing)
            {
                var rta = MessageBox.Show("¿Seguro que deseas salir?", "Confirmar salida ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (rta == DialogResult.OK)
                {

                    Application.Exit();

                    // Cambiarle al administrador que esta logueado (actual) la propiedad Logueado a NO.
                    Administrador.admLogueado.Logueado = Administrador.SioNo.NO;
                    context.Administradores.Update(Administrador.admLogueado);
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
