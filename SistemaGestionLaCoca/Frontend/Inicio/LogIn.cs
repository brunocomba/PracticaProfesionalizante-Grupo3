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
    public partial class LogIn : Form
    {
        Principal principal = new Principal();
        private string userRegistrado;
        private string passRegistrada;
        private string password;
        private string user;
        private int cantIntentos = 5;
        private int contador;
        MenuInicio menuInicio = new MenuInicio();
        public LogIn()
        {
            InitializeComponent();
        }




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
            user = txtUsuario.Text;
            password = txtContrasenia.Text;

            bool inicioSesionExitoso = false;
            /*
            foreach (var admGuardado in Principal.ObtenerAdministradores())
            {
                if (admGuardado.Usuario == user && admGuardado.Contrasenia == password)
                {
                    inicioSesionExitoso = true;
                    break;
                }
            }
            */
            if (inicioSesionExitoso)
            {
                MessageBox.Show("Inicio de sesión exitoso. ¡Bienvenido, " + user + "!");
                menuInicio.Show();
                this.Hide();
            }
            else
            {

                do
                {
                    contador = contador + 1;
                    int total = cantIntentos - contador;
                    MessageBox.Show($"Nombre de usuario o contraseña incorrectos. Por favor, inténtalo de nuevo.\n Intentos restantes: {total}", "ATENCION!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtContrasenia.Text = "";
                    txtUsuario.Text = "";

                    if (total == 0)
                    {
                        MessageBox.Show($"Usuario bloqueado\n Cantidad de intentos fallidos agotada.", "ATENCION!.",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtContrasenia.Text = "";
                        txtUsuario.Text = "";
                    }

                } while (user.Equals(userRegistrado) && password.Equals(passRegistrada));
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

        }
    }

}

