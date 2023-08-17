using FrontEnd;
using LogicaClases.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public void ModificarAdmin(Administrador admin)
        {
            adminQueEdito = admin;
            txtNombre.Text = adminQueEdito.nombre;
            txtApellido.Text = adminQueEdito.apellido;
            txtDni.Text = adminQueEdito.dni.ToString();
            txtTel.Text = adminQueEdito.telefono.ToString();
            txtUser.Text = adminQueEdito.usuario.ToString();
            txtContra.Text = adminQueEdito.contrasenia.ToString();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            var SIoNO = MessageBox.Show("Seguro desea realizar esta modificacion? ", "ATENCION!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (SIoNO == DialogResult.OK)
            {
                principal.modificarAdmin(adminQueEdito, txtNombre.Text, txtApellido.Text, int.Parse(txtDni.Text),
                uint.Parse(txtTel.Text), txtUser.Text, txtContra.Text);

                MessageBox.Show("Administrador modificado con exito!");
                ListaAdmi.Show();
                this.Hide();
            }
            else
            {
                ListaAdmi.Show();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListaAdmi.Show();
            this.Hide();

        }




        // Verificar si la contrasenia ingresada contiene al menos una letra mayúscula y al menos un número
        private bool CumpleRequisitos(string contra)
        {
            bool tieneMayuscula = Regex.IsMatch(contra, @"[A-Z]");
            bool tieneNumero = Regex.IsMatch(contra, @"\d");

            return tieneMayuscula && tieneNumero; //si ambas se cumplen devuelve true, de lo contrario false
        }
        private void txtContra_Validating_1(object sender, CancelEventArgs e)
        {
            bool verificacion = CumpleRequisitos(txtContra.Text);

            if (verificacion == false)
            {
                errorProviderPass.SetError(txtContra, "La contraseña debe contener como minimo una MAYUSCULA y un NUMERO");
                txtContra.SelectAll();
                btnModificar.Enabled = false;
            }
            else
            {
                errorProviderPass.SetError(txtContra, "");
            }
        }

        // VERIFICAR SI LAS CONTRASENIAS COINCIDEN
        private void txtConfirPass_TextChanged_1(object sender, EventArgs e)
        {
            string password = txtContra.Text;
            string confirPassword = txtConfirPass.Text;

            if (password == confirPassword)
            {
                lblPassError.Text = "";
                btnModificar.Enabled = true;
            }
            if (password != confirPassword)
            {
                lblPassError.Text = "Las contraseñas no coinciden";
                btnModificar.Enabled = false;
            }
        }


        //VALIDACIONES
        private void txtNombre_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96)
                  || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("No se puede introducir numeros, solo LETRAS.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                e.Handled = true;
                return;
            }
        }

        private void txtApellido_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96)
                  || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("No se puede introducir numeros, solo LETRAS.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                e.Handled = true;
                return;
            }
        }

        private void txtDni_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("No se puede introducir letras, solo NUMEROS.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                e.Handled = true;
                return;
            }
        }

        private void txtTel_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("No se puede introducir letras, solo NUMEROS.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                e.Handled = true;
                return;
            }
        }

        private void txtTel_TextChanged_1(object sender, EventArgs e)
        {
            int minLength = 10; // Número mínimo de caracteres permitidos

            if (txtTel.Text.Length < minLength)
            {
                lblErrorTel.Text = "Numero telefonico incompleto";

                // El texto tiene menos caracteres que el mínimo requerido
                // Aquí puedes mostrar un mensaje de error o tomar alguna acción
            }
            else
            {
                lblErrorTel.Text = "";

            }
        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            int minLength = 8; // Número mínimo de caracteres permitidos

            if (txtDni.Text.Length < minLength)
            {
                lblErrorDni.Text = "DNI incompleto";
                btnModificar.Enabled = false;

            }
            else
            {
                lblErrorDni.Text = "";
                btnModificar.Enabled = true;
            }
        }
    }
}
