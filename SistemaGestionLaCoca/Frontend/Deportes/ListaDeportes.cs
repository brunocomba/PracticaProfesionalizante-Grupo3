using Logica;
using Logica.Clases;

namespace Frontend.Deportes
{
    public partial class ListaDeportes : Form
    {
        public ListaDeportes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        Principal principal = new Principal();
        private void ListaDeportes_Load(object sender, EventArgs e)
        {
            dgvDeportes.DataSource = principal.ObtenerListaDeportes();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AltaDeporte altaDeporte = new AltaDeporte(this);
            altaDeporte.Show();
            this.Hide();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Deporte deporteElegido = (Deporte)dgvDeportes.CurrentRow.DataBoundItem;

            try
            {
                if (dgvDeportes.Rows.Count > 0)
                {


                    var confirmacion = MessageBox.Show($"Seguro que desea eliminar el deporte: {deporteElegido.Name}  del sistema? ", "ADVERTENCIA", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                    if (confirmacion == DialogResult.OK)
                    {
                        principal.removeDeporte(deporteElegido);

                        dgvDeportes.DataSource = null;
                        dgvDeportes.DataSource = principal.ObtenerListaDeportes();
                    }
                }
                else
                {
                    MessageBox.Show("No hay deportes registrados para eliminar.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }
            catch (Exception camposIncompletos)
            {
                MessageBox.Show("Error: " + camposIncompletos.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void ListaDeportes_FormClosing(object sender, FormClosingEventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            ListaCanchas listaCanchas = new ListaCanchas();
            listaCanchas.Show();
            this.Hide();
        }
    }
}
