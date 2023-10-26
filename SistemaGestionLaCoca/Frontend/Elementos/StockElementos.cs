using FrontEnd;
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
    }
}
