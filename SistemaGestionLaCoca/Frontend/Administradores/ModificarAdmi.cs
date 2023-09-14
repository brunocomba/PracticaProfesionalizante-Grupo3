using FrontEnd;
using Logica.Clases;
using System.ComponentModel;

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

        //------------------------------------ MOSTRAR INFORMACION DEL OBJETO SELECCIONADO EN LA LISTA
        private Administrador adminQueEdito;
        public void ModificarAdmin(Administrador admin)
        {
            adminQueEdito = admin;
            txtNombre.Text = adminQueEdito.Nombre;
            txtApellido.Text = adminQueEdito.Apellido;
            txtDNI.Text = adminQueEdito.DNI.ToString();
            txtTel.Text = adminQueEdito.Telefono.ToString();
            txtUser.Text = adminQueEdito.Usuario.ToString();
            txtContra.Text = adminQueEdito.Contrasenia.ToString();

        }
        private void btnCrear_Click(object sender, EventArgs e)
        {
            // VOLVER A VALIDAR TODAS LAS VERIFICACIONES CUANDO APRETA EL BOTON CREAR

            bool veriTextBoxs = principal.VerificarTextBoxAdmi(txtNombre.Text, txtApellido.Text, txtDNI.Text, txtTel.Text, txtUser.Text, txtContra.Text, txtDNI.Text);

            bool coincidenContra = principal.confirmarPass(txtContra.Text, txtConfiContra.Text);

            bool requisitosContra = principal.CumpleRequisitos(txtContra.Text);

            bool requisitosDNI = principal.DniCompleto(txtDNI.Text);

            bool requisitosTel = principal.TelCompleto(txtTel.Text);

            if (coincidenContra == true && veriTextBoxs == true && requisitosContra == true && requisitosDNI == true && requisitosTel == true)
            {
                var SIoNO = MessageBox.Show($"Seguro desea realizar esta modificacion? ", "ATENCION!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (SIoNO == DialogResult.OK)
                {
                    principal.ModificarAdmin(adminQueEdito, txtNombre.Text, txtApellido.Text, int.Parse(txtDNI.Text),
                    decimal.Parse(txtTel.Text), txtUser.Text, txtContra.Text);

                    MessageBox.Show("Administrador modificado con exito!");
                    ListaAdmi.Show();
                    this.Hide();
                }
                else
                {
                    var confirmarCancelar = MessageBox.Show("Seguro desea cancelar la modificacion? ", "ATENCION!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
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



        //--------------------------------------------------- VALIDACIONES -------------------------------------------------------------.

        // Verificar si la contrasenia ingresada contiene al menos una letra mayúscula y al menos un número
        private void txtContra_Validated(object sender, EventArgs e)
        {
            bool verificacion = principal.CumpleRequisitos(txtContra.Text);

            if (verificacion == false)
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

        private void txtConfiContra_Validated(object sender, EventArgs e)
        {
            string password = txtContra.Text;
            string confirPassword = txtConfiContra.Text;

            if (principal.confirmarPass(password, confirPassword) == false)
            {
                lblErrorPass.Text = "Las contraseñas no coinciden";
            }
            else
            {
                lblErrorPass.Text = "";
            }
        }


        // VERIFICAR QUE EN LOS CAMPOS NUMERICOS SOLO HAYA NUMEROS Y EN LOS CAMPOS DE TEXTO SOLO LETRAS. (USUARIO Y CONTRASENIA NO SE VALIDAN)
        private void txtNombre_Validating_1(object sender, CancelEventArgs e)
        {
            string texto = txtNombre.Text;

            if (principal.SoloLetras(texto) == false)
            {
                MessageBox.Show("Solo se permiten LETRAS en este campo.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtApellido_Validating_1(object sender, CancelEventArgs e)
        {
            string texto = txtApellido.Text;

            if (principal.SoloLetras(texto) == false)
            {
                MessageBox.Show("Solo se permiten LETRAS en este campo.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtDNI_Validating(object sender, CancelEventArgs e)
        {
            string texto = txtDNI.Text;

            if (principal.SoloNumeros(texto) == false)
            {
                MessageBox.Show("Solo se permiten NUMEROS en este campo.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void txtTel_Validating_1(object sender, CancelEventArgs e)
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


        // mostrar la contra
        private void checkBoXMostrarContra_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBoXMostrarContra.Checked == true)
            {
                txtContra.PasswordChar = '\0';
                txtConfiContra.PasswordChar = '\0';
            }
            else
            {
                txtContra.PasswordChar = '*';
                txtConfiContra.PasswordChar = '*';
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            ListaAdmi.Show();
            this.Hide();
        }

    }
}
