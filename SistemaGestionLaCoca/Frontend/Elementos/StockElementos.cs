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

            Elemento elemento_Elegido = (Elemento)dgvElementos.CurrentRow.DataBoundItem;

            // acceder al metodo del forulario y pasarle lo seleccionado en la grilla
            modElemento.ModificacionElemento(elemento_Elegido);
            modElemento.Show();
            this.Hide();

            dgvElementos.DataSource = null; // Eliminar el origen de datos actual
            //dgvCanchas.DataSource = Principal.ObtenerAdministradores(); // Asignar la lista actualizada
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
    }
}
