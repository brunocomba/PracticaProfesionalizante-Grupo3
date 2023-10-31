using Logica;
using Logica.Clases;
using System.Xml.Linq;

namespace Frontend.Elementos
{
    public partial class ModificarElemento : Form
    {
        public ModificarElemento()
        {
            InitializeComponent();
        }


        private Elemento elementoQueEdito;

        Principal principal = new Principal();
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                var SIoNO = MessageBox.Show($"Seguro desea realizar esta modificacion?\n\n{elementoQueEdito.Nombre} por {txtNombre.Text}\n{elementoQueEdito.Stock} por {txtStock.Text}" +
                    $"\n\nPresione ACEPTAR para continuar.", "ATENCION", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (SIoNO == DialogResult.OK)
                {
                    principal.ModificarElemento(elementoQueEdito, txtNombre.Text, txtStock.Text);
                    MessageBox.Show($"El elemento ha sido modificado con exito! ", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtNombre.Clear();
                    txtStock.Clear();
                }
                else
                {
                    var rtaCancel = MessageBox.Show("Seguro quiere cancelar los cambios?", "Advertencia", MessageBoxButtons.YesNo);
                    if (rtaCancel == DialogResult.Yes)
                    {
                        txtNombre.Clear();
                        txtStock.Clear();
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
            StockElementos elementos = new StockElementos();
            elementos.Show();
            this.Hide();
        }

        private void ModificarElemento_FormClosing(object sender, FormClosingEventArgs e)
        {
            ApplicationDbContex context = new ApplicationDbContex();

            // Preguntar si desea cerrar el programa o no.
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Administrador admActual = principal.BuscarAdmLogueado();
                var rta = MessageBox.Show("¿Seguro que deseas salir?", "Confirmar salida ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (rta == DialogResult.OK)
                {

                    Application.Exit();

                    // Cambiarle al administrador que esta logueado (actual) la propiedad Logueado a NO.
                    admActual.Logueado = Administrador.SioNo.NO;
                    context.Administradores.Update(admActual);
                    context.SaveChanges();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void ModificarElemento_Load(object sender, EventArgs e)
        {
            cmboxElementos.Items.AddRange(principal.ObtenerElementos().ToArray());
        }

        private void cmboxElementos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Elemento elementoElegido = (Elemento)cmboxElementos.SelectedItem;

            elementoQueEdito = elementoElegido;
            txtNombre.Text = elementoQueEdito.Nombre;
            txtStock.Text = elementoQueEdito.Stock.ToString();
        }
    }
}
