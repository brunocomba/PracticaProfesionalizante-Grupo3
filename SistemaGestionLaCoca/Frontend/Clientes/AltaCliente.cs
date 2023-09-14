using Logica.Clases;

namespace Frontend
{
    public partial class AltaCliente : Form
    {
        private Form formPrevio;
        public AltaCliente(Form formPrevio)
        {
            InitializeComponent();
            this.formPrevio = formPrevio;
        }

        Principal principal = new Principal();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool textBoxCompletos = principal.VerificarTextBoxCliente(txtNombre.Text, txtApellido.Text, txtDNI.Text, txtTel.Text);
            bool DniCompleto = principal.DniCompleto(txtDNI.Text);
            bool TelCompleto = principal.TelCompleto(txtTel.Text);

            if (textBoxCompletos && DniCompleto && TelCompleto == true)
            {
                var respuesta = MessageBox.Show($"El cliente {txtNombre.Text} {txtApellido.Text} fue agregado con EXITO!\n\nPresione SI para seguir agregando clientes\nSi desea terminar presione NO."
               , "Atencion", MessageBoxButtons.YesNoCancel,
               MessageBoxIcon.Question);
                if (respuesta == DialogResult.No)
                {
                    principal.AltaCliente(txtNombre.Text, txtApellido.Text, int.Parse(txtDNI.Text), decimal.Parse(txtTel.Text));
                    ListaClientes listaClientes = new ListaClientes();
                    listaClientes.Show();
                    this.Hide();
                }
                if (respuesta == DialogResult.Yes)
                {
                    principal.AltaCliente(txtNombre.Text, txtApellido.Text, int.Parse(txtDNI.Text), uint.Parse(txtTel.Text));
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
            this.Hide();
            formPrevio.Show();
        }

        private void AltaCliente_Load(object sender, EventArgs e)
        {

        }

        private void txtNombre_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string texto = txtNombre.Text;

            if (principal.SoloLetras(texto) == false)
            {
                MessageBox.Show("Solo se permiten LETRAS en este campo.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Clear();

            }
        }

        private void txtApellido_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string texto = txtApellido.Text;

            if (principal.SoloLetras(texto) == false)
            {
                MessageBox.Show("Solo se permiten LETRAS en este campo.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtApellido.Clear();    
            }
        }

        private void txtDNI_Validating(object sender, System.ComponentModel.CancelEventArgs e)
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

        private void txtTel_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string texto = txtTel.Text;


            if (principal.SoloNumeros(texto) == false)
            {
                MessageBox.Show("Solo se permiten NUMEROS en este campo.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTel.Clear();

            }



            // VERIFICAR QUE EL TELEFONO INGRESADO CONTENGA 10 DIGITOS. (LO CORRECTO NRO DE AREA + NUMERO TEL)
            string Tel = txtTel.Text.ToString();
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
    }
}
