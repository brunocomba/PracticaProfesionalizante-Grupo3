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
            bool textBoxCompletos = principal.VerificarTextBoxCliente(txtNombre.Text, txtApellido.Text, txtDNI.Text, txtTEL.Text);
            bool DniCompleto = principal.DniCompleto(txtDNI.Text);
            bool TelCompleto = principal.TelCompleto(txtTEL.Text);

            if (textBoxCompletos && DniCompleto && TelCompleto == true)
            {
                var SIoNO = MessageBox.Show($"{clienteQueEdito.Nombre} por {txtNombre.Text}\n{clienteQueEdito.Apellido} por {txtApellido.Text}\n{clienteQueEdito.DNI} por {txtDNI.Text}\n{clienteQueEdito.Telefono} por {txtTEL.Text} "
                , "Seguro desea realizar esta modificacion?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (SIoNO == DialogResult.OK)
                {
                    principal.ModificarCliente(clienteQueEdito, txtNombre.Text, txtApellido.Text, int.Parse(txtDNI.Text), decimal.Parse(txtTEL.Text));

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
            else if (textBoxCompletos == false)
            {
                MessageBox.Show("Por favor completa todos los campos.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (DniCompleto == false)
            {
                MessageBox.Show("DNI incompleto.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (TelCompleto == false)
            {
                MessageBox.Show("Numero de telefono incompleto.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            ListaClientes.Show();
            this.Hide();
        }

        private void txtNombre_Validating(object sender, CancelEventArgs e)
        {
            string texto = txtNombre.Text;

            if (principal.SoloLetras(texto) == false)
            {
                MessageBox.Show("Solo se permiten LETRAS en este campo.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Clear();
            }
        }

        private void txtApellido_Validating(object sender, CancelEventArgs e)
        {
            string texto = txtApellido.Text;

            if (principal.SoloLetras(texto) == false)
            {
                MessageBox.Show("Solo se permiten LETRAS en este campo.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtApellido.Clear();

            }
        }

        private void txtDNI_Validating(object sender, CancelEventArgs e)
        {
            string texto = txtDNI.Text;

            if (principal.SoloNumeros(texto) == false)
            {
                MessageBox.Show("Solo se permiten NUMEROS en este campo.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDNI.Clear();

            }

            // VERIFICAR QUE EL DNI INGRESADO CONTENGA 8 DIGITOS. (LO CORRECTO)
            string DNI = txtDNI.Text.ToString();
            bool dniCompleto = principal.DniCompleto(DNI);
            if (dniCompleto == false)
            {
                lblErrorDni.Text = "DNI incompleto";
            }
            else
            {
                lblErrorDni.Text = "";
            }
        }

        private void txtTEL_Validating(object sender, CancelEventArgs e)
        {
            string texto = txtTEL.Text;


            if (principal.SoloNumeros(texto) == false)
            {
                MessageBox.Show("Solo se permiten NUMEROS en este campo.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTEL.Clear();

            }


            // VERIFICAR QUE EL TELEFONO INGRESADO CONTENGA 10 DIGITOS. (LO CORRECTO NRO DE AREA + NUMERO TEL)
            string Tel = txtTEL.Text.ToString();
            bool telVerificado = principal.TelCompleto(Tel);
            if (telVerificado == false)
            {
                lblErrorTel.Text = "Nro de telefono incompleto";
            }
            else
            {
                lblErrorTel.Text = "";
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
