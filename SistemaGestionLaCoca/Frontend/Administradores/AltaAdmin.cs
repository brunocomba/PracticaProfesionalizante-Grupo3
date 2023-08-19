using Logica.Clases;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FrontEnd
{
    public partial class AltaAdmin : Form
    {
        public AltaAdmin()
        {
            InitializeComponent();
        }

        ListaAdmi ListaAdmi = new ListaAdmi();

        LogIn logIn = new LogIn();


        // ALTA NUEVO ADMIN
        private void btnCrear_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            if (LogIn.formEnQueEstoy == true)
            {
                var SIoNo = MessageBox.Show("Cuenta Administrador generada con exito! " + " Haga click en ACEPTAR para continuar", "Crear nuevo usuario Administrador.",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (SIoNo == DialogResult.OK)
                {
                    principal.altaAdmin(txtNombre.Text, txtApellido.Text, int.Parse(txtDni.Text),
                    uint.Parse(txtTel.Text), txtUser.Text, txtContra.Text);

                    logIn.Show();
                    this.Hide();
                }
                else
                {
                    var confirmarCancel = MessageBox.Show("¿Seguro desea cancelar la creacion?", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (confirmarCancel == DialogResult.Yes)
                    {
                        txtNombre.Text = "";
                        txtApellido.Text = "";
                        txtDni.Text = "";
                        txtTel.Text = "";
                        txtUser.Text = "";
                        txtContra.Text = "";
                    }
                }
            }
            else
            {
                var SIoNo = MessageBox.Show("Cuenta Administrador generada con exito! " + " Haga click en ACEPTAR para continuar", "Crear nuevo usuario Administrador.",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (SIoNo == DialogResult.OK)
                {
                    principal.altaAdmin(txtNombre.Text, txtApellido.Text, int.Parse(txtDni.Text),
                    uint.Parse(txtTel.Text), txtUser.Text, txtContra.Text);
                    ListaAdmi.Show();
                    this.Hide();
                }
                else
                {
                    var confirmarCancel = MessageBox.Show("¿Seguro desea cancelar la creacion?", "ATENCION", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Exclamation);
                    if (confirmarCancel == DialogResult.Yes)
                    {
                        txtNombre.Text = "";
                        txtApellido.Text = "";
                        txtDni.Text = "";
                        txtTel.Text = "";
                        txtUser.Text = "";
                        txtContra.Text = "";
                    }
                }
            }




        }

        // VOLVER
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (LogIn.formEnQueEstoy == false)
            {
                ListaAdmi.Show();
                this.Hide();

            }
            else
            {
                logIn.Show();
                this.Hide();
            }

        }

        // VERIFICAR SI LAS CONTRASENIAS COINCIDEN
        private void txtConfirPass_TextChanged(object sender, EventArgs e)
        {
            string password = txtContra.Text;
            string confirPassword = txtConfirPass.Text;

            if (password == confirPassword)
            {
                lblErrorPass.Text = "";
                btnCrear.Enabled = true;
            }
            if (password != confirPassword)
            {
                lblErrorPass.Text = "Las contraseñas no coinciden";
                btnCrear.Enabled = false;
            }
        }

        // Verificar si la contrasenia ingresada contiene al menos una letra mayúscula y al menos un número
        private bool CumpleRequisitos(string contra)
        {
            bool tieneMayuscula = Regex.IsMatch(contra, @"[A-Z]");
            bool tieneNumero = Regex.IsMatch(contra, @"\d");

            return tieneMayuscula && tieneNumero; //si ambas se cumplen devuelve true, de lo contrario false
        }
        private void txtContra_Validating(object sender, CancelEventArgs e)
        {
            bool verificacion = CumpleRequisitos(txtContra.Text);

            if (verificacion == false)
            {
                errorProviderPass.SetError(txtContra, "La contraseña debe contener como minimo una MAYUSCULA y un NUMERO");
                txtContra.SelectAll();
                btnCrear.Enabled = false;
            }
            else
            {
                errorProviderPass.SetError(txtContra, "");
            }
        }

        // VALIDACIONES
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96)
                   || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("No se puede introducir numeros, solo LETRAS.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                e.Handled = true;
                return;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96)
                  || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("No se puede introducir numeros, solo LETRAS.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                e.Handled = true;
                return;
            }
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("No se puede introducir letras, solo NUMEROS.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                e.Handled = true;
                return;
            }
        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("No se puede introducir letras, solo NUMEROS.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                e.Handled = true;
                return;
            }
        }


        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "ej: Jose")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.Black;
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "ej: Jose";
                txtNombre.ForeColor = Color.Silver;
            }
        }

        private void txtApellido_Enter(object sender, EventArgs e)
        {
            if (txtApellido.Text == "ej: Perez")
            {
                txtApellido.Text = "";
                txtApellido.ForeColor = Color.Black;
            }
        }

        private void txtApellido_Leave(object sender, EventArgs e)
        {
            if (txtApellido.Text == "")
            {
                txtApellido.Text = "ej: Perez";
                txtApellido.ForeColor = Color.Silver;
            }
        }

        private void txtDni_Enter(object sender, EventArgs e)
        {
            if (txtDni.Text == "ej: 45333456")
            {
                txtDni.Text = "";
                txtDni.ForeColor = Color.Black;
            }

        }

        private void txtDni_Leave(object sender, EventArgs e)
        {
            if (txtDni.Text == "")
            {
                txtDni.Text = "ej: 45333456";
                txtDni.ForeColor = Color.Silver;
            }

        }

        private void txtTel_Enter(object sender, EventArgs e)
        {
            if (txtTel.Text == "cod area + numero sin el 15")
            {
                txtTel.Text = "";
                txtTel.ForeColor = Color.Black;
            }
        }

        private void txtTel_Leave(object sender, EventArgs e)
        {
            if (txtTel.Text == "")
            {
                txtTel.Text = "cod area + numero sin el 15";
                txtTel.ForeColor = Color.Silver;
            }
        }
        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "joseperezz23")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.Black;
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "joseperezz23";
                txtUser.ForeColor = Color.Silver;
            }
        }
        private void txtTel_TextChanged(object sender, EventArgs e)
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
                btnCrear.Enabled = false;

            }
            else
            {
                lblErrorDni.Text = "";
                btnCrear.Enabled = true;
            }
        }
    }

}
