using FrontEnd;
using Logica.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace Frontend
{
    public partial class ListaCanchas : Form
    {
        public ListaCanchas()
        {
            InitializeComponent();
        }

        Principal principal = new Principal();

        private void ListaCanchas_Load(object sender, EventArgs e)
        {
            dgvCanchas.DataSource = null;
            dgvCanchas.DataSource = Principal.ObtenerCanchas();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AltaCanchas altaCanchas = new AltaCanchas();
            altaCanchas.Show();
            this.Hide();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MenuInicio menuInicio = new MenuInicio();
            menuInicio.Show();
            this.Hide();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarCancha modCancha = new ModificarCancha();
            Cancha cancha_Elegida = (Cancha)dgvCanchas.CurrentRow.DataBoundItem;

            modCancha.ModificacionCancha(cancha_Elegida);
            modCancha.Show();
            this.Hide();

            dgvCanchas.DataSource = null; // Eliminar el origen de datos actual
            dgvCanchas.DataSource = Principal.ObtenerAdministradores(); // Asignar la lista actualizada
            dgvCanchas.Refresh();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //MIRO EL ID SELECCIONADO EN LA GRILLA
            object CanchaElegida = this.dgvCanchas.SelectedCells[0].Value;
            int IdSeleccionado = (int)CanchaElegida;

            Cancha valor_Elegido = (Cancha)dgvCanchas.CurrentRow.DataBoundItem;

            if (valor_Elegido != null)
            {
                var confirmacion = MessageBox.Show("Seguro que desea eliminar esta cancha con el ID" + IdSeleccionado, "ADVERTENCIA", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (confirmacion == DialogResult.OK)
                {
                    principal.removeCancha(valor_Elegido);
                    MessageBox.Show("Cancha eliminada con exito.", "Sistema");

                    //Ajustar los id para tener una secuencia de IDs.
                    //IDCancha.AdjustIDs(Principal.ObtenerCanchas());

                }

                if (confirmacion == DialogResult.Cancel)
                {
                    MessageBox.Show("Se cancelo la eliminacion de la cancha con el ID " + IdSeleccionado);
                }

            }
            else
            {
                MessageBox.Show("No hay ningun cliente seleccionado");
            }

            dgvCanchas.DataSource = null;

            dgvCanchas.DataSource = Principal.ObtenerCanchas();
        }
    }
}
