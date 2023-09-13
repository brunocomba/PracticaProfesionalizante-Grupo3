using Logica.Clases;
using System.ComponentModel;


namespace FrontEnd
{
    public partial class AltaAdmin : Form
    {
        private Form formularioPrevio;
        public AltaAdmin(Form formularioPrevio)
        {
            InitializeComponent();
            this.formularioPrevio = formularioPrevio;
        }

        Principal principal = new Principal();
        ListaAdmi ListaAdmi = new ListaAdmi();

        // ALTA NUEVO ADMIN
        private void btnCrear_Click(object sender, EventArgs e)
        {
            bool veriTextBoxs = principal.VerificarTextBoxes(txtNombre.Text, txtApellido.Text, txtDni.Text, txtTel.Text, txtUser.Text, txtContra.Text, txtConfirPass.Text);

            bool coincidenContra = principal.confirmarPass(txtContra.Text, txtConfirPass.Text);

            bool requisitosContra = principal.CumpleRequisitos(txtContra.Text);

            bool requisitosDNI = principal.DniCompleto(txtDni.Text);

            bool requisitosTel = principal.TelCompleto(txtTel.Text);

            if (coincidenContra == true && veriTextBoxs == true && requisitosContra == true && requisitosDNI == true && requisitosTel == true)
            {
                var SIoNO = MessageBox.Show($"Seguro desea crear este nuevo usuario administador?", "ATENCION!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (SIoNO == DialogResult.OK)
                {
                    principal.AltaAdmi(txtNombre.Text, txtApellido.Text, int.Parse(txtDni.Text), decimal.Parse(txtTel.Text), txtUser.Text, txtContra.Text);

                    MessageBox.Show("Administrador creado con exito!");
                    ListaAdmi.Show();
                    this.Hide();
                }
                else
                {
                    var confirmarCancelar = MessageBox.Show("Seguro desea cancelar la creacion? ", "ATENCION!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (confirmarCancelar == DialogResult.OK)
                    {
                        ListaAdmi.Show();
                        this.Hide();
                    }
                }
            }
            if (veriTextBoxs == false)
            {
                MessageBox.Show("Por favor completa todos los campos.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (coincidenContra == false)
            {
                MessageBox.Show("Las contraseñas no coinciden.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (requisitosContra == false)
            {
                MessageBox.Show("Las contraseña debe tener al menos una MAYUSCULA y un NUMERO.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (requisitosDNI == false)
            {
                MessageBox.Show("DNI incompleto.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (requisitosTel == false)
            {
                MessageBox.Show("Numero de telefono incompleto.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


        // -------------------------------------------------------------------------------------------------------- VALIDACIONES DE DATOS.

        // VERIFICAR QUE LA CONTRASENIA INGRESADA CONTENGA AL MENOS UNA MAYUSCULA Y UN NUMNERO
        private void txtContra_Validated(object sender, EventArgs e)
        {
            bool verifiarRequisitos = principal.CumpleRequisitos(txtContra.Text);

            if (verifiarRequisitos == false)
            {
                errorProviderPass.SetError(txtContra, "La contraseña debe contener como minimo una MAYUSCULA y un NUMERO");
                txtContra.SelectAll();
            }
            else
            {
                errorProviderPass.SetError(txtContra, "");
            }
        }

        // VERIFICAR SI LAS CONTRASENIAS COINCIDEN
        private void txtConfirPass_Validating(object sender, CancelEventArgs e)
        {
            string password = txtContra.Text;
            string confirPassword = txtConfirPass.Text;

            bool verificarPass = principal.confirmarPass(password, confirPassword);
            if (verificarPass == false)
            {
                lblErrorPass.Text = "Las contraseñas no coinciden";
            }
            else
            {
                lblErrorPass.Text = "";

            }
        }


        // ----------------------------------------------------------------------------------------------------------------------------------
        // VERIFICAR QUE EN LOS CAMPOS NUMERICOS SOLO HAYA NUMEROS Y EN LOS CAMPOS DE TEXTO SOLO LETRAS. (USUARIO Y CONTRASENIA NO SE VALIDAN)
        private void txtNombre_Validating(object sender, CancelEventArgs e)
        {

            string texto = txtNombre.Text;

            if (principal.SoloLetras(texto) == false)
            {
                MessageBox.Show("Solo se permiten LETRAS en este campo.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtApellido_Validating(object sender, CancelEventArgs e)
        {

            string texto = txtApellido.Text;

            if (principal.SoloLetras(texto) == false)
            {
                MessageBox.Show("Solo se permiten LETRAS en este campo.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtDni_Validating(object sender, CancelEventArgs e)
        {
            string texto = txtDni.Text;

            if (principal.SoloNumeros(texto) == false)
            {
                MessageBox.Show("Solo se permiten NUMEROS en este campo.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // VERIFICAR QUE EL DNI INGRESADO CONTENGA 8 DIGITOS. (LO CORRECTO)
            string DNI = txtDni.Text.ToString();
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

        private void txtTel_Validating(object sender, CancelEventArgs e)
        {
            string texto = txtTel.Text;


            if (principal.SoloNumeros(texto) == false)
            {
                MessageBox.Show("Solo se permiten NUMEROS en este campo.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        // VOLVER
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            formularioPrevio.Show();
            this.Hide();
        }

        private void checkBoXMostrarContra_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoXMostrarContra.Checked == true)
            {
                txtContra.PasswordChar = '\0';
                txtConfirPass.PasswordChar = '\0';
            }
            else
            {
                txtContra.PasswordChar = '*';
                txtConfirPass.PasswordChar = '*';
            }
        }
    }

}
