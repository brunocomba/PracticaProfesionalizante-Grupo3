using FrontEnd;
using Logica;
using Logica.Clases;

namespace Frontend.Elementos
{
    public partial class StockElementos : Form
    {
        public StockElementos()
        {
            InitializeComponent();
        }

        Principal principal = new Principal();

        private void ListaElementos_Load(object sender, EventArgs e)
        {
            dgvElementos.DataSource = principal.ObtenerElementos();


            toolTip1.SetToolTip(btnAgregarElemento, "Crear nuevo elemento.");
            toolTip1.SetToolTip(btnModElemento, "Modificar un elemento.");
            toolTip1.SetToolTip(btnDelete, "Eliminar un elemento.");
        }


        private void btnAgregarElemento_Click(object sender, EventArgs e)
        {
            AltaElemento altaElemento = new AltaElemento();
            altaElemento.Show();
            this.Hide();
        }

        private void btnModElemento_Click(object sender, EventArgs e)
        {
            // Instancia del formulario de modificacion
            ModificarElemento modElemento = new ModificarElemento();

            if (dgvElementos.Rows.Count > 0)
            {
                modElemento.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No hay elementos registrados para realizar una modificacion.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dgvElementos.DataSource = null; // Eliminar el origen de datos actual
            dgvElementos.DataSource = principal.ObtenerElementos(); // Asignar la lista actualizada
            dgvElementos.Refresh();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MenuInicio menuInicio = new MenuInicio();
            menuInicio.Show();
            this.Hide();
        }

        private void btnAgregarStock_Click(object sender, EventArgs e)
        {
            AgregarStock agregarStock = new AgregarStock();
            agregarStock.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (dgvElementos.Rows.Count > 0)
            {
                Elemento elementoElegido = (Elemento)dgvElementos.CurrentRow.DataBoundItem;
                var confirmacion = MessageBox.Show($"Seguro que desea eliminar el elemento {elementoElegido.Nombre} del sistema? ", "ADVERTENCIA", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (confirmacion == DialogResult.OK)
                {
                    principal.RemoveElemento(elementoElegido);
                }
            }
            else
            {
                MessageBox.Show("No hay elementos registrados para eliminar.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dgvElementos.DataSource = null;
            dgvElementos.DataSource = principal.ObtenerElementos();
        }

        private void StockElementos_FormClosing(object sender, FormClosingEventArgs e)
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
