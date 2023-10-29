using Frontend.Turnos;
using FrontEnd;
using Logica;
using Logica.Clases;
using System.Data;


namespace Frontend
{
    public partial class HistorialTurnos : Form
    {
        public HistorialTurnos()
        {
            InitializeComponent();


        }
        Principal principal = new Principal();
        List<string> listaPropiedades = new List<string>();
        private void HistorialTurnos_Load(object sender, EventArgs e)
        {
            dgvTurnos.DataSource = principal.ListadoTurnos();

            toolTip1.SetToolTip(btnCrear, "Crear nuevo turno.");
            toolTip1.SetToolTip(btnModificar, "Modificar un turno.");
            toolTip1.SetToolTip(btnEliminar, "Eliminar un turno.");

        }


        private void txtFiltrarTurnos_TextChanged(object sender, EventArgs e)
        {
            string busqueda = txtFiltrarTurnos.Text.ToLower(); // Convierte el término de búsqueda a minúsculas



        }
        private void CheckAsistio_CheckedChanged(object sender, EventArgs e)
        {

        }




        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            MenuInicio menuInicio = new MenuInicio();
            menuInicio.Show();
            this.Hide();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarTurno modTurno = new ModificarTurno();

            object celda1Turno = this.dgvTurnos.SelectedCells[0].Value; // obtener el valor de la columna Id-Asignacion
            int idTurno = (int)celda1Turno; // convertirlo en INT

            // pasarle al metodo del form de modificacion el turno elegido en la grilla
            modTurno.ModTurno(idTurno);
            modTurno.Show();
            this.Hide();

            dgvTurnos.DataSource = null; // Eliminar el origen de datos actual
            //dgvCanchas.DataSource = Principal.ObtenerAdministradores(); // Asignar la lista actualizada
            dgvTurnos.Refresh();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvTurnos.Rows.Count > 0)
            {
                object celda1Turno = this.dgvTurnos.SelectedCells[0].Value; // obtener el valor de la columna Id-Asignacion
                int idTurno = (int)celda1Turno; // convertirlo en INT

                var confirmacion = MessageBox.Show($"Seguro que desea eliminar el turno seleccionado del sistema? ", "ADVERTENCIA", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (confirmacion == DialogResult.OK)
                {
                    principal.EliminarTurno(idTurno);
                }
            }
            else
            {
                MessageBox.Show("No hay elementos registrados para eliminar.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dgvTurnos.DataSource = null;
            dgvTurnos.DataSource = principal.ListadoTurnos();

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            AltaTurno altaTurno = new AltaTurno();
            altaTurno.Show();
            this.Hide();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DataTable dt = principal.ListadoTurnos();
            DataTable resultadosFiltrados = principal.FiltrarDatos(dt, txtFiltrarTurnos.Text);

            dgvTurnos.DataSource = null;
            dgvTurnos.DataSource = resultadosFiltrados;
        }

        private void dgvTurnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void HistorialTurnos_FormClosing(object sender, FormClosingEventArgs e)
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