using FrontEnd;
using Logica;
using Logica.Clases;
using System.ComponentModel;

namespace Frontend
{
    public partial class ModificarAdmi : Form
    {
        public ModificarAdmi()
        {
            InitializeComponent();
        }

        Principal principal = new Principal();
        ListaAdmi ListaAdmi = new ListaAdmi();

        private Administrador adminQueEdito;

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                var SIoNO = MessageBox.Show($"Seguro desea realizar esta modificacion?\n\n{adminQueEdito.Nombre} por {txtNombre.Text}\n{adminQueEdito.Apellido} por {txtApellido.Text}\n{adminQueEdito.DNI} por  {txtDNI.Text}" +
                    $"\n{adminQueEdito.Telefono} por  {txtTel.Text}\n{adminQueEdito.Usuario} por {txtUser.Text}", "ATENCION!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (SIoNO == DialogResult.OK)
                {

                    principal.ModificarAdmin(adminQueEdito, txtNombre.Text, txtApellido.Text, txtDNI.Text, txtTel.Text, txtUser.Text, txtContra.Text, txtConfiContra.Text);
                    MessageBox.Show($"El Administrador ha sido modificado con exito! ", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtNombre.Clear();
                    txtApellido.Clear();
                    txtDNI.Clear();
                    txtTel.Clear();
                    txtUser.Clear();
                    txtContra.Clear();
                    txtConfirmPass.Clear();
                }
                else
                {
                    var confirmarCancelar = MessageBox.Show("Seguro desea cancelar la modificacion? ", "ATENCION!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (confirmarCancelar == DialogResult.OK)
                    {
                        txtNombre.Clear();
                        txtApellido.Clear();
                        txtDNI.Clear();
                        txtTel.Clear();
                        txtUser.Clear();
                        txtContra.Clear();
                        txtConfirmPass.Clear();
                    }
                }

            }
            catch (Exception camposIncompletos)
            {
                // Manejar la excepción de campos incompletos
                MessageBox.Show("Error: " + camposIncompletos.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        // mostrar la contra
        private void checkBoXMostrarContra_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBoXMostrarContra.Checked == true)
            {
                txtContra.PasswordChar = '\0';
                txtConfiContra.PasswordChar = '\0';
            }
            else
            {
                txtContra.PasswordChar = '*';
                txtConfiContra.PasswordChar = '*';
            }
        }

        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            ListaAdmi.Show();
            this.Hide();
        }

        private void ModificarAdmi_FormClosing(object sender, FormClosingEventArgs e)
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

        private void ModificarAdmi_Load(object sender, EventArgs e)
        {
            cmboxAdm.Items.AddRange(principal.ObtenerListaAdmi().ToArray());

        }

        private void cmboxAdm_SelectedIndexChanged(object sender, EventArgs e)
        {
            Administrador admiElegido = (Administrador)cmboxAdm.SelectedItem;

            adminQueEdito = admiElegido;
            txtNombre.Text = adminQueEdito.Nombre;
            txtApellido.Text = adminQueEdito.Apellido;
            txtDNI.Text = adminQueEdito.DNI.ToString();
            txtTel.Text = adminQueEdito.Telefono.ToString();
            txtUser.Text = adminQueEdito.Usuario.ToString();
            txtContra.Text = adminQueEdito.Contrasenia.ToString();
        }
    }
}
