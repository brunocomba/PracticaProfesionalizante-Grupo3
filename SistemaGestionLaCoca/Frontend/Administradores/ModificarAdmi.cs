using FrontEnd;
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

        //------------------------------------ MOSTRAR INFORMACION DEL OBJETO SE
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



        // VERIFICAR SI LAS CONTRASENIAS COINCIDEN



        //VALIDACIONES.

        private void txtContra_Validated_1(object sender, EventArgs e)
        {
            bool verificacion = principal.CumpleRequisitos(txtContra.Text);

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

        private void txtConfirPass_Validated_1(object sender, EventArgs e)
        {
            string password = txtContra.Text;
            string confirPassword = txtConfirPass.Text;

            if (principal.confirmarPass(password, confirPassword) == false)
            {
                lblErrorPass.Text = "Las contraseñas no coinciden";
                btnModificar.Enabled = false;
            }
            else
            {
                lblErrorPass.Text = "";
                btnModificar.Enabled = true;

            }


        }
    }
}
