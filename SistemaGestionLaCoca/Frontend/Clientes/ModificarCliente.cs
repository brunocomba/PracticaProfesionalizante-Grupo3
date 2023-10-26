using FrontEnd;
using Logica.Clases;
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

        // mostar datos del cliente elegido en la grilla
        public void ModificaCliente(Cliente cliente)
        {
            clienteQueEdito = cliente;
            txtNombre.Text = clienteQueEdito.Nombre;
            txtApellido.Text = clienteQueEdito.Apellido;
            txtDNI.Text = clienteQueEdito.DNI.ToString();
            txtTEL.Text = clienteQueEdito.Telefono.ToString();

        }


        // VALIDACIONES
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                var SIoNO = MessageBox.Show($"{clienteQueEdito.Nombre} por {txtNombre.Text}\n{clienteQueEdito.Apellido} por {txtApellido.Text}\n{clienteQueEdito.DNI} por {txtDNI.Text}\n{clienteQueEdito.Telefono} por {txtTEL.Text} "
                , "Seguro desea realizar esta modificacion?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (SIoNO == DialogResult.OK)
                {
                    principal.ModificarCliente(clienteQueEdito, txtNombre.Text, txtApellido.Text, txtDNI.Text, txtTEL.Text);

                    MessageBox.Show($"El cliente ha sido modificado con exito! ", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    var confirmarCancelacion = MessageBox.Show($"Seguro que desea cancelar la operacion?", "Atencion", MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Warning);
                    if (confirmarCancelacion == DialogResult.OK)
                    {
                        txtNombre.Clear();
                        txtApellido.Clear();
                        txtDNI.Clear();
                        txtTEL.Clear();
                    }
                }
            }
            catch (Exception camposIncompletos)
            {
                MessageBox.Show("Error: " + camposIncompletos.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            ListaClientes.Show();
            this.Hide();
        }

    }
}
