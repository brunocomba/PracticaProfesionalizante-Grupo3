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
using System.Windows.Controls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

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


        // ALTA NUEVO ADMIN
        private void btnCrear_Click(object sender, EventArgs e)
        {
            principal.altaAdmin(txtNombre.Text, txtApellido.Text, int.Parse(txtDni.Text), uint.Parse(txtTel.Text), txtUser.Text, txtContra.Text);
            var SIoNo = MessageBox.Show($"Administrador {txtNombre.Text} creado con exito. \nHaga click en ACEPTAR para continuar", "Crear nuevo usuario Administrador",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (SIoNo == DialogResult.OK)
            {
                formularioPrevio.Show();
                this.Hide();
            }
            else
            {
                var confirmarCancel = MessageBox.Show("¿Seguro desea cancelar la creacion?", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (confirmarCancel == DialogResult.Yes)
                {
                    txtNombre.Clear(); txtApellido.Clear(); txtDni.Clear(); txtTel.Clear(); txtUser.Clear(); txtContra.Clear(); txtConfirPass.Clear();
                }
            }

        }
        private void AltaAdmin_Load(object sender, EventArgs e)
        {
            // INHABILITAR LOS BOTONES Y TEXTBOX DE DATOS DE USUARIO
            btnCrear.Enabled = false;
            txtUser.Enabled = false;
            txtContra.Enabled = false;
            txtConfirPass.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            formularioPrevio.Show();
            this.Hide();
        }


        // -------------------------------------------------------------------------------------------------------- VALIDACIONES DE DATOS.

        // Verificar si la contrasenia ingresada contiene al menos una letra mayúscula y al menos un número
        private void txtContra_Validated(object sender, EventArgs e)
        {
            bool verifiarRequisitos = principal.CumpleRequisitos(txtContra.Text);

            if (verifiarRequisitos == false)
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
     
     

        // VERIFICAR QUE LOS TEXTBOX DE DATOS PERSONALES CONTENGAN ALGUN DATO, SI NO ES ASI NO SE HABILITARA EL BOTON PARA CREAR UN NUEVO ADMI.
        // ----------------------------------------------------------------------------------------------------------------------------------
        // VERIFICAR QUE EN LOS CAMPOS NUMERICOS SOLO HAYA NUMEROS Y EN LOS CAMPOS DE TEXTO SOLO LETRAS. (USUARIO Y CONTRASENIA NO SE VALIDAN)
        private void txtNombre_Validating(object sender, CancelEventArgs e)
        {

            string texto = txtNombre.Text;

            if (principal.SoloLetras(texto) == false)
            {
                MessageBox.Show("Solo se permiten LETRAS en este campo.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 


            bool verificacion = principal.VerificarTextBoxesDatosPersonales(txtNombre.Text, txtApellido.Text, txtDni.Text, txtTel.Text);
            // Volver a validar que el dni este completo
            string DNI = txtDni.Text.ToString();
            bool dniCompleto = principal.DniCompleto(DNI);

            // Volver a validar que el telefono este completo
            string Tel = txtTel.Text.ToString();
            bool telVerificado = principal.TelCompleto(Tel);

            if (telVerificado == true && verificacion == true && dniCompleto == true)
            {
                txtUser.Enabled = true;
                txtContra.Enabled = true;
                txtConfirPass.Enabled = true;
            }
            else
            {
                txtUser.Enabled = false;
                txtContra.Enabled = false;
                txtConfirPass.Enabled = false;
            }

        }

        private void txtApellido_Validating(object sender, CancelEventArgs e)
        {

            string texto = txtApellido.Text;

            if (principal.SoloLetras(texto) == false)
            {
                MessageBox.Show("Solo se permiten LETRAS en este campo.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            bool verificacion = principal.VerificarTextBoxesDatosPersonales(txtNombre.Text, txtApellido.Text, txtDni.Text, txtTel.Text);
            // Volver a validar que el dni este completo
            string DNI = txtDni.Text.ToString();
            bool dniCompleto = principal.DniCompleto(DNI);

            // Volver a validar que el telefono este completo
            string Tel = txtTel.Text.ToString();
            bool telVerificado = principal.TelCompleto(Tel);

            if (telVerificado == true && verificacion == true && dniCompleto == true)
            {
                txtUser.Enabled = true;
                txtContra.Enabled = true;
                txtConfirPass.Enabled = true;
            }
            else
            {
                txtUser.Enabled = false;
                txtContra.Enabled = false;
                txtConfirPass.Enabled = false;
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


            bool verificacion = principal.VerificarTextBoxesDatosPersonales(txtNombre.Text, txtApellido.Text, txtDni.Text, txtTel.Text);
            // Volver a validar que el telefono este completo
           
            string Tel = txtTel.Text.ToString();
            bool telVerificado = principal.TelCompleto(Tel);
            if (telVerificado == true && verificacion == true && dniCompleto == true)
            {
                txtUser.Enabled = true;
                txtContra.Enabled = true;
                txtConfirPass.Enabled = true;
            }
            else
            {
                txtUser.Enabled = false;
                txtContra.Enabled = false;
                txtConfirPass.Enabled = false;
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

            bool verificacion = principal.VerificarTextBoxesDatosPersonales(txtNombre.Text, txtApellido.Text, txtDni.Text, txtTel.Text);
            // Volver a validar que el dni este completo
            string DNI = txtDni.Text.ToString();
            bool dniCompleto = principal.DniCompleto(DNI);
            if (telVerificado == true && verificacion == true && dniCompleto == true)
            {
                txtUser.Enabled = true;
                txtContra.Enabled = true;
                txtConfirPass.Enabled = true;
            }
            else
            {
                txtUser.Enabled = false;
                txtContra.Enabled = false;
                txtConfirPass.Enabled = false;
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

            // VERIFICAR QUE TODOS LOS TEXTBOX DCONTENGAN ALGUN DATO, SI NO ES ASI NO SE HABILITARA EL BOTON PARA CREAR UN NUEVO ADMI
            // -----------------------------------------------------------------------------------------------------------------------------.
            bool verificacion = principal.VerificarTextBoxes(txtNombre.Text, txtApellido.Text, txtDni.Text, txtTel.Text, txtUser.Text, txtContra.Text, txtConfirPass.Text);
            btnCrear.Enabled = verificacion;

            // Volver a verificar que la contraseña cumple los requisitos
            bool verifiarRequisitos = principal.CumpleRequisitos(txtContra.Text);
            if (verificacion == true && verificarPass == true && verifiarRequisitos == true)
            {
                btnCrear.Enabled = true;
            }
            else
            {
                btnCrear.Enabled = false;
            }
        }


        private void txtUser_Validating(object sender, CancelEventArgs e)
        {

        }

        private void txtContra_Validating(object sender, CancelEventArgs e)
        {

        }

   
    }

}
