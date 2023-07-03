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
    public partial class AltaAdmin : Form
    {
        public AltaAdmin()
        {
            InitializeComponent();
        }

        private void AltaAdmin_Load(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();

            var SIoNo = MessageBox.Show("Cuenta Administrador generada con exito! " + " Haga click en ACEPTAR para continuar", "Crear nuevo usuario Administrador.",
                MessageBoxButtons.OKCancel);

            if (SIoNo == DialogResult.OK)
            {
                principal.altaAdmin(txtNombre.Text, txtApellido.Text, int.Parse(txtDni.Text),
                int.Parse(txtTel.Text), txtUser.Text, txtContra.Text);
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

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Show();
            this.Hide();
        }

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
    }
}
