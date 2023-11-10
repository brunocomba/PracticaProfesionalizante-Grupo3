using Logica;
using Logica.Clases;

namespace Frontend.Elementos_Cancha
{
    public partial class AsignarElemento : Form
    {
        public AsignarElemento()
        {
            InitializeComponent();
        }

        Principal principal = new Principal();

        private void AsignarElemento_Load(object sender, EventArgs e)
        {
            cmboxCancha.Items.AddRange(principal.ObtenerListaCanchas().ToArray());
            cmboxElementos.Items.AddRange(principal.ObtenerElementos().ToArray());
        }

        private void btnAgregarCancha_Click(object sender, EventArgs e)
        {
            Cancha canchaElegida = (Cancha)cmboxCancha.SelectedItem;

            Elemento elementoElegido = (Elemento)cmboxElementos.SelectedItem;

            try
            {
                if (cmboxCancha.SelectedItem == null || cmboxElementos.SelectedItem == null)
                {
                    throw new Exception("No se ha seleccionado ningún elemento en el ComboBox."); // si los combos estan incompletos tira esta excepcion  
                }


            }
            catch (Exception cmboxIncompletos)
            {
                MessageBox.Show("Error: " + cmboxIncompletos.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            try
            {
                var confirmacion = MessageBox.Show($"Seguro que desea asignar el elemento: {cmboxElementos.SelectedItem} a la cancha: {cmboxCancha.SelectedItem}?\n" +
                $"Presione ACEPTAR  para confirmar.", "Atencion", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (confirmacion == DialogResult.OK)
                {
                    principal.AsigElementoCancha(canchaElegida, elementoElegido, txtCantidad.Text);
                    MessageBox.Show($"El elemento {elementoElegido.Nombre}  fue asignado correctamente a la cancha {canchaElegida.nombre}", "LISTO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCantidad.Clear();

                }
                else
                {
                    var confirmarCancelacion = MessageBox.Show($"Seguro que desea cancelar la operacion?", "Atencion", MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Warning);
                    if (confirmarCancelacion == DialogResult.OK)
                    {
                        txtCantidad.Clear();
                    }
                }
            }

            catch (Exception camposIncomoletos)
            {
                MessageBox.Show("Error: " + camposIncomoletos.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            ListaElementosCancha listaElementosCancha = new ListaElementosCancha();
            listaElementosCancha.Show();
            this.Hide();
        }

        private void AsignarElemento_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
