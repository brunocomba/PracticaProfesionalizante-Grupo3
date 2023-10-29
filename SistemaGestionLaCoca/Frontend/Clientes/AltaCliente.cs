using Logica;
using Logica.Clases;

namespace Frontend
{
    public partial class AltaCliente : Form
    {
        private Form formPrevio;
        public AltaCliente(Form formPrevio)
        {
            InitializeComponent();
            this.formPrevio = formPrevio;
        }

        Principal principal = new Principal();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                var confirmacion = MessageBox.Show($"Seguro que desea agregar este nuevo cliente?\n" +
                $" Nombre: {txtNombre.Text}\n Apellido: {txtApellido.Text}\nDNI: {txtDNI.Text}\nTelefono: {txtTel.Text}", "Atencion", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (confirmacion == DialogResult.OK)
                {
                    principal.AltaCliente(txtNombre.Text, txtApellido.Text, txtDNI.Text, txtTel.Text);
                    MessageBox.Show($"El cliente {txtNombre.Text} {txtApellido.Text} fue agregado con exito!", "LISTO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtNombre.Clear();
                    txtApellido.Clear();
                    txtDNI.Clear();
                    txtTel.Clear();
                }
                else
                {
                    var confirmarCancelacion = MessageBox.Show($"Seguro que desea cancelar la operacion?", "Atencion", MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Warning);
                    if (confirmarCancelacion == DialogResult.OK)
                    {
                        txtNombre.Clear();
                        txtApellido.Clear();
                        txtDNI.Clear();
                        txtTel.Clear();
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
            this.Hide();
            formPrevio.Show();
        }

        private void AltaCliente_Load(object sender, EventArgs e)
        {

        }

        private void AltaCliente_FormClosing(object sender, FormClosingEventArgs e)
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
