using Logica;
using Logica.Clases;


namespace Frontend.Deportes
{
    public partial class AltaDeporte : Form
    {
        public AltaDeporte(Form formPrevio)
        {
            this.formPrevio = formPrevio;
            InitializeComponent();
        }

        private Form formPrevio;
        Principal principal = new Principal();

        private void btnAddDeporte_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                var confirmacion = MessageBox.Show($"Seguro que desea agregar este nuevo deporte?\n" +
                $" Nombre: {txtNombre.Text}\n Cantidad de jugadores: {txtCantJugadores.Text}", "Atencion", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (confirmacion == DialogResult.OK)
                {
                    principal.altaDeporte(txtNombre.Text, txtCantJugadores.Text);
                    MessageBox.Show($"El deporte: {txtNombre.Text}  fue agregado con exito al sistema.", "LISTO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtNombre.Clear();
                    txtCantJugadores.Clear();

                }
                else
                {
                    var confirmarCancelacion = MessageBox.Show($"Seguro que desea cancelar la operacion?", "Atencion", MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Warning);
                    if (confirmarCancelacion == DialogResult.OK)
                    {
                        txtNombre.Clear();

                    }
                }
            }
            catch (Exception camposIncompletos)
            {
                MessageBox.Show("Error: " + camposIncompletos.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            formPrevio.Show();
            this.Hide();
        }

        private void AltaDeporte_Load(object sender, EventArgs e)
        {

        }

        private void AltaDeporte_FormClosing(object sender, FormClosingEventArgs e)
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

