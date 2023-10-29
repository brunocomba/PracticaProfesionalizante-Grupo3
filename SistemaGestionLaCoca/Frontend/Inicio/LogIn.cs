﻿
using Logica.Clases;
using Microsoft.VisualBasic.ApplicationServices;

namespace FrontEnd
{
    public partial class LogIn : Form
    {
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

        MenuInicio menuInicio = new MenuInicio();

        //INICIO DE SESION..
        private void btnContinuar_Click(object sender, EventArgs e)
        {
            // valor ingresados por pantalla
            string user = txtUsuario.Text;
            string password = txtContrasenia.Text;
            try
            {
                bool resultado = principal.LogIn(user, password);

                if (resultado == true)
                {
                    
                    MessageBox.Show($"Inicio de sesion exitoso.\n!Bienvenido, {user}!", "Inicio de Sesion", MessageBoxButtons.OK, MessageBoxIcon.Information);                  
                    menuInicio.Show();
                    this.Hide();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

