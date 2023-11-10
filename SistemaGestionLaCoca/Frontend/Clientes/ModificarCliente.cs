using FrontEnd;
using Logica;
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

        private Cliente clienteQueEdito;

        Principal principal = new Principal();

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

                    txtNombre.Clear();
                    txtApellido.Clear();
                    txtDNI.Clear();
                    txtTEL.Clear();

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
            ListaClientes ListaClientes = new ListaClientes();
            ListaClientes.Show();
            this.Hide();
        }

        private void ModificarCliente_FormClosing(object sender, FormClosingEventArgs e)
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

        private void ModificarCliente_Load(object sender, EventArgs e)
        {
            cmboxClientes.Items.AddRange(principal.ObtenerListClientes().ToArray());

        }

        private void cmboxClientes_SelectedIndexChanged(object sender, EventArgs e)
        { 
            clienteQueEdito = (Cliente)cmboxClientes.SelectedItem;

            // mostrar los datos del cliente seleccionado en el combo.
            txtNombre.Text = clienteQueEdito.Nombre;
            txtApellido.Text = clienteQueEdito.Apellido;
            txtDNI.Text = clienteQueEdito.DNI.ToString();
            txtTEL.Text = clienteQueEdito.Telefono.ToString();
        }
    }
}
