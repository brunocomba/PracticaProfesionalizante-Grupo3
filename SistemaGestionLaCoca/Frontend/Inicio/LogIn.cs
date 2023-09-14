
using Logica.Clases;

namespace FrontEnd
{
    public partial class LogIn : Form
    {
        MenuInicio menuInicio = new MenuInicio();
        public LogIn()
        {
            InitializeComponent();

        }

        Principal principal = new Principal();

        private void button1_Click(object sender, EventArgs e)
        {
            AltaAdmin altaAdminForm = new AltaAdmin(this);
            altaAdminForm.Show();
            this.Hide();
        }


        //INICIO DE SESION..
        private void btnContinuar_Click(object sender, EventArgs e)
        {
            // valor ingresados por pantalla
            string user = txtUsuario.Text;
            string password = txtContrasenia.Text;

            string LoQueDevuelve = principal.InicioDeSesion(user, password);

            if (LoQueDevuelve == $"Inicio de sesion exitoso.\n!Bienvenido, {user}! ")
            {
                MessageBox.Show(LoQueDevuelve, "Inicio de sesion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                menuInicio.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(LoQueDevuelve, "Inicio de sesion", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


        // MOSTRAR CONTRASENIA
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtContrasenia.PasswordChar = '\0';
            }
            else
            {
                txtContrasenia.PasswordChar = '*';
            }
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(iconoUsuario, "Usuario");
            toolTip1.SetToolTip(iconoPass, "Contraseña");

        }


    }

}

