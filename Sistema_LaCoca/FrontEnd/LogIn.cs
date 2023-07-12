using LogicaClases.Clases;
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
            AltaAdmin altaAdminForm = new AltaAdmin();
            altaAdminForm.Show();
            this.Hide();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            // valor ingresados por pantalla
            user = txtUsuario.Text;
            password = txtContrasenia.Text;




            foreach (Administrador admi in Principal.ObtenerAdministradores())
            {
                userRegistrado = admi.usuario;
                passRegistrada = admi.contrasenia;
            }

            if (user == userRegistrado && password == passRegistrada)
            {
                MessageBox.Show("Inicio de sesion exitoso!");
                menuInicio.Show();
                this.Hide();
            }
            else
            {
                do
                {
                    contador = contador + 1;
                    int total = cantIntentos - contador;
                    MessageBox.Show($"Contraseña o usuario incorrectos\n Intentos restantes: {total}");
                    txtContrasenia.Text = "";
                    txtUsuario.Text = "";

                    if (total == 0)
                    {
                        MessageBox.Show($"Usuario bloqueado\n Cantidad de intentos fallidos agotada.", "Atencion.");
                        txtContrasenia.Text = "";
                        txtUsuario.Text = "";
                    }

                }
                while (user.Equals(userRegistrado) && password.Equals(passRegistrada));

            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }
    }

}

