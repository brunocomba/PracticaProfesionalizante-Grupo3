using FrontEnd;
using Logica.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frontend
{
    public partial class HistorialTurnos : Form
    {
        public HistorialTurnos()
        {
            InitializeComponent();
            toolTip1.SetToolTip(btnCrear, "Crear nuevo turno.");
            toolTip1.SetToolTip(btnModificar, "Modificar un turno.");
            toolTip1.SetToolTip(btnEliminar, "Eliminar un turno.");


        }
        Principal principal = new Principal();
        List<string> listaPropiedades = new List<string>();
        private void HistorialTurnos_Load(object sender, EventArgs e)
        {
            dgvTurnos.DataSource = principal.ListadoTurnos();



        }


        private void txtFiltrarTurnos_TextChanged(object sender, EventArgs e)
        {
            string busqueda = txtFiltrarTurnos.Text.ToLower(); // Convierte el término de búsqueda a minúsculas



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

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

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
    }

}
