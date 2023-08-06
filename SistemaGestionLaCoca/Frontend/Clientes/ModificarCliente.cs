using FrontEnd;
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
    public partial class ModificarCliente : Form
    {
        public ModificarCliente()
        {
            InitializeComponent();
        }
        Principal principal = new Principal();
        ListaClientes ListaClientes = new ListaClientes();

        private Cliente clienteQueEdito;
        public void ModificaCliente(Cliente cliente)
        {
            clienteQueEdito = cliente;
            txtNombre.Text = clienteQueEdito.nombre;
            txtApellido.Text = clienteQueEdito.apellido;
            txtDNI.Text = clienteQueEdito.dni.ToString();
            txtTel.Text = clienteQueEdito.telefono.ToString();

        }


        // VALIDACIONES
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var SIoNO = MessageBox.Show("Seguro desea realizar esta modificacion? ", "ATENCION!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (SIoNO == DialogResult.OK)
            {
                principal.modificarCliente(clienteQueEdito, txtNombre.Text, txtApellido.Text, int.Parse(txtDNI.Text),
                uint.Parse(txtTel.Text));

                MessageBox.Show("Cliente modificado con exito!");
                ListaClientes.Show();
                this.Hide();
            }
            else
            {
                ListaClientes.Show();
                this.Hide();
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

        private void txtDNI_TextChanged(object sender, EventArgs e)
        {
            int minLength = 8; // Número mínimo de caracteres permitidos

            if (txtDNI.Text.Length < minLength)
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

        private void button1_Click(object sender, EventArgs e)
        {
            ListaAdmi listaAdmi = new ListaAdmi();
            listaAdmi.Show();
            this.Hide();
        }
    }
}
