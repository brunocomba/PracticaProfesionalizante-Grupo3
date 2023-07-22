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

namespace Frontend
{
    public partial class AltaCliente : Form
    {
        public AltaCliente()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();

            var respuesta = MessageBox.Show($"El cliente {txtNombre.Text} {txtApellido.Text} fue agregado con EXITO!\n\nPresione SI para seguir agregando clientes\nSi desea terminar presione NO."
                , "Atencion", MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question);
            if (respuesta == DialogResult.No)
            {
                principal.ataCliente(txtNombre.Text, txtApellido.Text, int.Parse(txtDNI.Text), uint.Parse(txtTel.Text));
                ListaClientes listaClientes = new ListaClientes();
                listaClientes.Show();
                this.Hide();
            }
            if (respuesta == DialogResult.Yes)
            {
                principal.ataCliente(txtNombre.Text, txtApellido.Text, int.Parse(txtDNI.Text), uint.Parse(txtTel.Text));
                ListaClientes listaClientes = new ListaClientes();
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtDNI.Text = "";
                txtTel.Text = "";
            }
            if (respuesta == DialogResult.Cancel)
            {
                var confirmarCancel = MessageBox.Show("¿Seguro desea cancelar la creacion?", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (confirmarCancel == DialogResult.Yes)
                {
                    txtNombre.Text = "";
                    txtApellido.Text = "";
                    txtDNI.Text = "";
                    txtTel.Text = "";

                }
            }


        }

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

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtDNI_TextChanged(object sender, EventArgs e)
        {
            int minLength = 8; // Número mínimo de caracteres permitidos

            if (txtDNI.Text.Length < minLength)
            {
                lblErrorDni.Text = "DNI incompleto";
                btnAgregar.Enabled = false;

            }
            else
            {
                lblErrorDni.Text = "";
                btnAgregar.Enabled = true;
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

        private void btnVolver_Click(object sender, EventArgs e)
        {
            ListaClientes listClientes = new ListaClientes();
            listClientes.Show();
            this.Hide();
        }
    }
}
