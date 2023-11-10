﻿using Logica;
using Logica.Clases;
using System.ComponentModel;


namespace FrontEnd
{
    public partial class AltaAdmin : Form
    {
        private Form formularioPrevio;
        public AltaAdmin(Form formularioPrevio)
        {
            InitializeComponent();
            this.formularioPrevio = formularioPrevio;
        }

        Principal principal = new Principal();
        ListaAdmi ListaAdmi = new ListaAdmi();

        // ALTA NUEVO ADMIN
        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                var confirmacion = MessageBox.Show($"Seguro que desea agregar un nuevo Administrador con los siguientes datos?\n\n" +
                $" Nombre: {txtNombre.Text}\nApellido: {txtApellido.Text}\nDNI: {txtDNI.Text}\nTelefono: {txtTel.Text}\nUsuario: {txtUser.Text}", "ATENCION",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (confirmacion == DialogResult.OK)
                {
                    principal.AltaAdmi(txtNombre.Text, txtApellido.Text, txtDNI.Text, txtTel.Text, txtUser.Text, txtContra.Text, txtConfirContra.Text);
                    MessageBox.Show($"El  Administrador {txtNombre.Text} {txtApellido.Text} ha sido creado con exito!", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtNombre.Clear();
                    txtApellido.Clear();
                    txtDNI.Clear();
                    txtTel.Clear();
                    txtUser.Clear();
                    txtContra.Clear();
                    txtConfirContra.Clear();
                }
                else
                {
                    var confirmarCancelar = MessageBox.Show("Seguro desea cancelar la operacion? ", "ATENCION!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (confirmarCancelar == DialogResult.OK)
                    {
                        txtNombre.Clear();
                        txtApellido.Clear();
                        txtDNI.Clear();
                        txtTel.Clear();
                        txtUser.Clear();
                        txtContra.Clear();
                        txtConfirContra.Clear();
                    }
                }

            }
            catch (Exception camposIncompletos)
            {
                // Manejar la excepción de campos incompletos
                MessageBox.Show("Error: " + camposIncompletos.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }


        // VOLVER
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            formularioPrevio.Show();
            this.Hide();
        }


        // Mostrar la contrasenia
        private void checkBoXMostrarContra_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBoXMostrarContra.Checked == true)
            {
                txtContra.PasswordChar = '\0';
                txtConfirContra.PasswordChar = '\0';
            }
            else
            {
                txtContra.PasswordChar = '*';
                txtConfirContra.PasswordChar = '*';
            }

        }

        private void AltaAdmin_FormClosing(object sender, FormClosingEventArgs e)
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

        private void AltaAdmin_Load(object sender, EventArgs e)
        {

        }
    }

}
