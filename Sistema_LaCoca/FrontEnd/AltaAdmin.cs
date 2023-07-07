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

namespace FrontEnd
{
    public partial class AltaAdmin : Form
    {
        public AltaAdmin()
        {
            InitializeComponent();
        }

        private void AltaAdmin_Load(object sender, EventArgs e)
        {

        }
        // ALTA NUEVO ADMIN
        private void btnCrear_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();

            var SIoNo = MessageBox.Show("Cuenta Administrador generada con exito! " + " Haga click en ACEPTAR para continuar", "Crear nuevo usuario Administrador.",
                MessageBoxButtons.OKCancel);

            if (SIoNo == DialogResult.OK)
            {
                principal.altaAdmin(txtNombre.Text, txtApellido.Text, int.Parse(txtDni.Text),
                uint.Parse(txtTel.Text), txtUser.Text, txtContra.Text);
                LogIn logIn = new LogIn();
                logIn.Show();
                this.Hide();
            }
            else
            {
                var confirmarCancel = MessageBox.Show("¿Seguro desea cancelar la creacion?", "ATENCION", MessageBoxButtons.YesNo);
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

        // VOLVER
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Show();
            this.Hide();
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
            if (txtNombre.Text == "Intoduzca su nombre")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.Black;
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "Intoduzca su nombre";
                txtNombre.ForeColor = Color.Silver;
            }
        }

        private void txtApellido_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Intoduzca su apellido")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.Black;
            }
        }

        private void txtApellido_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "Intoduzca su apellido";
                txtNombre.ForeColor = Color.Silver;
            }
        }
    }
}
