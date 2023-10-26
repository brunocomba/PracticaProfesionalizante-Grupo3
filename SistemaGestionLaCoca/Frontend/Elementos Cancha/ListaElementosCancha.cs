using Frontend.Elementos;
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

namespace Frontend.Elementos_Cancha
{
    public partial class ListaElementosCancha : Form
    {
        public ListaElementosCancha()
        {
            InitializeComponent();
        }

        Principal principal = new Principal();

        private void ListaElementosCancha_Load(object sender, EventArgs e)
        {
            dgvElementosCancha.DataSource = principal.ObtenerAsignacionDeElementos();
        }

     
        private void btnAgregarAsig_Click(object sender, EventArgs e)
        {
            AsignarElemento asignarElemento = new AsignarElemento();
            asignarElemento.Show();
            this.Hide();
        }

        private void btnModAsig_Click(object sender, EventArgs e)
        {
            // Instancia del formulario de modificacion
            ModificarAsignacion modAsignacion = new ModificarAsignacion();

            ElementoCancha asignacion_Elegida = (ElementoCancha)dgvElementosCancha.CurrentRow.DataBoundItem;

            // acceder al metodo del forulario y pasarle lo seleccionado en la grilla
            modAsignacion.ModificarAsignacionElement(asignacion_Elegida);
            modAsignacion.Show();
            this.Hide();

            dgvElementosCancha.DataSource = null; // Eliminar el origen de datos actual
            //dgvCanchas.DataSource = Principal.ObtenerAdministradores(); // Asignar la lista actualizada
            dgvElementosCancha.Refresh();
        }

        private void btnDeleteAsig_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            ListaCanchas listaCanchas = new ListaCanchas();
            listaCanchas.Show();
            this.Hide();
        }

    }
}
